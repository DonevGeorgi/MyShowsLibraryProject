using MyShowsLibraryProject.Core.Enumeration;
using MyShowsLibraryProject.Core.Models.ForumModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface IForumService
    {
        Task<List<TopicCardsInfoServiceModel>> GetAllTopics();
        Task<ForumQueryServiceModel> ShowAllTopics(string? searchTerm, BaseSorting sorting, int currPage, int topicsPerPage);
        Task CreateTopic(TopicFormModel model);
    }
}
