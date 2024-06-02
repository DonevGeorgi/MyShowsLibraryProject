using MyShowsLibraryProject.Core.Enumeration;
using MyShowsLibraryProject.Core.Models.ForumModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface IForumService
    {
        Task<List<TopicCardsInfoServiceModel>> GetAllTopics();
        Task<List<PostsInfoServiceModel>> GetAllPosts();
        Task<List<AllPostInfoServiceModel>> GetAllPostsForTopic(int topicId);
        Task<TopicCardsInfoServiceModel> GetTopicById(int id);
        Task<ForumQueryServiceModel> ShowAllTopics(string? searchTerm, BaseSorting sorting, int currPage, int topicsPerPage);
        Task CreateTopicAsync(TopicFormModel model);
        Task CreatePostAsync(PostFormModel model);
        Task EditTopicAsync(int topicId, TopicFormModel model);
        Task DeleteTopicAsync(int topicId);
    }
}
