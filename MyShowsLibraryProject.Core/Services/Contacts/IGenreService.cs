using MyShowsLibraryProject.Core.Models.GenreModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface IGenreService 
    {
        Task<IEnumerable<GenreInfoSeviceModel>> GetAllReadonlyAsync();
        Task<int> GetGenreIdFromName(string name);
        Task CreateAsync(GenreFormModel genre);
    }
}
