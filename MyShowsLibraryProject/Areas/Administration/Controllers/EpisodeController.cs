using Microsoft.AspNetCore.Mvc;
using MyShowsLibraryProject.Core.Models.EpisodeModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Models;

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

            TempData["identifier"] = seasonId;
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

            var seasonId = (int)TempData["identifier"];
            var numeration = (int)TempData["numeration"];

            await episodeService.CreateAsync(model, seasonId, numeration);

            return RedirectToAction(nameof(Index), new {seasonId = seasonId});
        }
    }
}
