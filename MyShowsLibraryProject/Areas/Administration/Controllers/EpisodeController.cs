using Microsoft.AspNetCore.Mvc;
using MyShowsLibraryProject.Core.Models.EpisodeModels;
using MyShowsLibraryProject.Core.Services.Contacts;

namespace MyShowsLibraryProject.Areas.Administration.Controllers
{
    public class EpisodeController : AdministrationController
    {
        private readonly IEpisodeService episodeService;

        public EpisodeController(IEpisodeService _episodeService)
        {
            episodeService = _episodeService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int seasonId,int numeration)
        {
            var model = await episodeService.GetEpisodeForSeason(seasonId);

            TempData["seasonIdentifier"] = seasonId;
            TempData["numeration"] = numeration;

            return View(model);
        }
        [HttpGet]
        public IActionResult Add() 
        {
            var entity = new EpisodeFormModel();

            return View(entity);
        }
        [HttpPost]
        public async Task<IActionResult> Add(EpisodeFormModel model)
        {
            if(!ModelState.IsValid)
            {
                var entity = new EpisodeFormModel();

                return View(entity);
            }

            var seasonId = Convert.ToInt32(TempData["seasonIdentifier"]);
            var numeration = Convert.ToInt32(TempData["numeration"]);

            await episodeService.CreateAsync(model, seasonId, numeration);

            return RedirectToAction(nameof(Index), new { seasonId = seasonId});
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int episodeId)
        {
            var episode = await episodeService.GetEpisodeDetailsById(episodeId);

            TempData["identifier"] = episodeId;

            var model = new EpisodeFormModel()
            {
                SeasonNumber = episode.SeasonNumber,
                EpisodeNumeration = episode.EpisodeNumeration,
                PosterUrl = episode.PosterUrl,
                Summary = episode.Summary,
                ReleaseDate = episode.ReleaseDate
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EpisodeFormModel newEpisode)
        {
            if (!ModelState.IsValid)
            {
                return View(newEpisode);
            }

            var episodeId = Convert.ToInt32(TempData["identifier"]);

            if (episodeId == 0)
            {
                return BadRequest();
            }

            var seasonId = Convert.ToInt32(TempData["seasonIdentifier"]);

            await episodeService.EditAsync(episodeId, newEpisode);

            return RedirectToAction(nameof(Index), new { seasonId = seasonId });
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int episodeId)
        {
            var episode = await episodeService.GetEpisodeDetailsById(episodeId);

            if (episode == null)
            {
                return BadRequest();
            }

            var seasonId = Convert.ToInt32(TempData["seasonIdentifier"]);

            await episodeService.DeleteAsync(episodeId);

            return RedirectToAction(nameof(Index), new { seasonId });
        }
    }
}
