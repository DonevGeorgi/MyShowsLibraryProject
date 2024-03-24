using MyShowsLibraryProject.Core.Models.MovieModels;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface IMovieService
    {
        Task<IEnumerable<MoviesInfoServiceModel>> GetAllReadonlyAsync();
        Task<IEnumerable<MoviesCardInfoServiceModel>> GetAllCardInfoAsync();
        Task<MoviesDetailsServiceModel> GetMovieDetailsByIdAsync(int movieId);
        Task<int> CreateAsync(MovieFormModel movie);
        Task<bool> IsMoviePresent(int movieId);
    }
}
