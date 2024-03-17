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

        public async Task<IEnumerable<SeasonDetailsServiceModel>> GetSeasonDetailsAsync(int seriesId)
        {
            var seasons = await repository
                .TakeAllReadOnly<Season>()
                .Where(s => s.SeriesId == seriesId)
                .Select(s => new SeasonDetailsServiceModel()
                {
                    SeasonId = s.SeriesId,
                    PosterUrl = s.PosterUrl,
                    YearOfRelease = s.YearOfRelease,
                    SeasonNumberation = s.SeasonNumberation,
                    EpisodesInSeason = s.EpisodesInSeason,
                    SerieId = seriesId
                })
                .ToListAsync();

            return seasons;
        }
    }
}
