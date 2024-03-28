namespace MyShowsLibraryProject.Core.Models.SeasonModels
{
    public class SeasonInfoServiceModel
    {
        public int SeasonId { get; set; }
        public int SeasonNumberation { get; set; }
        public string YearOfRelease { get; set; } = string.Empty;
        public string EpisodesInSeason { get; set; } = string.Empty;
    }
}
