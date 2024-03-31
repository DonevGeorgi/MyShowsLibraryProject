using Microsoft.AspNetCore.Mvc;
using MyShowsLibraryProject.Core.Services.Contacts;

namespace MyShowsLibraryProject.Controllers
{
    public class SeasonController : BaseController
    {
        private readonly ISeasonService seasonService;

        public SeasonController(ISeasonService _seasonService)
        {
            seasonService = _seasonService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int serieId)
        {
            var model = await seasonService.GetSeasonDetailsAsync(serieId);

            if (model.Any() == false)
            {
                return NotFound();
            }

            return View(model);
        }
    }
}
