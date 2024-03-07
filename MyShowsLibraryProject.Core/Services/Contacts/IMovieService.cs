using MyShowsLibraryProject.Core.Models.MovieModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface IMovieService
    {
        Task<IEnumerable<MovieCardInfoServiceModel>> GetAllReadonlyAsync();
    }
}
