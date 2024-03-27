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
    }
}
