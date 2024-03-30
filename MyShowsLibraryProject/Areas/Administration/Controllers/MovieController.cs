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
        public IActionResult Add()
        {
            var entity = new MovieFormModel();

            return View(entity);
        }
        [HttpPost]
        public async Task<IActionResult> Add(MovieFormModel model)
        {
            if (!ModelState.IsValid)
            {
                var entity = new MovieFormModel();

                return View(entity);
            }

            var newMovie = await movieService.CreateAsync(model);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int movieId)
        {
            var movie = await movieService.GetMovieDetailsByIdAsync(movieId);

            TempData["identifier"] = movieId;

            var model = new MovieFormModel()
            {
                Title = movie.Title,
                Duration = movie.Duration,
                PosterUrl = movie.PosterUrl,
                TrailerUrl = movie.TrailerUrl,
                DateOfRelease = movie.DateOfRelease,
                Summary = movie.Summary,
                OriginalAudioLanguage = movie.OriginalAudioLanguage,
                ForMoreSummaryUrl = movie.ForMoreSummaryUrl
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(MovieFormModel newMovie)
        {
            if (!ModelState.IsValid)
            {
                return View(newMovie);
            }

            var movieId = Convert.ToInt32(TempData["identifier"]);

            if (movieId == 0)
            {
                return BadRequest();
            }

            await movieService.EditAsync(movieId,newMovie);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int movieId)
        {
            var movie = await movieService.GetMovieDetailsByIdAsync(movieId);

            if (movie == null)
            {
                return BadRequest();
            }

            await movieService.DeleteAsync(movieId);

            return RedirectToAction(nameof(Index));
        }
    }
}
