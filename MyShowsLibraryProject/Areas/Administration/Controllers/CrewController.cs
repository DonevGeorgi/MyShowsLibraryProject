using Microsoft.AspNetCore.Mvc;
using MyShowsLibraryProject.Core.Models.CrewModels;
using MyShowsLibraryProject.Core.Services.Contacts;

namespace MyShowsLibraryProject.Areas.Administration.Controllers
{
    public class CrewController : AdministrationController
    {
        private readonly ICrewService crewService;

        public CrewController(ICrewService _crewService)
        {
            crewService = _crewService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var entity = await crewService.GetAllReadonlyAsync();
            
            return View(entity);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var entity = new CrewFormModel();

            return View(entity);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CrewFormModel model)
        {
            if (!ModelState.IsValid)
            {
                var entity = new CrewFormModel();

                return View(entity);
            }

            var newCrewId = await crewService.CreateAsync(model);

            return RedirectToAction(nameof(Index));
        }
    }
}
