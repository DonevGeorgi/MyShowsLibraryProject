using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.QuickInfo;
using MyShowsLibraryProject.Core.Models.MovieModels;
using MyShowsLibraryProject.Core.Services.Contacts;

namespace MyShowsLibraryProject.Controllers
{
    public class MovieController : BaseController
    {
        private readonly IMovieService movieService;

        public MovieController(IMovieService _movieService)
        {
            movieService = _movieService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Index([FromQuery]MoviesQueryModel query)
        {
            var model = await movieService.GetAllCardInfoAsync(query.SearchTerm,query.Sorting,query.CurrentPage,query.MoviePerPage);

            query.TotalMoviesCount = model.TotalMovieCount;
            query.Movies = model.Movies;

            return View(query);
        }
        [HttpGet]
        public async Task<IActionResult> MovieDetails(int movieId)
        {
            var model = await movieService.GetMovieDetailsByIdAsync(movieId);

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }
    }
}
