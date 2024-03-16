using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Models.GenreModels;
using MyShowsLibraryProject.Core.Models.MovieModels;
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

        public async Task<IEnumerable<MoviesCardInfoServiceModel>> GetAllReadonlyAsync()
            => await repository
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

        public async Task<MoviesDetailsServiceModel> GetMovieDetailsByIdAsync(int movieId)
            => await repository
            .TakeAllReadOnly<Movie>()
            .Where(m => m.MovieId == movieId)
            .Select(m => new MoviesDetailsServiceModel()
            {
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
                        GenreId = mg.GenreId,
                        Name = mg.Genre.Name
                    })
                    .ToList()
            })
            .FirstAsync();
    }
}
