using Microsoft.AspNetCore.Mvc;
using MyShowsLibraryProject.Core.Models.GenreModels;
using MyShowsLibraryProject.Core.Models.RolesModels;
using MyShowsLibraryProject.Core.Services.Contacts;

namespace MyShowsLibraryProject.Areas.Administration.Controllers
{
    public class CrewRoleController : AdministrationController
    {
        private readonly ICrewRoleService crewRoleService;

        public CrewRoleController(ICrewRoleService _crewRoleService)
        {
            crewRoleService = _crewRoleService;
        }

        [HttpGet]
        public async Task<IActionResult> AddRoleToCrew(int crewId)
        {
            var model = new RoleChoseFormModel()
            {
                RoleName = await crewRoleService.TakeAllRoles()
            };

            if (model.RoleName.Any() == false)
            {
                return NotFound();
            }

            TempData["crewIdentifier"] = crewId;

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddRoleToCrew(RoleChoseFormModel roles)
        {
            var crewId = Convert.ToInt32(TempData["crewIdentifier"]);

            await crewRoleService.AddRoleToCrewAsync(crewId, roles.RoleId);

            return RedirectToAction("Index", "Crew");
        }
        [HttpGet]
        public async Task<IActionResult> RemoveRoleFromCrew(int crewId)
        {
            var model = new RoleChoseFormModel()
            {
                RoleName = await crewRoleService.TakeAllRoles()
            };

            if (model.RoleName.Any() == false)
            {
                return NotFound();
            }

            TempData["crewIdentifier"] = crewId;

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> RemoveRoleFromCrew(RoleChoseFormModel roles)
        {
            var crewId = Convert.ToInt32(TempData["crewIdentifier"]);

            await crewRoleService.RemoveRoleFromCrewAsync(crewId, roles.RoleId);

            return RedirectToAction("Index","Crew");
        }
    }
}
