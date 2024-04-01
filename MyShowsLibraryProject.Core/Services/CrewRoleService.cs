using MyShowsLibraryProject.Core.Models.RolesModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class CrewRoleService : ICrewRoleService
    {
        private readonly IRepository repository;
        private readonly ICrewService crewService;
        private readonly IRoleService roleService;

        public CrewRoleService(IRepository _repository,
            ICrewService _crewService,
            IRoleService _roleService) 
        { 
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
                throw new NullReferenceException();
            }

            if (crew.Roles.Any(g => g.RoleId == roleId))
            {
                throw new ArgumentException("Crew contains role already!");
            }

            var newCrewRole = new CrewRole()
            {
                CrewId = crewId,
                RoleId = roleId
            };

            await repository.AddAsync(newCrewRole);
            await repository.SaveChangesAsync();
        }
        public async Task RemoveRoleFromCrewAsync(int crewId, int roleId)
        {
            var crew = await crewService.GetCrewDetailsById(crewId);

            if (crew == null)
            {
                throw new NullReferenceException("Crew you chose dont exist!");
            }

            if (!crew.Roles.Any())
            {
                throw new ArgumentException("Crew dont have role!");
            }

            if (!crew.Roles.Any(g => g.RoleId == roleId))
            {
                throw new ArgumentException("Crew dont have chosen role!");
            }

            var modelToRemove = new CrewRole()
            {
               CrewId = crewId,
               RoleId = roleId,
            };

            repository.Remove<CrewRole>(modelToRemove);
            await repository.SaveChangesAsync();
        }
    }
}
