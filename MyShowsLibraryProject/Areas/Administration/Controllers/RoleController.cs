using Microsoft.AspNetCore.Mvc;
using MyShowsLibraryProject.Core.Models.RolesModels;
using MyShowsLibraryProject.Core.Services.Contacts;

namespace MyShowsLibraryProject.Areas.Administration.Controllers
{
    public class RoleController : AdministrationController
    {
        private readonly IRoleService roleService;

        public RoleController(IRoleService _roleService)
        {
            roleService = _roleService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await roleService.GetAllReadonlyAsync();

            return View(model);
        }
        [HttpGet]
        public IActionResult Add()
        {
            var entity = new RoleFormModel();

            return View(entity);
        }
        [HttpPost]
        public async Task<IActionResult> Add(RoleFormModel model)
        {
            if (!ModelState.IsValid)
            {
                var entity = new RoleFormModel();

                return View(entity);
            }

            await roleService.CreateAsync(model);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int roleId)
        {
            var role = await roleService.GetRoleById(roleId);

            TempData["identifier"] = roleId;

            var model = new RoleFormModel()
            {
                Name = role.Name
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(RoleFormModel newRole)
        {
            if (!ModelState.IsValid)
            {
                return View(newRole);
            }

            var roleId = Convert.ToInt32(TempData["identifier"]);

            if (roleId == 0)
            {
                return BadRequest();
            }

            await roleService.EditAsync(roleId, newRole);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int roleId)
        {
            var role = await roleService.GetRoleById(roleId);

            if (role == null)
            {
                return BadRequest();
            }

            await roleService.DeleteAsync(roleId);

            return RedirectToAction(nameof(Index));
        }
    }
}
