using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyShowsLibraryProject.Core.Services.Contacts;

namespace MyShowsLibraryProject.Controllers
{
    public class MovieController : BaseController
    {
        private readonly IMovieService movieService;

        public MovieController(IMovieService _movieService)
        {
            movieService = _movieService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await movieService.GetAllCardInfoAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> MovieDetails(int movieId)
        {
            var model = await movieService.GetMovieDetailsByIdAsync(movieId);

            return View(model);
        }
    }
}
