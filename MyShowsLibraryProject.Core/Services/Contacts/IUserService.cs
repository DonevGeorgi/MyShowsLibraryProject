using MyShowsLibraryProject.Core.Models.MovieModels;
using MyShowsLibraryProject.Core.Models.SerieModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface IUserService
    {
        Task<IEnumerable<MoviesCardInfoServiceModel>> GetAllMovieForWatchLaterAsync(string userId);
        Task<IEnumerable<SeriesCardInfoServiceModel>> GetAllSerieForWatchLaterAsync(string userId);
        Task AddMovieToWatchLater(int movieId,string userId);
        Task AddSerieToWatchLater(int serieId, string userId);
        Task RemoveMovieToWatchLater(int movieId, string userId);
        Task RemoveSerieToWatchLater(int serieId, string userId);
        Task<bool> IsMovieAvailable(int movieId, string userId);
        Task<bool> IsSerieAvailable(int serieId, string userId);
    }
}
