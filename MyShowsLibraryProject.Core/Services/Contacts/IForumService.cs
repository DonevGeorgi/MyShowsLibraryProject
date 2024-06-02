using MyShowsLibraryProject.Core.Enumeration;
using MyShowsLibraryProject.Core.Models.ForumModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface IForumService
    {
        Task<List<TopicCardsInfoServiceModel>> GetAllTopics();
        Task<List<PostsInfoServiceModel>> GetAllPosts();
        Task<AllPostInfoServiceModel> GetAllPostsForTopic(int topicId);
        Task<TopicCardsInfoServiceModel> GetTopicById(int id);
        Task<PostsInfoServiceModel> GetPostById(int id);
        Task<ForumQueryServiceModel> ShowAllTopics(string? searchTerm, BaseSorting sorting, int currPage, int topicsPerPage);
        Task CreateTopicAsync(TopicFormModel model);
        Task CreatePostAsync(PostFormModel model, string userId,int topicId);
        Task EditTopicAsync(int topicId, TopicFormModel model);
        Task EditPostAsync(int postId, PostFormModel model);
        Task DeleteTopicAsync(int topicId);
        Task DeletePostAsync(int postId);
    }
}
