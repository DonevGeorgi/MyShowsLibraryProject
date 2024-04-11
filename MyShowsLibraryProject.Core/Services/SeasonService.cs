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
        public async Task<SeasonDetailsServiceModel> GetSeasonDetailsById(int seasonId)
        {
            var season = await repository
                .TakeAllReadOnly<Season>()
                .Where(s => s.SeasonId == seasonId)
                .Select(s => new SeasonDetailsServiceModel
                {
                    SeasonId = s.SeasonId,
                    PosterUrl = s.PosterUrl,
                    YearOfRelease = s.YearOfRelease,
                    SeasonNumberation = s.SeasonNumeration,
                    EpisodesInSeason = s.EpisodesInSeason
                })
                .FirstOrDefaultAsync();

            if (season == null)
            {
                throw new ArgumentNullException("Season does not exists!");
            }

            return season;
        }
        public async Task CreateAsync(SeasonFormModel season, int seriesId)
        {
            var seasonForCreation = await GetSeasonDetailsById(seriesId);

            if (seasonForCreation == null)
            {
                throw new ArgumentNullException("Serie does not exists!");
            }

            var newSeason = new Season()
            {
                PosterUrl = season.PosterUrl,
                SeasonNumeration = season.SeasonNumeration,
                YearOfRelease = season.YearOfRelease,
                EpisodesInSeason = season.EpisodesInSeason,
                SeriesId = seriesId
            };

            await repository.AddAsync(newSeason);
            await repository.SaveChangesAsync();
        }
        public async Task EditAsync(int seasonId, SeasonFormModel season)
        {
            var seasonToEdit = await repository.GetByIdAsync<Season>(seasonId);

            if (seasonToEdit == null)
            {
                throw new ArgumentNullException("Season does not exists!");
            }

            seasonToEdit.PosterUrl = season.PosterUrl;
            seasonToEdit.SeasonNumeration = season.SeasonNumeration;
            seasonToEdit.YearOfRelease = season.YearOfRelease;
            seasonToEdit.EpisodesInSeason = season.EpisodesInSeason;

            await repository.SaveChangesAsync();
        }
        public async Task DeleteAsync(int seasonId)
        {
            await repository.DeleteAsync<Season>(seasonId);
            await repository.SaveChangesAsync();
        }
    }
}
