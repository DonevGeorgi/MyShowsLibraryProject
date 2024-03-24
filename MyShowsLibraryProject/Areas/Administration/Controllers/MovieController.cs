using Microsoft.AspNetCore.Mvc;
using MyShowsLibraryProject.Core.Models.MovieModels;
using MyShowsLibraryProject.Core.Services.Contacts;

namespace MyShowsLibraryProject.Areas.Administration.Controllers
{
    public class MovieController : AdministrationController
    {
        private readonly IMovieService movieService;

        public MovieController(IMovieService _movieService)
        {
            movieService = _movieService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var movies = await movieService.GetAllReadonlyAsync();

            return View(movies);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var entity = new MovieFormModel()
            {

            };

            return View(entity);
        }


        [HttpPost]
        public async Task<IActionResult> Add(MovieFormModel model)
        {
            if (!ModelState.IsValid)
            {
                var entity = new MovieFormModel()
                {

                };

                return View(entity);
            }

            var newMovie = await movieService.CreateAsync(model);

            return RedirectToAction(nameof(Index));
        }
    }
}
