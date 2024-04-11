using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Models.ReviewModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IRepository repository;
        private readonly IMovieService movieRepository;
        private readonly ISerieService serieRepository;

        public ReviewService(IRepository _repository,
            IMovieService _movieRepository,
            ISerieService _serieRepository)
        {
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

            if (reviews == null)
            {
                throw new NullReferenceException("Review does not exists!");
            }

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

            if (showType == "movie" && await movieRepository.IsMoviePresent(showId))
            {
                var newMovieReview = new MovieReview()
                {
                    MovieId = showId,
                    ReviewId = newReview.ReviewId
                };

                await repository.AddAsync(newMovieReview);
            }
            else if (showType == "movie" && !await movieRepository.IsMoviePresent(showId))
            {
                throw new ArgumentNullException("The show you chose does not exists!");
            }

            if (showType == "serie" && await serieRepository.IsSeriePresent(showId))
            {
                var newSerieReview = new SerieReview()
                {
                    SerieId = showId,
                    ReviewId = newReview.ReviewId
                };

                await repository.AddAsync(newSerieReview);
            }
            else if (showType == "serie" && !await serieRepository.IsSeriePresent(showId))
            {
                throw new ArgumentNullException("The show you chose does not exists!");
            }

            var newUserReview = new UserReview()
            {
                UserId = userId,
                ReviewId = newReview.ReviewId
            };

            await repository.AddAsync(newUserReview);
            await repository.SaveChangesAsync();

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
                throw new NullReferenceException("Review you want to edit does not exists!");
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
                ReviewId = reviewId
            };

            repository.Remove<UserReview>(modelToRemove);
            await repository.DeleteAsync<Review>(reviewId);
            await repository.SaveChangesAsync();
        }
    }
}
