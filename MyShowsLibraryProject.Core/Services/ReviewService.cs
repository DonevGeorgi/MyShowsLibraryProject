using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Core.Models.ReviewModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class ReviewService : IReviewService
    {
        private readonly ILogger<ReviewService> logger;
        private readonly IRepository repository;
        private readonly IMovieService movieRepository;
        private readonly ISerieService serieRepository;

        public ReviewService(ILogger<ReviewService> _logger,
            IRepository _repository,
            IMovieService _movieRepository,
            ISerieService _serieRepository)
        {
            logger = _logger;
            repository = _repository;
            movieRepository = _movieRepository;
            serieRepository = _serieRepository;
        }

        public async Task<ReviewInfoServiceModel> GetReviewById(int reviewId)
        {
            var reviews = await repository
                .TakeAllReadOnly<Review>()
                .Where(r => r.ReviewId == reviewId)
                .Select(r => new ReviewInfoServiceModel
                {
                    ReviewId = r.ReviewId,
                    Rating = r.Rating,
                    Content = r.Content
                })
                .FirstOrDefaultAsync();

            return reviews;
        }
        public async Task<int> CreateAsync(ReviewFormModel model, string userId,int showId,string showType)
        {
            var newReview = new Review()
            {
                Rating = model.Rating,
                Content = model.Content
            };

            await repository.AddAsync(newReview);
            await repository.SaveChangesAsync();
            logger.LogInformation(MessagesConstants.EntityCreatedSuccesfullyMessage, nameof(Review));

            if (showType == "movie" && await movieRepository.IsMoviePresent(showId))
            {
                var newMovieReview = new MovieReview()
                {
                    MovieId = showId,
                    ReviewId = newReview.ReviewId
                };

                await repository.AddAsync(newMovieReview);
                logger.LogInformation(MessagesConstants.EntityCreatedMessage, nameof(MovieReview), showId);
            }
            else if (showType == "movie" && !await movieRepository.IsMoviePresent(showId))
            {
                logger.LogInformation(MessagesConstants.EntityIdNotFountMessage,nameof(Movie),showId);
                throw new NullReferenceException(MessagesConstants.ShowDoesNotExsistsMessage);
            }

            if (showType == "serie" && await serieRepository.IsSeriePresent(showId))
            {
                var newSerieReview = new SerieReview()
                {
                    SerieId = showId,
                    ReviewId = newReview.ReviewId
                };

                await repository.AddAsync(newSerieReview);
                logger.LogInformation(MessagesConstants.EntityCreatedMessage, nameof(SerieReview), showId);
            }
            else if (showType == "serie" && !await serieRepository.IsSeriePresent(showId))
            {
                logger.LogInformation(MessagesConstants.EntityIdNotFountMessage, nameof(Serie), showId);
                throw new NullReferenceException(MessagesConstants.ShowDoesNotExsistsMessage);
            }

            var newUserReview = new UserReview()
            {
                UserId = userId,
                ReviewIdentifier = newReview.ReviewId
            };

            await repository.AddAsync(newUserReview);
            await repository.SaveChangesAsync();
            logger.LogInformation(MessagesConstants.EntityCreatedSuccesfullyMessage,nameof(UserReview));

            if (showType == "movie")
            {
                return showId;
            }

            return showId;
        }
        public async Task EditAsync(int reviewId, ReviewFormModel review)
        {
            var reviewToEdit = await repository.GetByIdAsync<Review>(reviewId);

            if (reviewToEdit == null)
            {
                logger.LogInformation(MessagesConstants.EntityIdNotFountMessage, nameof(Movie),reviewId);
                throw new NullReferenceException(MessagesConstants.ReviewDoesNotExistsMessage);
            }

            reviewToEdit.Rating = review.Rating;
            reviewToEdit.Content = review.Content;

            await repository.SaveChangesAsync();
        }
        public async Task DeleteAsync(int reviewId, string userId)
        {
            var modelToRemove = new UserReview()
            {
                UserId = userId,
                ReviewIdentifier = reviewId
            };

            repository.Remove<UserReview>(modelToRemove);
            await repository.DeleteAsync<Review>(reviewId);
            await repository.SaveChangesAsync();
        }
    }
}
