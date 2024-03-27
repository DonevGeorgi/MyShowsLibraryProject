using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Models.CrewModels;
using MyShowsLibraryProject.Core.Models.GenreModels;
using MyShowsLibraryProject.Core.Models.MovieModels;
using MyShowsLibraryProject.Core.Models.ReviewModels;
using MyShowsLibraryProject.Core.Models.RolesModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class MovieService : IMovieService
    {
        private readonly IRepository repository;
        private readonly IGenreService genreService;

        public MovieService(IRepository _repository,
            IGenreService _genreService)
        {
            repository = _repository;
            genreService = _genreService;
        }

        public async Task<IEnumerable<MoviesInfoServiceModel>> GetAllReadonlyAsync()
        {
            var movies = await repository
                .TakeAllReadOnly<Movie>()
                .Select(m => new MoviesInfoServiceModel()
                {
                    MovieId = m.MovieId,
                    Title = m.Title,
                    YearOfRelease = m.DateOfRelease
                })
                .ToListAsync();

            return movies;
        }
        public async Task<IEnumerable<MoviesCardInfoServiceModel>> GetAllCardInfoAsync()
        {
            var movies = await repository
            .TakeAllReadOnly<Movie>()
            .Select(m => new MoviesCardInfoServiceModel()
            {
                MovieId = m.MovieId,
                Title = m.Title,
                PosterUrl = m.PosterUrl,
                YearOfRelease = m.DateOfRelease,
                //Later when you add review try make method and add null check not implemented yet
                Rating = repository
                        .TakeAll<MovieReview>()
                        .Where(r => r.MovieId == m.MovieId)
                        .Average(mr => mr.Review.Rating)
                        .ToString()
            })
            .ToListAsync();

            return movies;
        }
        public async Task<MoviesDetailsServiceModel> GetMovieDetailsByIdAsync(int movieId)
        {
            var movie = await repository
             .TakeAllReadOnly<Movie>()
             .Where(m => m.MovieId == movieId)
             .Select(m => new MoviesDetailsServiceModel()
             {
                 MovieId = m.MovieId,
                 Title = m.Title,
                 Duration = m.Duration.ToString(),
                 PosterUrl = m.PosterUrl,
                 TrailerUrl = m.TrailerUrl,
                 DateOfRelease = m.DateOfRelease,
                 Summary = m.Summary,
                 OriginalAudioLanguage = m.OriginalAudioLanguage,
                 ForMoreSummaryUrl = m.ForMoreSummaryUrl,
                 Genres = repository
                     .TakeAllReadOnly<MovieGenre>()
                     .Where(mg => mg.MovieId == movieId)
                     .Select(mg => new GenreInfoSeviceModel()
                     {
                         Name = mg.Genre.Name
                     })
                     .ToList(),
                 Crews = repository
                     .TakeAllReadOnly<MovieCrew>()
                     .Where(mr => mr.MovieId == movieId)
                     .Select(mr => new CrewCardInfoServiceModel
                     {
                         CrewId = mr.CrewId,
                         Name = mr.Crew.Name,
                         PictureUrl = mr.Crew.PictureUrl,
                         Roles = repository
                         .TakeAllReadOnly<CrewRole>()
                         .Where(cr => cr.CrewId == mr.CrewId)
                         .Select(r => new RoleInfoServiceModel
                         {
                             Name = r.Role.Name
                         })
                         .ToList()
                     })
                     .ToList(),
                 Reviews = repository
                    .TakeAllReadOnly<MovieReview>()
                    .Where(r => r.MovieId == movieId)
                    .Select(r => new ReviewInfoServiceModel
                    {
                        Rating = r.Review.Rating.ToString(),
                        Content = r.Review.Content,
                        UserUsername = repository
                        .TakeAllReadOnly<UserReview>()
                        .Where(ur => ur.ReviewId == r.ReviewId)
                        .Select(ur => ur.User.UserName)
                        .First()
                    })
                    .ToList()
             })
            .FirstAsync();

            return movie;
        }
        public async Task<bool> IsMoviePresent(int movieId)
        {
            var result = await repository.GetByIdAsync<Movie>(movieId);

            if (result == null)
            {
                return false;
            }

            return true;
        }
        public async Task<int> CreateAsync(MovieFormModel movie)
        {
            var newMovie = new Movie()
            {
                Title = movie.Title,
                Duration = movie.Duration,
                PosterUrl = movie.PosterUrl,
                TrailerUrl = movie.TrailerUrl,
                DateOfRelease = movie.DateOfRelease,
                OriginalAudioLanguage = movie.OriginalAudioLanguage,
                Summary = movie.Summary,
                ForMoreSummaryUrl = movie.ForMoreSummaryUrl
            };

            await repository.AddAsync(newMovie);
            await repository.SaveChangesAsync();

            var genres = movie.MovieGenres
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            foreach (var genre in genres)
            {
                var currGenreId = await genreService.GetGenreIdFromName(genre);

                if (currGenreId == 0)
                {
                    //Exception
                }

                var newMovieGenre = new MovieGenre()
                {
                    MovieId = newMovie.MovieId,
                    GenreId = currGenreId
                };

                await repository.AddAsync(newMovieGenre);
            }

            await repository.SaveChangesAsync();

            return newMovie.MovieId;
        }
    }
}
