using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyShowsLibraryProject.Core.Models.SerieModels;
using MyShowsLibraryProject.Core.Services;
using MyShowsLibraryProject.Core.Services.Contacts;

namespace MyShowsLibraryProject.Controllers
{
    public class SerieController : BaseController
    {
        private readonly ISerieService serieService;

        public SerieController(ISerieService _serieService)
        {
            serieService = _serieService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Index([FromQuery] SerieQueryModel query)
        {
            var serie = await serieService.GetAllCardInfoAsync(query.SearchTerm, query.Sorting, query.CurrentPage, query.SeriePerPage);

            query.TotalSeriesCount = serie.TotalSerieCount;
            query.Serie = serie.Serie;

            return View(query);
        }

        [HttpGet]
        public async Task<IActionResult> SerieDetails(int serieId)
        {
            var model = await serieService.GetSerieDetailsByIdAsync(serieId);

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }
    }
}
