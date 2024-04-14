using Microsoft.AspNetCore.Mvc;
using MyShowsLibraryProject.Core.Services.Contacts;

namespace MyShowsLibraryProject.Controllers
{
    public class CrewController : BaseController
    {
        private readonly ICrewService crewService;

        public CrewController(ICrewService _crewService)
        {
            crewService = _crewService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int crewId)
        {
            var model = await crewService.GetCrewDetailsById(crewId);

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }
    }
}
