using MyShowsLibraryProject.Core.Models.CrewModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface ICrewService
    {
        Task<IEnumerable<CrewInfoServiceModel>> GetAllReadonlyAsync();
        Task<int> GetCrewName(string crewName);
        Task<CrewDetailsServiceModel> GetCrewDetailsById(int crewId);
        Task<int> CreateAsync(CrewFormModel crew);
        Task EditAsync(int crewId, CrewFormModel crew);
        Task DeleteAsync(int crewId);
    }
}
