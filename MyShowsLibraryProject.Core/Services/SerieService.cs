using Microsoft.EntityFrameworkCore;
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
        private readonly IRepository repository;
        private readonly IGenreService genreService;

        public SerieService(IRepository _repository,
            IGenreService _genreService)
        {
            repository = _repository;
            genreService = _genreService;
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
        public async Task<IEnumerable<SeriesCardInfoServiceModel>> GetAllCardInfoAsync()
        {
            var series = await repository
            .TakeAllReadOnly<Serie>()
            .Select(s => new SeriesCardInfoServiceModel()
            {
                SerieId = s.SeriesId,
                Title = s.Title,
                PosterUrl = s.PosterUrl,
                StartYear = s.YearOfStart,
                EndYear = s.YearOfEnd,
                //Later when you add review try make method and add null check not implemented yet
                Rating = repository
                        .TakeAll<SerieReview>()
                        .Where(sr => sr.SerieId == s.SeriesId)
                        .Average(sr => sr.Review.Rating)
                        .ToString()
            })
            .ToListAsync();

            return series;
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

            return newSeire.SeriesId;
        }
        public async Task EditAsync(int serieId, SerieFormModel serie)
        {
            var movieToEdit = await repository.GetByIdAsync<Serie>(serieId);

            if (movieToEdit == null)
            {
                //Exception
            }

            movieToEdit.Title = serie.Title;
            movieToEdit.PosterUrl = serie.PosterUrl;
            movieToEdit.TrailerUrl = serie.TrailerUrl;
            movieToEdit.YearOfStart = serie.YearOfStart;
            movieToEdit.YearOfEnd = serie.YearOfEnd;
            movieToEdit.Summary = serie.Summary;
            movieToEdit.OriginalAudioLanguage = serie.OriginalAudioLanguage;
            movieToEdit.ForMoreSummaryUrl = serie.ForMoreSummaryUrl;

            await repository.SaveChangesAsync();
        }
        public async Task DeleteAsync(int serieId)
        {
            await repository.DeleteAsync<Serie>(serieId);
            await repository.SaveChangesAsync();
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
                .Select(sg => new GenreInfoSeviceModel()
                {
                    Name = sg.Genre.Name,
                })
                .ToList(),
                Crews = repository
                .TakeAllReadOnly<SerieCrew>()
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
                    Rating = r.Review.Rating.ToString(),
                    Content = r.Review.Content,
                    UserUsername = repository
                        .TakeAllReadOnly<UserReview>()
                        .Where(ur => ur.ReviewId == r.ReviewId)
                        .Select(ur => ur.User.UserName)
                        .First()
                })
                .ToList()
            })
            .FirstAsync();

            return serie;
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
