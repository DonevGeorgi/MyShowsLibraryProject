using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Models.SeasonModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class SeasonService : ISeasonService
    {
        private readonly IRepository repository;

        public SeasonService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<SeasonInfoServiceModel>> GetAllSeasonForSeries(int seriesId)
        {
            var seasons = await repository
                .TakeAllReadOnly<Season>()
                .Where(s => s.SeriesId == seriesId)
                .Select(s => new SeasonInfoServiceModel
                {
                    SeasonId = s.SeasonId,
                    SeasonNumberation = s.SeasonNumeration,
                    EpisodesInSeason = s.EpisodesInSeason,
                    YearOfRelease = s.YearOfRelease
                })
                .ToListAsync();

            return seasons;
        }
        public async Task<int> CreateAsync(SeasonFormModel season, int seriesId)
        {
            if (seriesId == 0)
            {
                //exception
            }

            var newSeason = new Season()
            {
                PosterUrl = season.PosterUrl,
                SeasonNumeration = season.SeasonNumberation,
                YearOfRelease = season.YearOfRelease,
                EpisodesInSeason = season.EpisodesInSeason,
                SeriesId = seriesId
            };

            await repository.AddAsync(newSeason);
            await repository.SaveChangesAsync();

            return newSeason.SeasonId;
        }
        public async Task<IEnumerable<SeasonDetailsServiceModel>> GetSeasonDetailsAsync(int seriesId)
        {
            var seasons = await repository
                .TakeAllReadOnly<Season>()
                .Where(s => s.SeriesId == seriesId)
                .Select(s => new SeasonDetailsServiceModel()
                {
                    SeasonId = s.SeasonId,
                    PosterUrl = s.PosterUrl,
                    YearOfRelease = s.YearOfRelease,
                    SeasonNumberation = s.SeasonNumeration,
                    EpisodesInSeason = s.EpisodesInSeason,
                    SerieId = seriesId
                })
                .ToListAsync();

            return seasons;
        }
    }
}
