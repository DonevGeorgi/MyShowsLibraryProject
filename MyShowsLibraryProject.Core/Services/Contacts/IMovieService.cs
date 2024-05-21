using MyShowsLibraryProject.Core.Enumeration;
using MyShowsLibraryProject.Core.Models.MovieModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface IMovieService
    {
        Task<IEnumerable<MoviesInfoServiceModel>> GetAllReadonlyAsync();
        Task<MoviesQueryServiceModel> GetAllCardInfoAsync(string? searchTerm, ShowSorting sorting, int currPage, int moviePerPage);
        Task<MoviesDetailsServiceModel> GetMovieDetailsByIdAsync(int movieId);
        Task<int> CreateAsync(MovieFormModel movie);
        Task EditAsync(int movieId, MovieFormModel movie);
        Task DeleteAsync(int movieId);
        Task<bool> IsMoviePresent(int movieId);
    }
}
