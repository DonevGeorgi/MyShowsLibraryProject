using MyShowsLibraryProject.Core.Enumeration;
using MyShowsLibraryProject.Core.Models.ForumModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface IForumService
    {
        Task<ForumQueryServiceModel> ShowAllTopics(string? searchTerm, BaseSorting sorting, int currPage, int topicsPerPage);
    }
}
