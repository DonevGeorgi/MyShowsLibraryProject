using Microsoft.AspNetCore.Mvc;
using MyShowsLibraryProject.Core.Models.SerieModels;
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

        [HttpGet]
        public async Task<IActionResult> Edit(int serieId)
        {
            var serie = await serieServices.GetSerieDetailsByIdAsync(serieId);

            TempData["identifier"] = serieId;

            var model = new SerieFormModel()
            {
                Title = serie.Title,
                PosterUrl = serie.PosterUrl,
                TrailerUrl = serie.TrailerUrl,
                YearOfStart = serie.YearOfStart,
                YearOfEnd = serie.YearOfEnd,
                Summary = serie.Summary,
                OriginalAudioLanguage = serie.OriginalAudioLanguage,
                ForMoreSummaryUrl = serie.ForMoreSummaryUrl,
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(SerieFormModel newSerie)
        {
            if (!ModelState.IsValid)
            {
                return View(newSerie);
            }

            var serieId = Convert.ToInt32(TempData["identifier"]);

            if (serieId == 0)
            {
                return BadRequest();
            }

            await serieServices.EditAsync(serieId, newSerie);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int serieId)
        {
            var serie = await serieServices.GetSerieDetailsByIdAsync(serieId);

            if (serie == null)
            {
                return BadRequest();
            }

            await serieServices.DeleteAsync(serie.SerieId);

            return RedirectToAction(nameof(Index));
        }
    }
}
