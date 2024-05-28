using Microsoft.AspNetCore.Mvc;
using MyShowsLibraryProject.Core.Models.ForumModels;
using MyShowsLibraryProject.Core.Models.MovieModels;
using MyShowsLibraryProject.Core.Services;
using MyShowsLibraryProject.Core.Services.Contacts;

namespace MyShowsLibraryProject.Areas.Administration.Controllers
{
    public class ForumController : AdministrationController
    {
        private readonly IForumService forumService;

        public ForumController(IForumService _forumService)
        {
            forumService = _forumService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var topics = await forumService.GetAllTopics();

            return View(topics);
        }
        [HttpGet]
        public IActionResult AddTopic()
        {
            var result = new TopicFormModel();

            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> AddTopic(TopicFormModel model)
        {
            if (!ModelState.IsValid)
            {
                var entity = new TopicFormModel();

                return View(entity);
            }

            await forumService.CreateTopic(model);

            return RedirectToAction(nameof(Index));
        }
    }
}
