namespace MyShowsLibraryProject.Core.Models.SerieModels
{
    public class SeriesCardInfoServiceModel
    {
        public int SerieId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string PosterUrl { get; set; } = string.Empty;
        public string Rating { get; set; } = string.Empty;
        public string StartYear {  get; set; } = string.Empty;
        public string EndYear { get; set; } = string.Empty;
    }
}
