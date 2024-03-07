using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<MovieCardInfoServiceModel>> GetAllReadonlyAsync()
            => await repository
            .TakeAllReadOnly<Movie>()
            .Select(m => new MovieCardInfoServiceModel()
            {
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

        
    }
}
