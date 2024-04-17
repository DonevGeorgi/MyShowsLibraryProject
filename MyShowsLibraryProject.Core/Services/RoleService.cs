using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Core.Models.RolesModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class RoleService : IRoleService
    {
        private readonly ILogger<RoleService> logger;
        private readonly IRepository repository;

        public RoleService(ILogger<RoleService> _logger,
            IRepository _repository)
        {
            logger = _logger;
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

            return role;
        }
        public async Task<bool> IsRoleAvailable(string roleName)
        {
            var role = await repository
                .TakeAllReadOnly<Role>()
                .Where(r => r.Name == roleName)
                .FirstOrDefaultAsync();

            if (role == null)
            {
                return false;
            }

            return true;
        }
        public async Task CreateAsync(RoleFormModel role)
        {
            if (await IsRoleAvailable(role.Name))
            {
                logger.LogInformation(MessagesConstants.EntityNotFountMessage,nameof(Role));
                throw new NullReferenceException(MessagesConstants.RoleDoesNotExistsMessage);
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
                logger.LogInformation(MessagesConstants.EntityIdNotFountMessage,nameof(Role),roleId);
                throw new NullReferenceException(MessagesConstants.RoleDoesNotExistsMessage);
            }

            roleToEdit.Name = role.Name;

            await repository.SaveChangesAsync();
        }
        public async Task DeleteAsync(int roleId)
        {
            await repository.DeleteAsync<Role>(roleId);
            await repository.SaveChangesAsync();
            logger.LogInformation(MessagesConstants.EntityDeleteMessage,nameof(Role),roleId);
        }
    }
}
