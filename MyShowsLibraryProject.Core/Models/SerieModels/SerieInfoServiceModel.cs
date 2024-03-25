namespace MyShowsLibraryProject.Core.Models.SerieModels
{
    public class SerieInfoServiceModel
    {
        public int SeriesId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string YearOfStart { get; set; } = string.Empty;
        public string YearOfEnd { get; set; } = string.Empty;
    }
}
