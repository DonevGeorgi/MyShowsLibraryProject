using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> Index()
        {
            var model = await serieService.GetAllReadonlyAsync();

            return View(model);
        }
    }
}
