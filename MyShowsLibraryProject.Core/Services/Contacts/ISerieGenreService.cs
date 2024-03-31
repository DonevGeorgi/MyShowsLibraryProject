using MyShowsLibraryProject.Core.Models.GenreModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface ISerieGenreService
    {
        Task<IEnumerable<GenreInfoSeviceModel>> TakeAllGenres();
        Task AddGenreToSerieAsync(int serieId, int genreId);
        Task RemoveGenreFromSerieAsync(int serieId, int genreId);
    }
}
