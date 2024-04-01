using Microsoft.AspNetCore.Mvc;
using MyShowsLibraryProject.Core.Models.GenreModels;
using MyShowsLibraryProject.Core.Services.Contacts;

namespace MyShowsLibraryProject.Areas.Administration.Controllers
{
    public class SerieGenreController : AdministrationController
    {
        private readonly ISerieGenreService serieGenreService;

        public SerieGenreController(ISerieGenreService _serieGenreService)
        {
            serieGenreService = _serieGenreService;
        }

        [HttpGet]
        public async Task<IActionResult> AddGenreToSerie(int serieId)
        {
            var model = new GenreChoseFormModel()
            {
                GenresName = await serieGenreService.TakeAllGenres()
            };

            if (model.GenresName.Any() == false)
            {
                return NotFound();
            }

            TempData["serieIdentifier"] = serieId;

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddGenreToSerie(GenreChoseFormModel genre)
        {
            var serieId = Convert.ToInt32(TempData["serieIdentifier"]);

            await serieGenreService.AddGenreToSerieAsync(serieId, genre.GenreId);

            return RedirectToAction("Index", "Serie");
        }
        [HttpGet]
        public async Task<IActionResult> RemoveGenreFromSerie(int serieId)
        {
            var model = new GenreChoseFormModel()
            {
                GenresName = await serieGenreService.TakeAllGenres()
            };

            if (model.GenresName.Any() == false)
            {
                return NotFound();
            }

            TempData["serieIdentifier"] = serieId;

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> RemoveGenreFromSerie(GenreChoseFormModel genre)
        {
            var serieId = Convert.ToInt32(TempData["serieIdentifier"]);

            await serieGenreService.RemoveGenreFromSerieAsync(serieId, genre.GenreId);

            return RedirectToAction("Index", "Serie");
        }
    }
}
