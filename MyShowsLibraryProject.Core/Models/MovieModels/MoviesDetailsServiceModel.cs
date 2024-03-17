using MyShowsLibraryProject.Core.Models.CrewModels;
using MyShowsLibraryProject.Core.Models.GenreModels;

namespace MyShowsLibraryProject.Core.Models.MovieModels
{
    public class MoviesDetailsServiceModel
    {
        public string Title { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public string PosterUrl { get; set; } = string.Empty;
        public string TrailerUrl { get; set; } = string.Empty;
        public string DateOfRelease { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public string OriginalAudioLanguage { get; set; } = string.Empty;
        public string ForMoreSummaryUrl { get; set; } = string.Empty;
        public IEnumerable<GenreInfoSeviceModel> Genres { get; set; } = new List<GenreInfoSeviceModel>();
        public IEnumerable<CrewInfoServiceModel> Crews { get; set; } = new List<CrewInfoServiceModel>();
    }
}
