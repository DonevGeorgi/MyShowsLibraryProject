using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Enumeration;
using MyShowsLibraryProject.Core.Models.ForumModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class ForumService : IForumService
    {
        public readonly IRepository repository;

        public ForumService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<ForumQueryServiceModel> ShowAllTopics(string? searchTerm = null,
            BaseSorting sorting = BaseSorting.FromA,
            int currPage = 1,
            int topicsPerPage = 4)
        {
            var topics = repository.TakeAllReadOnly<Topic>();

            if (searchTerm != null)
            {
                string normalizeSearchTerm = searchTerm.ToLower();
                topics = topics
                    .Where(t => t.Name.ToLower().Contains(normalizeSearchTerm));
            }

            topics = sorting switch
            {
                BaseSorting.FromA => topics.OrderBy(t => t.Name),
                BaseSorting.ToA => topics.OrderByDescending(t => t.Name),
                _ => topics
            };

            var topicsToShow = await repository
                .TakeAllReadOnly<Topic>()
                .Skip((currPage - 1) * topicsPerPage)
                .Take(topicsPerPage)
                .Select(t => new TopicCardsInfoServiceModel
                {
                    TopicId = t.TopicId,
                    TopicName = t.Name
                })
                .ToListAsync();

            int totalTicsCount = await topics.CountAsync();

            return new ForumQueryServiceModel()
            {
                Topics = topicsToShow,
                TotalTopicCount = totalTicsCount
            };
        }
    }
}
