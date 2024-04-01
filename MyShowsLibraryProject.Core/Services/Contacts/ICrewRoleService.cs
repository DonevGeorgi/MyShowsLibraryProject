using MyShowsLibraryProject.Core.Models.RolesModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface ICrewRoleService
    {
        Task<IEnumerable<RoleInfoServiceModel>> TakeAllRoles();
        Task AddRoleToCrewAsync(int crewId, int roleId);
        Task RemoveRoleFromCrewAsync(int crewId, int roleId);
    }
}
