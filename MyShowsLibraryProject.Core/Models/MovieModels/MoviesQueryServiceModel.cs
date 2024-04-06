namespace MyShowsLibraryProject.Core.Models.MovieModels
{
    public class MoviesQueryServiceModel
    {
        public int TotalMovieCount {  get; set; }
        public IEnumerable<MoviesCardInfoServiceModel> Movies {  get; set; } = new List<MoviesCardInfoServiceModel>();
    }
}
