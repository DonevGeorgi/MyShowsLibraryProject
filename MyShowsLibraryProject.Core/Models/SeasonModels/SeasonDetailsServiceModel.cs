using MyShowsLibraryProject.Core.Models.EpisodeModels;

namespace MyShowsLibraryProject.Core.Models.SeasonModels
{
    public class SeasonDetailsServiceModel
    {
        public int SeasonId { get; set; }
        public string PosterUrl { get; set; } = string.Empty;
        public int SeasonNumberation { get; set; }
        public string YearOfRelease { get; set; } = string.Empty;
        public string EpisodesInSeason { get; set; } = string.Empty;
        public int SerieId { get; set; }
    }
}
