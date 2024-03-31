using MyShowsLibraryProject.Core.Models.GenreModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface IGenreService 
    {
        Task<IEnumerable<GenreInfoSeviceModel>> GetAllReadonlyAsync();
        Task<GenreInfoSeviceModel> GetGenreById(int genreId);
        Task CreateAsync(GenreFormModel genre);
        Task EditAsync(int genreId, GenreFormModel genre);
        Task DeleteAsync(int genreId);
    }
}
