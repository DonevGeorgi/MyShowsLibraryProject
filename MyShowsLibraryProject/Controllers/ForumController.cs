using Microsoft.AspNetCore.Mvc;
using MyShowsLibraryProject.Core.Models.ForumModels;
using MyShowsLibraryProject.Core.Models.MovieModels;
using MyShowsLibraryProject.Core.Services.Contacts;

namespace MyShowsLibraryProject.Controllers
{
    public class ForumController : BaseController
    {
        public readonly IForumService forumService;

        public ForumController(IForumService _forumService)
        {
            forumService = _forumService;
        }

        public async Task<IActionResult?> Index([FromQuery] ForumQueryModel query)
        {
            var model = await forumService.ShowAllTopics(query.SearchTerm, query.Sorting, query.CurrentPage, query.ItemsPerPage);
            query.TotalItemsCount = model.TotalTopicCount;
            query.Topics = model.Topics;

            return View(query);
        }
    }
}
