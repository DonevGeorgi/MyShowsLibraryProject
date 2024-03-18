using MyShowsLibraryProject.Core.Models.CrewModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface ICrewService
    {
        Task<CrewDetailsServiceModel> GetCrewDetailsById(int crewId);
    }
}
