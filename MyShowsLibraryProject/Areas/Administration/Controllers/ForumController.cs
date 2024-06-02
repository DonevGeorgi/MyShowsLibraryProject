using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

            await forumService.CreateTopicAsync(model);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> EditTopic(int topicId)
        {
            var topic = await forumService.GetTopicById(topicId);

            if (topic == null)
            {
                return NotFound();
            }

            TempData["identifier"] = topicId;

            var result = new TopicFormModel()
            {
                Name = topic.TopicName
            };

            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> EditTopic(TopicFormModel newTopic)
        {
            if (!ModelState.IsValid)
            {
                return View(newTopic);
            }

            var topicId = Convert.ToInt32(TempData["identifier"]);

            if (topicId == 0)
            {
                return BadRequest();
            }

            await forumService.EditTopicAsync(topicId, newTopic);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> DeleteTopic(int topicId)
        {
            var topic = await forumService.GetTopicById(topicId);

            if (topic == null)
            {
                return NotFound();
            }

            await forumService.DeleteTopicAsync(topicId);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> PostsIndex()
        {
            var posts = await forumService.GetAllPosts();

            return View(posts);
        }

    }
}
