using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Models.CrewModels;
using MyShowsLibraryProject.Core.Models.GenreModels;
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

        public SerieService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<SeriesCardInfoServiceModel>> GetAllReadonlyAsync()
            => await repository
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
                .Select(sc => new CrewInfoServiceModel()
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
                .ToList()
            })
            .FirstAsync();

            return serie;
        }
    }
}
