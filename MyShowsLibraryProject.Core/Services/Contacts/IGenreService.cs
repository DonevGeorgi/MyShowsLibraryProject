using MyShowsLibraryProject.Core.Models.GenreModels;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface IGenreService 
    {
        Task<IEnumerable<GenreInfoSeviceModel>> GetAllReadonlyAsync();
        Task<GenreInfoSeviceModel> GetGenreById(int genreId);
        Task<int> GetGenreIdFromName(string name);
        Task CreateAsync(GenreFormModel genre);
        Task EditAsync(int genreId, GenreFormModel genre);
        Task DeleteAsync(int genreId);
        Task AddGenreToMovieAsync(int movieId, string genreName);
        Task RemoveGenreFromMovie(int movieId, string genreName);
    }
}
