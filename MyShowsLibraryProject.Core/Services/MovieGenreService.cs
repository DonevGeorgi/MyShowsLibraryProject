using Microsoft.Extensions.Logging;
using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Core.Models.GenreModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class MovieGenreService : IMovieGenreService
    {
        private readonly ILogger<MovieGenreService> logger;
        private readonly IRepository repository;
        private readonly IMovieService movieService;
        private readonly IGenreService genreService;

        public MovieGenreService(ILogger<MovieGenreService> _logger,
            IRepository _repository,
            IMovieService _movieService,
            IGenreService _genreService)
        {
            logger = _logger;
            repository = _repository;
            movieService = _movieService;
            genreService = _genreService;
        }

        public async Task<IEnumerable<GenreInfoSeviceModel>> TakeAllGenres()
        {
            var genres = await genreService.GetAllReadonlyAsync();

            return genres;
        }
        public async Task AddGenreToMovieAsync(int movieId, int genreId)
        {
            var movie = await movieService.GetMovieDetailsByIdAsync(movieId);

            if (movie == null)
            {
                logger.LogInformation(MessagesConstants.EntityIdNotFountMessage, nameof(Movie), movieId);
                throw new NullReferenceException(MessagesConstants.MovieDoesNotExistsMessage);
            }

            if (!movie.Genres.Any(g => g.GenreId == genreId))
            {
                var newMovieGenre = new MovieGenre()
                {
                    MovieId = movie.MovieId,
                    GenreId = genreId
                };

                await repository.AddAsync(newMovieGenre);
                await repository.SaveChangesAsync();
                logger.LogInformation(MessagesConstants.EntityCreatedSuccesfullyMessage, nameof(MovieGenre));
            }
        }
        public async Task RemoveGenreFromMovieAsync(int movieId, int genreId)
        {
            var movie = await movieService.GetMovieDetailsByIdAsync(movieId);

            if (movie == null)
            {
                logger.LogInformation(MessagesConstants.EntityIdNotFountMessage, nameof(Movie), movieId);
                throw new NullReferenceException(MessagesConstants.MovieDoesNotExistsMessage);
            }

            if (movie.Genres.Any())
            {
                if (movie.Genres.Any(g => g.GenreId == genreId))
                {
                    var modelToRemove = new MovieGenre()
                    {
                        MovieId = movie.MovieId,
                        GenreId = genreId
                    };

                    repository.Remove<MovieGenre>(modelToRemove);
                    await repository.SaveChangesAsync();
                    logger.LogInformation(MessagesConstants.EntityDeleteSuccesfullyMessage, nameof(MovieGenre));
                }
            }
        }
    }
}
