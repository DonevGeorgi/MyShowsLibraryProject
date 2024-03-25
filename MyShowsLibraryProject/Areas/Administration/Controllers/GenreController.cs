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
    }
}
