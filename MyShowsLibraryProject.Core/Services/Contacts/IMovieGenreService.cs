using MyShowsLibraryProject.Core.Models.GenreModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface IMovieGenreService
    {
        Task<IEnumerable<GenreInfoSeviceModel>> TakeAllGenres(); 
        Task AddGenreToMovieAsync(int movieId, int genreId);
        Task RemoveGenreFromMovieAsync(int movieId, int genreId);
    }
}
