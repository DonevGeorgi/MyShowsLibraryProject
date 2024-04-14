using Microsoft.Extensions.Logging;
using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class CrewSerieService : ICrewSerieService
    {
        private readonly ILogger<CrewSerieService> logger;
        private readonly IRepository repository;
        private readonly ICrewService crewService;
        private readonly ISerieService serieService;

        public CrewSerieService(ILogger<CrewSerieService> _logger,
            IRepository _repository,
            ICrewService _crewService,
            ISerieService _serieService)
        {
            logger = _logger;
            repository = _repository;
            crewService = _crewService;
            serieService = _serieService;
        }

        public async Task AddCrewToSerie(int serieId, string crewName)
        {
            var serie = await serieService.GetSerieDetailsByIdAsync(serieId);
            var crewId = await crewService.GetCrewName(crewName);

            if (serie == null)
            {
                logger.LogInformation(MessagesConstants.EntityIdNotFountMessage, nameof(Serie), serieId);
                throw new NullReferenceException(MessagesConstants.SerieDoesNotExistsMessage);
            }

            if (serie != null)
            {
                if (!serie.Crews.Any(g => g.Name == crewName))
                {
                    var newSerieCrew = new SerieCrew()
                    {
                        SerieId = serie.SerieId,
                        CrewId = crewId
                    };

                    await repository.AddAsync(newSerieCrew);
                    await repository.SaveChangesAsync();
                    logger.LogInformation(MessagesConstants.EntityCreatedSuccesfullyMessage, nameof(SerieCrew));
                }
            }
        }
        public async Task RemoveCrewFromSerie(int serieId, string crewName)
        {
            var serie = await serieService.GetSerieDetailsByIdAsync(serieId);
            var crewId = await crewService.GetCrewName(crewName);

            if (serie == null)
            {
                logger.LogInformation(MessagesConstants.EntityIdNotFountMessage, nameof(Serie), serieId);
                throw new NullReferenceException(MessagesConstants.SerieDoesNotExistsMessage);
            }

            if (serie.Crews.Any())
            {
                if (serie.Crews.Any(c => c.CrewId == crewId))
                {
                    var modelToRemove = new SerieCrew()
                    {
                        SerieId = serie.SerieId,
                        CrewId = crewId
                    };

                    repository.Remove<SerieCrew>(modelToRemove);
                    await repository.SaveChangesAsync();
                    logger.LogInformation(MessagesConstants.EntityDeleteSuccesfullyMessage,nameof(SerieCrew));
                }
            }
        }
    }
}
