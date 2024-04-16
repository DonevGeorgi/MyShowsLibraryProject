using MyShowsLibraryProject.Core.Models.MovieModels;
using MyShowsLibraryProject.Core.Models.SerieModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface IHomeService
    {
        Task<IEnumerable<MoviesCardInfoServiceModel>> GetLastAddedMovies();
        Task<IEnumerable<SeriesCardInfoServiceModel>> GetLastAddedSeries();
        Task<MoviesCardInfoServiceModel> GetHighestRatedLastAddedMovies();
        Task<SeriesCardInfoServiceModel> GetHighestRatedLastAddedSeries();
    }
}
