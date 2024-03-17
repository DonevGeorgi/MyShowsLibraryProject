namespace MyShowsLibraryProject.Core.Models.EpisodeModels
{
    public class EpisodeDetailsServiceModel
    {
        public int SeasonNumber { get; set; }
        public string EpisodeNumeration { get; set; } = string.Empty;
        public string PosterUrl { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public string ReleaseDate { get; set; } = string.Empty;
        public int SeasonId { get; set; }
    }
}
