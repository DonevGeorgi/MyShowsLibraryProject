using Microsoft.AspNetCore.Mvc;
using MyShowsLibraryProject.Core.Models.GenreModels;
using MyShowsLibraryProject.Core.Services.Contacts;

namespace MyShowsLibraryProject.Areas.Administration.Controllers
{
    public class GenreController : AdministrationController
    {
        private readonly IGenreService genreService;

        public GenreController(IGenreService _genreService)
        {
            genreService = _genreService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var genres = await genreService.GetAllReadonlyAsync();

            return View(genres);
        }
        [HttpGet]
        public IActionResult Add()
        {
            var entity = new GenreFormModel();

            return View(entity);
        }
        [HttpPost]
        public async Task<IActionResult> Add(GenreFormModel model)
        {
            if(!ModelState.IsValid)
            {
                var entity = new GenreFormModel();

                return View(entity);
            }

            await genreService.CreateAsync(model);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Edit(string genreName)
        {
            var genreId = await genreService.GetGenreIdFromName(genreName);
            var genre = await genreService.GetGenreById(genreId);

            TempData["identifier"] = genreId;

            var model = new GenreFormModel()
            {
                Name = genre.Name
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(GenreFormModel newGenre)
        {
            if (!ModelState.IsValid)
            {
                return View(newGenre);
            }

            var genreId = Convert.ToInt32(TempData["identifier"]);

            if (genreId == 0)
            {
                return BadRequest();
            }

            await genreService.EditAsync(genreId, newGenre);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Delete(string genreName)
        {
            var genreId = await genreService.GetGenreIdFromName(genreName);
            var genre = await genreService.GetGenreById(genreId);

            if (genre == null)
            {
                return BadRequest();
            }

            await genreService.DeleteAsync(genreId);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> AddGenreToMovie(int movieId)
        {
            var model = new GenreChoseFromModel()
            {
                GenresName = await genreService.GetAllReadonlyAsync()
            };

            if (model.GenresName.Any() == false)
            {
                return NotFound();
            }

            TempData["movieIdentifier"] = movieId;

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddGenreToMovie(GenreChoseFromModel genre)
        {
            var movieId = Convert.ToInt32(TempData["movieIdentifier"]);

            if (genre.Name == string.Empty)
            {
                return BadRequest();
            }

            await genreService.AddGenreToMovieAsync(movieId, genre.Name);

            return RedirectToAction("Index", "Movie");
        }
        [HttpGet]
        public async Task<IActionResult> RemoveGenreFromMovie(int movieId)
        {
            var model = new GenreChoseFromModel()
            {
                GenresName = await genreService.GetAllReadonlyAsync()
            };

            if (model.GenresName.Any() == false)
            {
                return NotFound();
            }

            TempData["movieIdentifier"] = movieId;

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> RemoveGenreFromMovie(GenreChoseFromModel genre)
        {
            var movieId = Convert.ToInt32(TempData["movieIdentifier"]);

            if (genre.Name == string.Empty)
            {
                return BadRequest();
            }

            await genreService.RemoveGenreFromMovie(movieId,genre.Name);

            return RedirectToAction("Index", "Movie");
        }
    }
}
