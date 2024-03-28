using Microsoft.AspNetCore.Mvc;
using MyShowsLibraryProject.Core.Models.SeasonModels;
using MyShowsLibraryProject.Core.Services.Contacts;

namespace MyShowsLibraryProject.Areas.Administration.Controllers
{
    public class SeasonController : AdministrationController
    {
        private readonly ISeasonService seasonService;

        public SeasonController(ISeasonService _seasonService)
        {
            seasonService = _seasonService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int seriesId)
        {
            var model = await seasonService.GetAllSeasonForSeries(seriesId);

               TempData["identitfier"] = seriesId;

            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var entity = new SeasonFormModel();
            
            return View(entity);
        }

        [HttpPost]
        public async Task<IActionResult> Add(SeasonFormModel model)
        {
            if (!ModelState.IsValid)
            {
                var entity = new SeasonFormModel();

                return View(entity);
            }

            var seriesId = (int)TempData["identitfier"];

            var seasonId = await seasonService.CreateAsync(model,seriesId);

            return RedirectToAction(nameof(Index));
        }
    }
}
