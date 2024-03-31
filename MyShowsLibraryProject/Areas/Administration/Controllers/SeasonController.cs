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

            var seriesId = Convert.ToInt32(TempData["identitfier"]);

            await seasonService.CreateAsync(model,seriesId);

            return RedirectToAction("Index", "Season", new { serieId = seriesId, area = "default" });
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int seasonId)
        {
            var season = await seasonService.GetSeasonDetailsById(seasonId);

            TempData["identifier"] = seasonId;

            var model = new SeasonFormModel()
            {
                PosterUrl = season.PosterUrl,
                YearOfRelease = season.YearOfRelease,
                SeasonNumberation = season.SeasonNumberation,
                EpisodesInSeason = season.EpisodesInSeason
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(SeasonFormModel newSeason)
        {
            if (!ModelState.IsValid)
            {
                return View(newSeason);
            }

            var seasonId = Convert.ToInt32(TempData["identifier"]);

            if (seasonId == 0)
            {
                return BadRequest();
            }

            var seriesId = Convert.ToInt32(TempData["identitfier"]);

            await seasonService.EditAsync(seasonId, newSeason);

            return RedirectToAction(nameof(Index), new { seriesId });
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int seasonId)
        {
            var season = await seasonService.GetSeasonDetailsById(seasonId);

            if (season == null)
            {
                return BadRequest();
            }

            var seriesId = Convert.ToInt32(TempData["identitfier"]);

            await seasonService.DeleteAsync(seasonId);

            return RedirectToAction(nameof(Index), new { seriesId });
        }
    }
}
