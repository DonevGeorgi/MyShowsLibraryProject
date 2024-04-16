using MyShowsLibraryProject.Core.Models.MovieModels;
using MyShowsLibraryProject.Core.Models.SerieModels;

namespace MyShowsLibraryProject.Core.Models.HomeModels
{
    public class HomeShowsServiceModel
    {
        public IEnumerable<MoviesCardInfoServiceModel> Movies { get; set; } = new List<MoviesCardInfoServiceModel>();
        public IEnumerable<SeriesCardInfoServiceModel> Series { get; set; } = new List<SeriesCardInfoServiceModel>();
        public MoviesCardInfoServiceModel HighestRatedMovies { get; set; } = null!;
        public SeriesCardInfoServiceModel HighestRatedSeries { get; set; } = null!;
    }
}
