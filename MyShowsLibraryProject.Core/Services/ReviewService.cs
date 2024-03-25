﻿using MyShowsLibraryProject.Core.Models.ReviewModels;
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
            ISerieService serieRepository)
        {
            repository = _repository;
            movieRepository = _movieRepository;
            this.serieRepository = serieRepository;
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

            //maybe check if same review from same user exist becouse of spam


            if (showType == "movie" && await movieRepository.IsMoviePresent(showId))
            {
                var newMovieReview = new MovieReview()
                {
                    MovieId = showId,
                    ReviewId = newReview.ReviewId
                };

                await repository.AddAsync(newMovieReview);
            }
            else
            {
                //error
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
            else
            {
                //error
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
    }
}