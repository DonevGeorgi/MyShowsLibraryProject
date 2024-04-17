using Microsoft.AspNetCore.Mvc;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Models;
using System.Security.Claims;

namespace MyShowsLibraryProject.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserService userService;

        public UserController(IUserService _userService)
        {
            userService = _userService;
        }

        [HttpGet]
        public async Task<IActionResult> MoviePart()
        {
            var currUser = User.GetId();

            if (currUser == null)
            {
                return Unauthorized();
            }

            var model = await userService.GetAllMovieForWatchLaterAsync(currUser);

            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> SeriePart()
        {
            var currUser = User.GetId();

            if (currUser == null)
            {
                return Unauthorized();
            }

            var model = await userService.GetAllSerieForWatchLaterAsync(currUser);

            return View(model);
        }
        [HttpGet]        
        public async Task<IActionResult> AddMovie(int movieId)
        {
            var userId = User.GetId();

            if (userId == null)
            {
                return Unauthorized();
            }

            await userService.AddMovieToWatchLater(movieId,userId);

            return RedirectToAction("MovieDetails", "Movie", new { movieId });
        }
        [HttpGet]
        public async Task<IActionResult> RemoveMovie(int movieId)
        {
            var userId = User.GetId();

            if (userId == null)
            {
                return Unauthorized();
            }

            await userService.RemoveMovieToWatchLater(movieId, userId);

            return RedirectToAction("MovieDetails", "Movie", new { movieId });
        }
        [HttpGet]
        public async Task<IActionResult> AddSerie(int serieId)
        {
            var userId = User.GetId();

            if (userId == null)
            {
                return Unauthorized();
            }

            await userService.AddSerieToWatchLater(serieId, userId);

            return RedirectToAction("SerieDetails", "Serie", new { serieId });
        }
        [HttpGet]
        public async Task<IActionResult> RemoveSerie(int serieId)
        {
            var userId = User.GetId();

            if (userId == null)
            {
                return Unauthorized();
            }

            await userService.RemoveSerieToWatchLater(serieId, userId);

            return RedirectToAction("SerieDetails", "Serie", new { serieId });
        }
    }
}
