using MyShowsLibraryProject.Core.Models.CrewModels;
using MyShowsLibraryProject.Core.Models.GenreModels;
using MyShowsLibraryProject.Core.Models.ReviewModels;

namespace MyShowsLibraryProject.Core.Models.SerieModels
{
    public class SeriesDetailsServiceModel
    {
        public int SerieId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string PosterUrl { get; set; } = string.Empty;
        public string TrailerUrl { get; set; } = string.Empty;
        public string YearOfStart { get; set; } = string.Empty;
        public string YearOfEnd { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public string OriginalAudioLanguage { get; set; } = string.Empty;
        public string ForMoreSummaryUrl { get; set; } = string.Empty;
        public IEnumerable<GenreInfoSeviceModel> Genres { get; set; } = new List<GenreInfoSeviceModel>();
        public IEnumerable<CrewCardInfoServiceModel> Crews { get; set; } = new List<CrewCardInfoServiceModel>();
        public IEnumerable<ReviewInfoServiceModel> Reviews { get; set; } = new List<ReviewInfoServiceModel>();   
    }
}
