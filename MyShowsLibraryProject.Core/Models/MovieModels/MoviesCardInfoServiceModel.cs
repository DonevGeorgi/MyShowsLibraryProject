namespace MyShowsLibraryProject.Core.Models.MovieModels
{
    public class MoviesCardInfoServiceModel
    {
        public int MovieId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string YearOfRelease { get; set; } = string.Empty;
        public string PosterUrl { get; set; } = string.Empty;
        public string Rating { get; set; } = string.Empty;
    }
}
