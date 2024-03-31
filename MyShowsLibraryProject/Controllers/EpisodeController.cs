using Microsoft.AspNetCore.Mvc;
using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Core.Services.Contacts;

namespace MyShowsLibraryProject.Controllers
{
    public class EpisodeController : BaseController
    {
        private readonly IEpisodeService episodeService;

        public EpisodeController(IEpisodeService _episodeService)
        {
            episodeService = _episodeService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int seasonId)
        {
            var model = await episodeService.GetEpisodeDetailsAsync(seasonId);

            if (model.Any() == false)
            {
                return BadRequest();
            }

            return View(model);
        }
    }
}
