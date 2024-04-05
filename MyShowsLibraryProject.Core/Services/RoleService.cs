using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Models.RolesModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRepository repository;

        public RoleService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<RoleInfoServiceModel>> GetAllReadonlyAsync()
        {
           var roles = await repository
                .TakeAllReadOnly<Role>()
                .Select(r => new RoleInfoServiceModel
                {
                    RoleId = r.RoleId,
                    Name = r.Name
                })
                .ToListAsync();

           return roles;
        }
        public async Task<RoleInfoServiceModel> GetRoleById(int roleId)
        {
            var role = await repository
                .TakeAllReadOnly<Role>()
                .Where(r => r.RoleId == roleId)
                .Select(r => new RoleInfoServiceModel
                {
                    RoleId = r.RoleId,
                    Name = r.Name
                })
                .FirstOrDefaultAsync();

            if(role == null)
            {
                throw new NullReferenceException("Role does not exists!");
            }

            return role;
        }
        public async Task<bool> IsRolePresent(string roleName)
        {
            var role = await repository
                .TakeAllReadOnly<Role>()
                .Where(r => r.Name == roleName)
                .FirstOrDefaultAsync();

            if (role == null)
            {
                return true;
            }

            return false;
        }
        public async Task CreateAsync(RoleFormModel role)
        {
            if (await IsRolePresent(role.Name))
            {
                throw new ArgumentNullException("Role does not exists!");
            }

            var newRole = new Role()
            {
                Name = role.Name,
            };

            await repository.AddAsync(newRole);   
            await repository.SaveChangesAsync();
        }
        public async Task EditAsync(int roleId, RoleFormModel role)
        {
            var roleToEdit = await repository.GetByIdAsync<Role>(roleId);

            if (roleToEdit == null)
            {
                throw new NullReferenceException("Role you want to edit does not exists!");
            }

            roleToEdit.Name = role.Name;

            await repository.SaveChangesAsync();
        }
        public async Task DeleteAsync(int roleId)
        {
            await repository.DeleteAsync<Role>(roleId);
            await repository.SaveChangesAsync();
        }
    }
}
