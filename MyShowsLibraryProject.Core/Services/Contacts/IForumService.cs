using MyShowsLibraryProject.Core.Enumeration;
using MyShowsLibraryProject.Core.Models.ForumModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface IForumService
    {
        Task<TopicCardsInfoServiceModel> GetTopicById(int id);
        Task<List<TopicCardsInfoServiceModel>> GetAllTopics();
        Task<ForumQueryServiceModel> ShowAllTopics(string? searchTerm, BaseSorting sorting, int currPage, int topicsPerPage);
        Task CreateTopicAsync(TopicFormModel model);
        Task EditTopicAsync(int topicId, TopicFormModel model);
        Task DeleteAsync(int topicId);
    }
}
