namespace MyShowsLibraryProject.Core.Models.EpisodeModels
{
    public class EpisodeInfoServiceModel
    {
        public int EpisodeId { get; set; }  
        public string SeasonNumber { get; set; } = string.Empty;
        public string EpisodeNumeration { get; set; } = string.Empty;
        public string ReleaseDate { get; set; } = string.Empty;
    }
}
