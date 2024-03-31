using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Models.GenreModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class GenreService : IGenreService
    {
        private readonly IRepository repository;
        private readonly IMovieService movieService;

        public GenreService(IRepository _repository,
            IMovieService _movieService)
        {
            repository = _repository;
            movieService = _movieService;
        }

        public async Task<IEnumerable<GenreInfoSeviceModel>> GetAllReadonlyAsync()
        {
            var genres = await repository
                .TakeAllReadOnly<Genre>()
                .Select(g => new GenreInfoSeviceModel
                {
                    Name = g.Name
                })
                .ToListAsync();

            return genres;
        }
        public async Task<GenreInfoSeviceModel> GetGenreById(int genreId)
        {
            var genres = await repository
               .TakeAllReadOnly<Genre>()
               .Where(g => g.GenreId == genreId)
               .Select(g => new GenreInfoSeviceModel
               {
                   Name = g.Name
               })
               .FirstOrDefaultAsync();

            return genres;
        }
        public async Task<int> GetGenreIdFromName(string name)
        {
            var genreId = await repository
                .TakeAllReadOnly<Genre>()
                .Where(g => g.Name == name)
                .FirstOrDefaultAsync();

            if (genreId == null)
            {
                return 0;
            }

            return genreId.GenreId;
        }
        public async Task CreateAsync(GenreFormModel genre)
        {
            var newGenre = new Genre()
            {
                Name = genre.Name
            };

            await repository.AddAsync(newGenre);
            await repository.SaveChangesAsync();
        }
        public async Task EditAsync(int genreId, GenreFormModel genre)
        {
            var genreToEdit = await repository.GetByIdAsync<Genre>(genreId);

            if (genreToEdit == null)
            {
                //Exception
            }

            genreToEdit.Name = genre.Name;

            await repository.SaveChangesAsync();
        }
        public async Task DeleteAsync(int genreId)
        {
            await repository.DeleteAsync<Genre>(genreId);
            await repository.SaveChangesAsync();
        }
        public async Task AddGenreToMovieAsync(int movieId, string genreName)
        {
            var movie = await movieService.GetMovieDetailsByIdAsync(movieId);

            if (movie == null)
            {
                throw new NullReferenceException();
            }

            if (movie.Genres.Any(g => g.Name == genreName))
            {
                throw new ArgumentException("Movie contains genre already!");
            }

            var newMovieGenre = new MovieGenre()
            {
                MovieId = movie.MovieId,
                GenreId = await GetGenreIdFromName(genreName)
            };

            await repository.AddAsync(newMovieGenre);
            await repository.SaveChangesAsync();
        }
        public async Task RemoveGenreFromMovie(int movieId, string genreName)
        {
            var movie = await movieService.GetMovieDetailsByIdAsync(movieId);

            if (movie == null)
            {
                throw new NullReferenceException();
            }

            if (!movie.Genres.Any())
            {
                throw new ArgumentException("Movie dont have genres!");
            }

            if (!movie.Genres.Any(g => g.Name == genreName))
            {
                throw new ArgumentException("Movie dont have chosen genre!");
            }

            var modelToRemove = new MovieGenre()
            {
                MovieId = movieId,
                GenreId = await GetGenreIdFromName(genreName)
            };

            repository.Remove<MovieGenre>(modelToRemove);
            await repository.SaveChangesAsync();
        }
    }
}
