using Microsoft.Extensions.Logging;
using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Core.Models.RolesModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class CrewRoleService : ICrewRoleService
    {
        private readonly ILogger<CrewRoleService> logger;
        private readonly IRepository repository;
        private readonly ICrewService crewService;
        private readonly IRoleService roleService;

        public CrewRoleService(ILogger<CrewRoleService> _logger,
            IRepository _repository,
            ICrewService _crewService,
            IRoleService _roleService)
        {
            logger = _logger;
            repository = _repository;
            crewService = _crewService;
            roleService = _roleService;
        }

        public async Task<IEnumerable<RoleInfoServiceModel>> TakeAllRoles()
        {
            var roles = await roleService.GetAllReadonlyAsync();

            return roles;
        }
        public async Task AddRoleToCrewAsync(int crewId, int roleId)
        {
            var crew = await crewService.GetCrewDetailsById(crewId);

            if (crew == null)
            {
                logger.LogInformation(MessagesConstants.EntityIdNotFountMessage, nameof(Crew), crewId);
                throw new NullReferenceException(MessagesConstants.CrewDoesNotExistsMessage);
            }

            if (!crew.Roles.Any(g => g.RoleId == roleId))
            {
                var newCrewRole = new CrewRole()
                {
                    CrewId = crewId,
                    RoleId = roleId
                };

                await repository.AddAsync(newCrewRole);
                await repository.SaveChangesAsync();
                logger.LogInformation(MessagesConstants.EntityCreatedSuccesfullyMessage, nameof(CrewRole));
            }
        }
        public async Task RemoveRoleFromCrewAsync(int crewId, int roleId)
        {
            var crew = await crewService.GetCrewDetailsById(crewId);

            if (crew == null)
            {
                logger.LogInformation(MessagesConstants.EntityIdNotFountMessage, nameof(Crew), crewId);
                throw new NullReferenceException(MessagesConstants.CrewDoesNotExistsMessage);
            }

            if (crew.Roles.Any())
            {
                if (crew.Roles.Any(g => g.RoleId == roleId))
                {
                    var modelToRemove = new CrewRole()
                    {
                        CrewId = crewId,
                        RoleId = roleId,
                    };

                    repository.Remove<CrewRole>(modelToRemove);
                    await repository.SaveChangesAsync();
                    logger.LogInformation(MessagesConstants.EntityDeleteSuccesfullyMessage,nameof(CrewRole));
                }
            }
        }
    }
}
