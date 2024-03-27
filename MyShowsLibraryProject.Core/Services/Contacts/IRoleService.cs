using MyShowsLibraryProject.Core.Models.RolesModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface IRoleService
    {
        Task<IEnumerable<RoleInfoServiceModel>> GetAllReadonlyAsync();
        Task CreateAsync(RoleFormModel role);
        Task<int> GetRoleIdFromName(string name);
    }
}
