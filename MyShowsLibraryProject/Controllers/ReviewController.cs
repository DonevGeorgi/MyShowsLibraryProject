using Microsoft.AspNetCore.Mvc;
using MyShowsLibraryProject.Core.Models.ReviewModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Models;
using System.Security.Claims;

namespace MyShowsLibraryProject.Controllers
{
    public class ReviewController : BaseController
    {
        private readonly IReviewService reviewService;

        public ReviewController(IReviewService _reviewService)
        {
            reviewService = _reviewService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddingReview(int showId, string showType)
        {
            var model = new ReviewFormModel();

            TempData["identitfier"] = showId;
            TempData["type"] = showType;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddingReview(ReviewFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (TempData.ContainsKey("movie")
             || TempData.ContainsKey("serie"))
            {
                return BadRequest();
            }

            int identitfier = Convert.ToInt32(TempData["identitfier"]);

            if (identitfier == 0)
            {
                return BadRequest();
            }

            string? type = Convert.ToString(TempData["type"]);

            if (type == null)
            {
                return BadRequest();
            }

            var currUser = User.GetId();

            if (currUser == null)
            {
                return Unauthorized();
            }

            int showId = await reviewService.CreateAsync(model, currUser, identitfier, type);


            if (type == "movie")
            {
                return RedirectToAction("MovieDetails", "Movie", new { movieId = showId });
            }

            return RedirectToAction("SerieDetails", "Serie", new { serieId = showId });
        }
    }
}
