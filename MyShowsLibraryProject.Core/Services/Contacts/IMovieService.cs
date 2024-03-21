using MyShowsLibraryProject.Core.Models.MovieModels;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface IMovieService
    {
        Task<IEnumerable<MoviesCardInfoServiceModel>> GetAllReadonlyAsync();
        Task<MoviesDetailsServiceModel> GetMovieDetailsByIdAsync(int movieId);
        Task<bool> IsMoviePresent(int movieId);
    }
}
