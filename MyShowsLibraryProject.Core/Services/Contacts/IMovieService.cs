using MyShowsLibraryProject.Core.Models.MovieModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface IMovieService
    {
        Task<IEnumerable<MoviesCardInfoServiceModel>> GetAllReadonlyAsync();
        Task<MoviesDetailsServiceModel> GetMovieDetailsByIdAsync(int movieId);
    }
}
