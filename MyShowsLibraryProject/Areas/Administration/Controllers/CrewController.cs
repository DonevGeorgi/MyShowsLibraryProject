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

            return RedirectToAction("Index", "Crew", new { crewId = newCrewId, area = "default" });
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int crewId)
        {
            var crew = await crewService.GetCrewDetailsById(crewId);

            TempData["identifier"] = crewId;

            var model = new CrewFormModel()
            {
                Name = crew.Name,
                Pseudonyms = crew.Pseudonyms,
                Birthdate = crew.Birthdate,
                Nationality = crew.Nationality,
                PictureUrl = crew.PictureUrl,
                Biography = crew.Biography,
                MoreInfo = crew.MoreInfo
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(CrewFormModel newCrew)
        {
            if (!ModelState.IsValid)
            {
                return View(newCrew);
            }

            var crewId = Convert.ToInt32(TempData["identifier"]);

            if (crewId == 0)
            {
                return BadRequest();
            }

            await crewService.EditAsync(crewId, newCrew);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int crewId)
        {
            var crew = await crewService.GetCrewDetailsById(crewId);

            if (crew == null)
            {
                return BadRequest();
            }

            await crewService.DeleteAsync(crewId);

            return RedirectToAction(nameof(Index));
        }
    }
}
