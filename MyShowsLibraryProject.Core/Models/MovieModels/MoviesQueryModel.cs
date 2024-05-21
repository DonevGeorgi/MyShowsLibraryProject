using MyShowsLibraryProject.Core.Models.BaseQueryModels;

namespace MyShowsLibraryProject.Core.Models.MovieModels
{
    public class MoviesQueryModel : BaseQueryModel
    {
        public IEnumerable<MoviesCardInfoServiceModel> Movies {  get; set; } = new List<MoviesCardInfoServiceModel>();
    }
}
