using Microsoft.AspNetCore.Mvc;
using MyShowsLibraryProject.Core.Models.CrewModels;
using MyShowsLibraryProject.Core.Services.Contacts;

namespace MyShowsLibraryProject.Areas.Administration.Controllers
{
    public class CrewMovieController :  AdministrationController
    {
        private readonly ICrewMovieService crewMovieService;

        public CrewMovieController(ICrewMovieService _crewMovieService)
        {
            crewMovieService = _crewMovieService;
        }

        [HttpGet]
        public IActionResult AddCrewToMovie(int movieId)
        {
            var model = new CrewNameFromModel()
            {

            };

            TempData["movieIdentifier"] = movieId;

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddCrewToMovie(CrewNameFromModel newCrew)
        {
            if (!ModelState.IsValid)
            {
                var model = new CrewNameFromModel()
                {

                };

                return View();
            }

            var movieId = Convert.ToInt32(TempData["movieIdentifier"]);

            await crewMovieService.AddCrewToMovie(movieId, newCrew.CrewName);

            return RedirectToAction("Index", "Movie");
        }
        [HttpGet]
        public IActionResult RemoveCrewFromMovie(int movieId)
        {
            var model = new CrewNameFromModel()
            {

            };

            TempData["movieIdentifier"] = movieId;

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> RemoveCrewFromMovie(CrewNameFromModel newCrew)
        {
            if (!ModelState.IsValid)
            {
                var model = new CrewNameFromModel()
                {

                };

                return View();
            }

            var movieId = Convert.ToInt32(TempData["movieIdentifier"]);

            await crewMovieService.RemoveCrewFromMovie(movieId, newCrew.CrewName);

            return RedirectToAction("Index", "Movie");
        }
    }
}
