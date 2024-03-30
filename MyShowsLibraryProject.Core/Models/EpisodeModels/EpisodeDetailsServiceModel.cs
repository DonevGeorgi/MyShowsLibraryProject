namespace MyShowsLibraryProject.Core.Models.EpisodeModels
{
    public class EpisodeDetailsServiceModel
    {
        public int SeasonNumber { get; set; }
        public int EpisodeNumeration { get; set; }
        public string PosterUrl { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public string ReleaseDate { get; set; } = string.Empty;
        public int SeasonId { get; set; }
    }
}
