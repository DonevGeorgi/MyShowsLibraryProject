using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Core.Enumeration;
using MyShowsLibraryProject.Core.Models.CrewModels;
using MyShowsLibraryProject.Core.Models.GenreModels;
using MyShowsLibraryProject.Core.Models.ReviewModels;
using MyShowsLibraryProject.Core.Models.RolesModels;
using MyShowsLibraryProject.Core.Models.SerieModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class SerieService : ISerieService
    {
        private readonly ILogger<SerieService> logger;
        private readonly IRepository repository;

        public SerieService(ILogger<SerieService> _logger,
            IRepository _repository)
        {
            logger = _logger;
            repository = _repository;
        }

        public async Task<IEnumerable<SerieInfoServiceModel>> GetAllReadonlyAsync()
        {
            var series = await repository
                 .TakeAllReadOnly<Serie>()
                 .Select(s => new SerieInfoServiceModel
                 {
                     SeriesId = s.SeriesId,
                     Title = s.Title,
                     YearOfStart = s.YearOfStart,
                     YearOfEnd = s.YearOfEnd
                 })
                 .ToListAsync();

            return series;
        }
        public async Task<SeriesDetailsServiceModel> GetSerieDetailsByIdAsync(int serieId)
        {
            var serie = await repository
            .TakeAllReadOnly<Serie>()
            .Where(s => s.SeriesId == serieId)
            .Select(s => new SeriesDetailsServiceModel()
            {
                SerieId = s.SeriesId,
                Title = s.Title,
                PosterUrl = s.PosterUrl,
                TrailerUrl = s.TrailerUrl,
                YearOfStart = s.YearOfStart,
                YearOfEnd = s.YearOfEnd,
                Summary = s.Summary,
                OriginalAudioLanguage = s.OriginalAudioLanguage,
                ForMoreSummaryUrl = s.ForMoreSummaryUrl,
                Genres = repository
                    .TakeAllReadOnly<SerieGenre>()
                    .Where(sg => sg.SerieId == serieId)
                    .Select(sg => new GenreInfoSeviceModel()
                    {
                        GenreId = sg.GenreId,
                        Name = sg.Genre.Name,
                    })
                    .ToList(),
                Crews = repository
                .TakeAllReadOnly<SerieCrew>()
                .Where(sc => sc.SerieId == serieId)
                .Select(sc => new CrewCardInfoServiceModel()
                {
                    CrewId = sc.CrewId,
                    Name = sc.Crew.Name,
                    PictureUrl = sc.Crew.PictureUrl,
                    Roles = repository
                    .TakeAllReadOnly<CrewRole>()
                    .Where(cr => cr.CrewId == sc.CrewId)
                    .Select(cr => new RoleInfoServiceModel()
                    {
                        Name = cr.Role.Name
                    })
                    .ToList()
                })
                .ToList(),
                Reviews = repository
                .TakeAllReadOnly<SerieReview>()
                .Where(sr => sr.SerieId == serieId)
                .Select(r => new ReviewInfoServiceModel
                {
                    ReviewId = r.ReviewId,
                    Rating = r.Review.Rating,
                    Content = r.Review.Content,
                    UserUsername = repository
                        .TakeAllReadOnly<UserReview>()
                        .Where(ur => ur.ReviewIdentifier == r.ReviewId)
                        .Select(ur => ur.UserId)
                        .First()
                })
                .ToList()
            })
            .FirstOrDefaultAsync();

            return serie;
        }
        public async Task<SerieQueryServiceModel> GetAllCardInfoAsync(
            string? searchTerm = null,
            SerieSorting sorting = SerieSorting.FromA,
            int currPage = 1,
            int seriePerPage = 4)
        {
            var serie = repository.TakeAllReadOnly<Serie>();

            if (searchTerm != null)
            {
                string normalizeSearchTerm = searchTerm.ToLower();
                serie = serie
                    .Where(m => m.Title.ToLower().Contains(normalizeSearchTerm));
            }

            serie = sorting switch
            {
                SerieSorting.FromA => serie.OrderBy(m => m.Title),
                SerieSorting.ToA => serie.OrderByDescending(m => m.Title),
                _ => serie
            };

            var serieToShow = await serie
                .Skip((currPage - 1) * seriePerPage)
                .Take(seriePerPage)
                .Select(s => new SeriesCardInfoServiceModel()
                {
                    SerieId = s.SeriesId,
                    Title = s.Title,
                    PosterUrl = s.PosterUrl,
                    StartYear = s.YearOfStart,
                    EndYear = s.YearOfEnd,
                    Rating = Math.Round(((double)repository
                        .TakeAll<SerieReview>()
                        .Where(r => r.SerieId == s.SeriesId)
                        .Average(mr => mr.Review.Rating)), 2)
                        .ToString()
                })
                .ToListAsync();

            int totalSerie = await serie.CountAsync();

            return new SerieQueryServiceModel()
            {
               Serie = serieToShow,
               TotalSerieCount = totalSerie
            };
        }
        public async Task<int> CreateAsync(SerieFormModel serie)
        {
            var newSeire = new Serie()
            {
                Title = serie.Title,
                PosterUrl = serie.PosterUrl,
                TrailerUrl = serie.TrailerUrl,
                YearOfStart = serie.YearOfStart,
                YearOfEnd = serie.YearOfEnd,
                OriginalAudioLanguage = serie.OriginalAudioLanguage,
                Summary = serie.Summary,
                ForMoreSummaryUrl = serie.ForMoreSummaryUrl
            };

            await repository.AddAsync(newSeire);
            await repository.SaveChangesAsync();

            logger.LogInformation(MessagesConstants.EntityCreatedMessage,nameof(Serie),newSeire.Title);
            return newSeire.SeriesId;
        }
        public async Task EditAsync(int serieId, SerieFormModel serie)
        {
            var serieToEdit = await repository.GetByIdAsync<Serie>(serieId); 

            if (serieToEdit == null)
            {
                logger.LogInformation(MessagesConstants.EntityIdNotFountMessage,nameof(Serie),serieId);
                throw new NullReferenceException(MessagesConstants.SerieEditDoesNotExistMessage);
            }

            serieToEdit.Title = serie.Title;
            serieToEdit.PosterUrl = serie.PosterUrl;
            serieToEdit.TrailerUrl = serie.TrailerUrl;
            serieToEdit.YearOfStart = serie.YearOfStart;
            serieToEdit.YearOfEnd = serie.YearOfEnd;
            serieToEdit.Summary = serie.Summary;
            serieToEdit.OriginalAudioLanguage = serie.OriginalAudioLanguage;
            serieToEdit.ForMoreSummaryUrl = serie.ForMoreSummaryUrl;

            logger.LogInformation(MessagesConstants.EntityEditedMessage,nameof(Serie),serieToEdit.Title);
            await repository.SaveChangesAsync();
        }
        public async Task DeleteAsync(int serieId)
        {
            await repository.DeleteAsync<Serie>(serieId);
            await repository.SaveChangesAsync();
            logger.LogInformation(MessagesConstants.EntityDeleteMessage,nameof(Serie),serieId);
        }
        public async Task<bool> IsSeriePresent(int serieId)
        {
            var result = await repository.GetByIdAsync<Serie>(serieId);

            if (result == null)
            {
                return false;
            }

            return true;
        }
    }
}
