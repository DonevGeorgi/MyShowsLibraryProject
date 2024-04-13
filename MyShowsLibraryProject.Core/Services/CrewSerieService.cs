using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class CrewSerieService : ICrewSerieService
    {
        private readonly IRepository repository;
        private readonly ICrewService crewService;
        private readonly ISerieService serieService;

        public CrewSerieService(IRepository _repository,
            ICrewService _crewService,
            ISerieService _serieService)
        {
            repository = _repository;
            crewService = _crewService;
            serieService = _serieService;
        }

        public async Task<int> GetCrewName(string crewName)
        {
            var crew = await crewService.GetCrewName(crewName);

            if (crew == 0)
            {
                throw new NullReferenceException("Crew with this name does not exists!");
            }

            return crew;
        }
        public async Task AddCrewToSerie(int serieId, string crewName)
        {
            var serie = await serieService.GetSerieDetailsByIdAsync(serieId);
            var crewId = await GetCrewName(crewName);

            if (serie == null)
            {
                throw new NullReferenceException();
            }

            if (serie.Crews.Any(g => g.Name == crewName))
            {
                throw new NullReferenceException("Serie contains crew already!");
            }

            var newSerieCrew = new SerieCrew()
            {
                SerieId = serie.SerieId,
                CrewId = crewId
            };

            await repository.AddAsync(newSerieCrew);
            await repository.SaveChangesAsync();
        }
        public async Task RemoveCrewFromSerie(int serieId, string crewName)
        {
            var serie = await serieService.GetSerieDetailsByIdAsync(serieId);
            var crewId = await GetCrewName(crewName);

            if (serie == null)
            {
                throw new NullReferenceException("Serie you chose dont exist!");
            }

            if (!serie.Crews.Any())
            {
                throw new NullReferenceException("Serie dont have any crew!");
            }

            if (!serie.Crews.Any(c => c.CrewId == crewId))
            {
                throw new NullReferenceException("Movie dont have this crew!");
            }

            var modelToRemove = new SerieCrew()
            {
                SerieId = serie.SerieId,
                CrewId = crewId
            };

            repository.Remove<SerieCrew>(modelToRemove);
            await repository.SaveChangesAsync();
        }
    }
}
