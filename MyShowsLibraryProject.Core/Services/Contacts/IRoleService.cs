using MyShowsLibraryProject.Core.Models.RolesModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface IRoleService
    {
        Task<IEnumerable<RoleInfoServiceModel>> GetAllReadonlyAsync();
        Task<RoleInfoServiceModel> GetRoleById(int roleId);
        Task CreateAsync(RoleFormModel role);
        Task<int> GetRoleIdFromName(string name);
        Task EditAsync(int roleId, RoleFormModel role);
        Task DeleteAsync(int roleId);
    }
}
