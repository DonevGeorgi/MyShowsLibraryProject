using MyShowsLibraryProject.Core.Models.RolesModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface IRoleService
    {
        Task<IEnumerable<RoleInfoServiceModel>> GetAllReadonlyAsync();
        Task<bool> IsRolePresent(string roleName);
        Task<RoleInfoServiceModel> GetRoleById(int roleId);
        Task CreateAsync(RoleFormModel role);
        Task EditAsync(int roleId, RoleFormModel role);
        Task DeleteAsync(int roleId);
    }
}
