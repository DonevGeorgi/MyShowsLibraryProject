using Microsoft.AspNetCore.Mvc;
using MyShowsLibraryProject.Core.Models.ForumModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Models;
using System.Security.Claims;

namespace MyShowsLibraryProject.Controllers
{
    public class ForumController : BaseController
    {
        public readonly IForumService forumService;

        public ForumController(IForumService _forumService)
        {
            forumService = _forumService;
        }

        [HttpGet]
        public async Task<IActionResult?> Index([FromQuery] ForumQueryModel query)
        {
            var model = await forumService.ShowAllTopics(query.SearchTerm, query.Sorting, query.CurrentPage, query.ItemsPerPage);
            query.TotalItemsCount = model.TotalTopicCount;
            query.Topics = model.Topics;

            return View(query);
        }
        [HttpGet]
        public async Task<IActionResult> AllTopicPosts(int topicId)
        {
            var posts = await forumService.GetAllPostsForTopic(topicId);

            TempData["identitfier"] = topicId;

            return View(posts);
        }
        [HttpGet]
        public IActionResult AddPostToTopic()
        {
            var result = new PostFormModel();

            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> AddPostToTopic(PostFormModel model)
        {
            if (!ModelState.IsValid)
            {
                var result = new PostFormModel();

                return View(result);
            }

            var userId = User.GetId();

            if (userId == null)
            {
                return Unauthorized();
            }

            var topicId = Convert.ToInt32(TempData["identitfier"]);

            if (topicId == 0)
            {
                return BadRequest();
            }

            await forumService.CreatePostAsync(model, userId, topicId);

            return RedirectToAction(nameof(AllTopicPosts), new { topicId });
        }
        [HttpGet]
        public async Task<IActionResult> EditPost(int postId)
        {
            var post = await forumService.GetPostById(postId);

            var model = new PostFormModel()
            {
                PostBody = post.PostBody
            };

            TempData["postIdentifier"] = postId;

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditPost(PostFormModel newModel)
        {
            if (!ModelState.IsValid)
            {
                return View(newModel);
            }

            var postId = Convert.ToInt32(TempData["postIdentifier"]);

            if(postId == 0)
            {
                NotFound();
            }

            var topicId = Convert.ToInt32(TempData["identitfier"]);

            if (topicId == 0)
            {
                NotFound();
            }

            await forumService.EditPostAsync(postId, newModel);

             return RedirectToAction(nameof(AllTopicPosts), new { topicId });
        }
        [HttpGet]
        public async Task<IActionResult> DeletePost(int postId)
        {

            var topicId = Convert.ToInt32(TempData["identitfier"]);

            if (topicId == 0)
            {
                NotFound();
            }

            await forumService.DeletePostAsync(postId);

            return RedirectToAction(nameof(AllTopicPosts), new { topicId });
        }
        [HttpGet]
        public IActionResult AddReply(int postId)
        {
            var result = new ReplyFormModel();

            TempData["postIdentifier"] = postId;

            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> AddReply(ReplyFormModel model)
        {
            if (!ModelState.IsValid)
            {
                var result = new ReplyFormModel();

                return View(result);
            }

            var postId = Convert.ToInt32(TempData["postIdentifier"]);

            if (postId == 0)
            {
                return BadRequest();
            }

            var userId = User.GetId();

            if (userId == null)
            {
                return Unauthorized();
            }

            var topicId = Convert.ToInt32(TempData["identitfier"]);

            if (topicId == 0)
            {
                return BadRequest();
            }

            await forumService.CreateReplyAsync(model, userId, postId);

            return RedirectToAction(nameof(AllTopicPosts), new { topicId });
        }
    }
}
