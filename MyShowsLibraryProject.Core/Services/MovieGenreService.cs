using MyShowsLibraryProject.Core.Models.GenreModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class MovieGenreService : IMovieGenreService
    {
        private readonly IRepository repository;
        private readonly IMovieService movieService;
        private readonly IGenreService genreService;

        public MovieGenreService(IRepository _repository,
            IMovieService _movieService,
            IGenreService _genreService)
        {
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
                throw new NullReferenceException();
            }

            if (movie.Genres.Any(g => g.GenreId == genreId))
            {
                throw new ArgumentException("Movie contains genre already!");
            }

            var newMovieGenre = new MovieGenre()
            {
                MovieId = movie.MovieId,
                GenreId = genreId
            };

            await repository.AddAsync(newMovieGenre);
            await repository.SaveChangesAsync();
        }
        public async Task RemoveGenreFromMovieAsync(int movieId, int genreId)
        {
            var movie = await movieService.GetMovieDetailsByIdAsync(movieId);

            if (!movie.Genres.Any())
            {
                throw new ArgumentException("Movie dont have genres!");
            }

            if (!movie.Genres.Any(g => g.GenreId == genreId))
            {
                throw new ArgumentException("Movie dont have chosen genre!");
            }

            var modelToRemove = new MovieGenre()
            {
                MovieId = movie.MovieId,
                GenreId = genreId
            };

            repository.Remove<MovieGenre>(modelToRemove);
            await repository.SaveChangesAsync();
        }
    }
}
