using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Core.Models.EpisodeModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class EpisodeService : IEpisodeService
    {
        private readonly ILogger<EpisodeService> logger;
        private readonly IRepository repository;

        public EpisodeService(ILogger<EpisodeService> _logger,
            IRepository _repository)
        {
            logger = _logger;
            repository = _repository;
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

            return episode;
        }
        public async Task CreateAsync(EpisodeFormModel episode, int seasonId, int seasonNumeration)
        {
            var season = await repository.GetByIdAsync<Season>(seasonId);

            if (season == null)
            {
                logger.LogInformation(MessagesConstants.EntityIdNotFountMessage, nameof(Season), seasonId);
                throw new NullReferenceException(MessagesConstants.SeasonDoesNotExistsMessage);
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
            logger.LogInformation(MessagesConstants.EntityCreatedSuccesfullyMessage,nameof(Episode));
        }
        public async Task EditAsync(int episodeId, EpisodeFormModel episode)
        {
            var episodeToEdit = await repository.GetByIdAsync<Episode>(episodeId);

            if (episodeToEdit == null)
            {
                logger.LogInformation(MessagesConstants.EntityIdNotFountMessage,nameof(Episode),episodeId);
                throw new NullReferenceException(MessagesConstants.EpisodeDoesNotExistsMessage);
            }

            episodeToEdit.EpisodeNumeration = episode.EpisodeNumeration;
            episodeToEdit.PosterUrl = episode.PosterUrl;
            episodeToEdit.Summary = episode.Summary;
            episodeToEdit.ReleaseDate = episode.ReleaseDate;

            logger.LogInformation(MessagesConstants.EntityEditedSuccesfullyMessage, nameof(Episode));
            await repository.SaveChangesAsync();
        }
        public async Task DeleteAsync(int episodeId)
        {
            await repository.DeleteAsync<Episode>(episodeId);
            await repository.SaveChangesAsync();
            logger.LogInformation(MessagesConstants.EntityDeleteMessage, nameof(Episode),episodeId);
        }
    }
}
