﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Core.Enumeration;
using MyShowsLibraryProject.Core.Models.ForumModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;
using System.Security.Claims;

namespace MyShowsLibraryProject.Core.Services
{
    public class ForumService : IForumService
    {
        public readonly ILogger<ForumService> logger;
        public readonly IRepository repository;

        public ForumService(IRepository _repository,
           ILogger<ForumService> _logger)
        {
            repository = _repository;
            logger = _logger;
        }

        public async Task<List<TopicCardsInfoServiceModel>> GetAllTopics()
        {
            var topics = await repository.TakeAllReadOnly<Topic>()
                .Select(t => new TopicCardsInfoServiceModel()
                {
                    TopicId = t.TopicId,
                    TopicName = t.Name
                })
                .ToListAsync();

            return topics;
        }
        public async Task<List<PostsInfoServiceModel>> GetAllPosts()
        {
            var posts = await repository
                .TakeAllReadOnly<Post>()
                .Select(p => new PostsInfoServiceModel()
                {
                    PostId = p.PostId,
                    PostBody = p.PostBody,
                    CreatedOn = p.CreatedOn.ToString()
                })
                .ToListAsync();

            return posts;
        }
        public async Task<AllPostInfoServiceModel> GetAllPostsForTopic(int topicId)
        {
            var posts = await repository
              .TakeAllReadOnly<Topic>()
              .Where(t => t.TopicId == topicId)
              .Select(t => new AllPostInfoServiceModel()
              {
                  Posts = t.Posts.Select(p => new PostsInfoServiceModel()
                  {
                      PostId = p.PostId,
                      PostBody = p.PostBody,
                      CreatedOn = p.CreatedOn.ToString()
                  })
              })
              .FirstOrDefaultAsync();

            return posts;
        }
        public async Task<TopicCardsInfoServiceModel> GetTopicById(int id)
        {
            var topic = await repository
                .TakeAllReadOnly<Topic>()
                .Select(t => new TopicCardsInfoServiceModel
                {
                    TopicId = t.TopicId,
                    TopicName = t.Name
                })
                .FirstOrDefaultAsync();

            return topic;
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

            var topicsToShow = await topics
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
        public async Task CreateTopicAsync(TopicFormModel model)
        {
            var topic = repository.TakeAllReadOnly<Topic>();

            if (!topic.Any(t => t.Name == model.Name))
            {
                var newTopic = new Topic()
                {
                    Name = model.Name
                };

                await repository.AddAsync(newTopic);
                await repository.SaveChangesAsync();
                logger.LogInformation(MessagesConstants.EntityCreatedMessage, nameof(Topic), model.Name);
            }
        }
        public async Task CreatePostAsync(PostFormModel model,string userId,int topicId)
        {
            var newPost = new Post()
            {
                PostBody = model.PostBody,
                CreatedOn = DateTime.UtcNow,
                UserId = userId,
                TopicId = topicId
            };

            await repository.AddAsync(newPost);
            await repository.SaveChangesAsync();
            logger.LogInformation(MessagesConstants.EntityCreatedMessage, nameof(Post), DateTime.UtcNow.ToString());
        }
        public async Task EditTopicAsync(int topicId, TopicFormModel model)
        {
            var topicToEdit = await repository.GetByIdAsync<Topic>(topicId);

            if (topicToEdit == null)
            {
                logger.LogInformation(MessagesConstants.EntityIdNotFountMessage, nameof(Topic), topicId);
                throw new NullReferenceException(MessagesConstants.TopicDoesNotExistsMessage);
            }

            topicToEdit.Name = model.Name;

            await repository.SaveChangesAsync();
            logger.LogInformation(MessagesConstants.EntityEditedMessage, nameof(Topic), topicId);
        }
        public async Task DeleteTopicAsync(int topicId)
        {
            await repository.DeleteAsync<Topic>(topicId);
            await repository.SaveChangesAsync();
            logger.LogInformation(MessagesConstants.EntityDeleteMessage, nameof(Topic), topicId);
        }
    }
}
