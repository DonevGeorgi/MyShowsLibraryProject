using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Models.EpisodeModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class EpisodeService : IEpisodeService
    {
        private readonly IRepository repository;
        private readonly ISeasonService seasonService;

        public EpisodeService(IRepository _repository,
            ISeasonService _seasonService)
        {
            repository = _repository;
            seasonService = _seasonService;
        }

        public async Task<IEnumerable<EpisodeInfoServiceModel>> GetEpisodeForSeason(int seasonId)
        {
            var episodes = await repository
                .TakeAllReadOnly<Episode>()
                .Where(e => e.SeasonId == seasonId)
                .Select(e => new EpisodeInfoServiceModel
                {
                    EpisodeId = e.EpisodeId,
                    SeasonNumber = e.SeasonNumber.ToString(),
                    EpisodeNumeration = e.EpisodeNumeration.ToString(),
                    ReleaseDate = e.ReleaseDate,
                })
                .ToListAsync();

            return episodes;    
        }
        public async Task<IEnumerable<EpisodeDetailsServiceModel>> GetEpisodeDetailsAsync(int seasonId)
        {
            var episodes = await repository
            .TakeAllReadOnly<Episode>()
            .Where(e => e.SeasonId == seasonId)
            .Select(e => new EpisodeDetailsServiceModel()
            {
                SeasonNumber = e.SeasonNumber,
                EpisodeNumeration = e.EpisodeNumeration,
                PosterUrl = e.PosterUrl,
                Summary = e.Summary,
                ReleaseDate = e.ReleaseDate,
                SeasonId = seasonId
            })
            .ToArrayAsync();

            return episodes;
        }
        public async Task<EpisodeDetailsServiceModel> GetEpisodeDetailsById(int episodeId)
        {
            var episode = await repository
                .TakeAllReadOnly<Episode>()
                .Where(e => e.EpisodeId == episodeId)
                .Select(e => new EpisodeDetailsServiceModel
                {
                    EpisodeId = e.EpisodeId,
                    SeasonNumber = e.SeasonNumber,
                    EpisodeNumeration = e.EpisodeNumeration,
                    PosterUrl = e.PosterUrl,
                    Summary = e.Summary,
                    ReleaseDate = e.ReleaseDate
                })
                .FirstOrDefaultAsync();

            if (episode == null)
            {
                throw new ArgumentNullException("Episode does not exists!");
            }

            return episode;
        }
        public async Task CreateAsync(EpisodeFormModel episode, int seasonId, int seasonNumeration)
        {
            var season = await seasonService.GetSeasonDetailsById(seasonId);

            if (season == null)
            {
                throw new ArgumentNullException("Season does not exists!");
            }

            var newEpisode = new Episode()
            {
                EpisodeNumeration = episode.EpisodeNumeration,
                PosterUrl = episode.PosterUrl,
                Summary = episode.Summary,
                ReleaseDate = episode.ReleaseDate,
                SeasonNumber = seasonNumeration,
                SeasonId = seasonId,
            };

            await repository.AddAsync(newEpisode);
            await repository.SaveChangesAsync();
        }
        public async Task EditAsync(int episodeId, EpisodeFormModel episode)
        {
            var episodeToEdit = await repository.GetByIdAsync<Episode>(episodeId);

            if (episodeToEdit == null)
            {
                throw new ArgumentNullException("Episode does not exists!");
            }

            episodeToEdit.EpisodeNumeration = episode.EpisodeNumeration;
            episodeToEdit.PosterUrl = episode.PosterUrl;
            episodeToEdit.Summary = episode.Summary;
            episodeToEdit.ReleaseDate = episode.ReleaseDate;

            await repository.SaveChangesAsync();
        }
        public async Task DeleteAsync(int episodeId)
        {
            await repository.DeleteAsync<Episode>(episodeId);
            await repository.SaveChangesAsync();
        }
    }
}
