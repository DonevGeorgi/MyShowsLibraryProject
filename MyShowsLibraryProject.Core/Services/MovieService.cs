using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Enumeration;
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

        public MovieService(IRepository _repository)
        {
            repository = _repository;
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
        public async Task<MoviesQueryServiceModel> GetAllCardInfoAsync(string? searchTerm = null,
            MovieSorting sorting = MovieSorting.FromA,
            int currPage = 1,
            int moviePerPage = 4)
        {
            var movies = repository.TakeAllReadOnly<Movie>();

            if (searchTerm != null)
            {
                string normalizeSearchTerm = searchTerm.ToLower();
                movies = movies
                    .Where(m => m.Title.ToLower().Contains(normalizeSearchTerm));
            }

            movies = sorting switch
            {
                MovieSorting.FromA => movies.OrderBy(m => m.Title),
                MovieSorting.ToA => movies.OrderByDescending(m => m.Title),
                _ => movies
            };

            var moviesToShow = await movies
                .Skip((currPage - 1) * moviePerPage)
                .Take(moviePerPage)
                .Select(m => new MoviesCardInfoServiceModel()
                {
                    MovieId = m.MovieId,
                    Title = m.Title,
                    PosterUrl = m.PosterUrl,
                    YearOfRelease = m.DateOfRelease,
                    Rating = Math.Round(((double)repository
                        .TakeAll<MovieReview>()
                        .Where(r => r.MovieId == m.MovieId)
                        .Average(mr => mr.Review.Rating)), 2)
                        .ToString()
                })
                .ToListAsync();

            int totalMovies = await movies.CountAsync();

            return new MoviesQueryServiceModel()
            {
                Movies = moviesToShow,
                TotalMovieCount = totalMovies
            };
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
                 Duration = m.Duration,
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
                         GenreId = mg.GenreId,
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
                        ReviewId = r.ReviewId,
                        Rating = r.Review.Rating,
                        Content = r.Review.Content,
                        UserUsername = repository
                        .TakeAllReadOnly<UserReview>()
                        .Where(ur => ur.ReviewId == r.ReviewId)
                        .Select(ur => ur.User.UserName)
                        .First()
                    })
                    .ToList()
             })
            .FirstOrDefaultAsync();

            if (movie == null)
            {
                throw new ArgumentNullException("Movie does not exists!");
            }

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

            return newMovie.MovieId;
        }
        public async Task EditAsync(int movieId, MovieFormModel movie)
        {
            var movieToEdit = await repository.GetByIdAsync<Movie>(movieId);

            if (movieToEdit == null)
            {
                throw new NullReferenceException("Movie you want to edit does not exists!");
            }

            movieToEdit.Title = movie.Title;
            movieToEdit.Duration = movie.Duration;
            movieToEdit.PosterUrl = movie.PosterUrl;
            movieToEdit.TrailerUrl = movie.TrailerUrl;
            movieToEdit.DateOfRelease = movie.DateOfRelease;
            movieToEdit.Summary = movie.Summary;
            movieToEdit.OriginalAudioLanguage = movie.OriginalAudioLanguage;
            movieToEdit.ForMoreSummaryUrl = movie.ForMoreSummaryUrl;

            await repository.SaveChangesAsync();
        }
        public async Task DeleteAsync(int movieId)
        {
            await repository.DeleteAsync<Movie>(movieId);
            await repository.SaveChangesAsync();
        }
    }
}
