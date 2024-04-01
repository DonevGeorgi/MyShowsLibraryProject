using Microsoft.AspNetCore.Mvc;
using MyShowsLibraryProject.Core.Models.GenreModels;
using MyShowsLibraryProject.Core.Services.Contacts;

namespace MyShowsLibraryProject.Areas.Administration.Controllers
{
    public class MovieGenreController : AdministrationController
    {
        private readonly IMovieGenreService movieGenreService;

        public MovieGenreController(IMovieGenreService _movieGenreService)
        {
            movieGenreService = _movieGenreService;
        }

        [HttpGet]
        public async Task<IActionResult> AddGenreToMovie(int movieId)
        {
            var model = new GenreChoseFormModel()
            {
                GenresName = await movieGenreService.TakeAllGenres()
            };

            if (model.GenresName.Any() == false)
            {
                return NotFound();
            }

            TempData["movieIdentifier"] = movieId;

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddGenreToMovie(GenreChoseFormModel genre)
        {
            var movieId = Convert.ToInt32(TempData["movieIdentifier"]);

            await movieGenreService.AddGenreToMovieAsync(movieId, genre.GenreId);

            return RedirectToAction("Index", "Movie");
        }
        [HttpGet]
        public async Task<IActionResult> RemoveGenreFromMovie(int movieId)
        {
            var model = new GenreChoseFormModel()
            {
                GenresName = await movieGenreService.TakeAllGenres()
            };

            if (model.GenresName.Any() == false)
            {
                return NotFound();
            }

            TempData["movieIdentifier"] = movieId;

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> RemoveGenreFromMovie(GenreChoseFormModel genre)
        {
            var movieId = Convert.ToInt32(TempData["movieIdentifier"]);

            await movieGenreService.RemoveGenreFromMovieAsync(movieId, genre.GenreId);

            return RedirectToAction("Index", "Movie");
        }
    }
}
