using MyShowsLibraryProject.Core.Models.CrewModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface ICrewSerieService
    {
        Task<IEnumerable<CrewInfoServiceModel>> TakeAllCrews(int serieId);
        Task AddCrewToSerie(int serieId, string crewName);
        Task RemoveCrewFromSerie(int serieId, string crewName);
    }
}
