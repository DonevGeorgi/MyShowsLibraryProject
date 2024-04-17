using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Core.Models.MovieModels;
using MyShowsLibraryProject.Core.Models.SerieModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class UserService : IUserService
    {
        private readonly ILogger<UserService> logger;
        private readonly IRepository repository;

        public UserService(ILogger<UserService> _logger,
            IRepository _repository)
        {
            this.logger = _logger;
            repository = _repository;
        }

        public async Task<IEnumerable<MoviesCardInfoServiceModel>> GetAllMovieForWatchLaterAsync(string userId)
        {
            var movies = await repository
                .TakeAllReadOnly<UserMovie>()
                .Where(um => um.UserId == userId)
                .Select(m => new MoviesCardInfoServiceModel()
                {
                    MovieId = m.Movie.MovieId,
                    Title = m.Movie.Title,
                    PosterUrl = m.Movie.PosterUrl,
                    YearOfRelease = m.Movie.DateOfRelease,
                    Rating = Math.Round(((double)repository
                        .TakeAll<MovieReview>()
                        .Where(r => r.MovieId == m.Movie.MovieId)
                        .Average(mr => mr.Review.Rating)), 2)
                        .ToString()
                })
                .ToListAsync();

            return movies;
        }
        public async Task<IEnumerable<SeriesCardInfoServiceModel>> GetAllSerieForWatchLaterAsync(string userId)
        {
            var series = await repository
                .TakeAllReadOnly<UserSerie>()
                .Where(um => um.UserId == userId)
                .Select(s => new SeriesCardInfoServiceModel()
                {
                    SerieId = s.Serie.SeriesId,
                    Title = s.Serie.Title,
                    PosterUrl = s.Serie.PosterUrl,
                    StartYear = s.Serie.YearOfStart,
                    EndYear = s.Serie.YearOfEnd,
                    Rating = Math.Round(((double)repository
                        .TakeAll<SerieReview>()
                        .Where(r => r.SerieId == s.Serie.SeriesId)
                        .Average(mr => mr.Review.Rating)), 2)
                        .ToString()
                })
                .ToListAsync();

            return series;
        }
        public async Task AddMovieToWatchLater(int movieId, string userId)
        {
            var movie = await repository.GetByIdAsync<Movie>(movieId);

            if (movie == null)
            {
                logger.LogInformation(MessagesConstants.EntityIdNotFountMessage, nameof(Movie), movieId);
                throw new NullReferenceException(MessagesConstants.MovieDoesNotExistsMessage);
            }

            var newMovieForWatchLater = new UserMovie()
            {
                UserId = userId,
                MovieId = movie.MovieId,
            };

            await repository.AddAsync(newMovieForWatchLater);
            await repository.SaveChangesAsync();
            logger.LogInformation(MessagesConstants.EntityCreatedSuccesfullyMessage, nameof(UserMovie));
        }
        public async Task AddSerieToWatchLater(int serieId, string userId)
        {
            var serie = await repository.GetByIdAsync<Serie>(serieId);

            if (serie == null)
            {
                logger.LogInformation(MessagesConstants.EntityIdNotFountMessage, nameof(Serie), serieId);
                throw new NullReferenceException(MessagesConstants.SerieDoesNotExistsMessage);
            }

            var newSerieForWatchLater = new UserSerie()
            {
                UserId = userId,
                SerieId = serie.SeriesId,
            };

            await repository.AddAsync(newSerieForWatchLater);
            await repository.SaveChangesAsync();
            logger.LogInformation(MessagesConstants.EntityCreatedSuccesfullyMessage, nameof(UserSerie));
        }
        public async Task RemoveMovieToWatchLater(int movieId, string userId)
        {
            var removeFromWatchLater = new UserMovie()
            {
                UserId = userId,
                MovieId = movieId
            };

            repository.Remove<UserMovie>(removeFromWatchLater);
            await repository.SaveChangesAsync();
            logger.LogInformation(MessagesConstants.EntityDeleteSuccesfullyMessage,nameof(UserMovie));
        }
        public async Task RemoveSerieToWatchLater(int serieId, string userId)
        {
            var removeFromWatchLater = new UserSerie()
            {
                UserId = userId,
                SerieId = serieId
            };

            repository.Remove<UserSerie>(removeFromWatchLater);
            await repository.SaveChangesAsync();
            logger.LogInformation(MessagesConstants.EntityDeleteSuccesfullyMessage, nameof(UserSerie));
        }
        public async Task<bool> IsMovieAvailable(int movieId, string userId)
        {
            var movies = await repository.TakeAll<UserMovie>().Where(um => um.UserId == userId).ToListAsync();    

            if (!movies.Any(m => m.MovieId == movieId))
            {
                return true;
            }

            return false;
        }
        public async Task<bool> IsSerieAvailable(int serieId, string userId)
        {
            var series = await repository.TakeAll<UserSerie>().Where(um => um.UserId == userId).ToListAsync();

            if (!series.Any(m => m.SerieId == serieId))
            {
                return true;
            }

            return false;
        }
    }
}
