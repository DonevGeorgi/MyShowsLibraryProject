using Microsoft.AspNetCore.Mvc;
using MyShowsLibraryProject.Core.Models.MovieModels;
using MyShowsLibraryProject.Core.Models.SerieModels;
using MyShowsLibraryProject.Core.Services;
using MyShowsLibraryProject.Core.Services.Contacts;

namespace MyShowsLibraryProject.Areas.Administration.Controllers
{
    public class SerieController : AdministrationController
    {
        private readonly ISerieService serieServices;

        public SerieController(ISerieService _serieServices)
        {
            serieServices = _serieServices;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var series = await serieServices.GetAllReadonlyAsync();

            return View(series);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var entity = new SerieFormModel();

            return View(entity);
        }

        [HttpPost]
        public async Task<IActionResult> Add(SerieFormModel model)
        {
            if (!ModelState.IsValid)
            {
                var entity = new SerieFormModel();

                return View(entity);
            }

            var newSerie = await serieServices.CreateAsync(model);

            return RedirectToAction(nameof(Index));
        }
    }
}
