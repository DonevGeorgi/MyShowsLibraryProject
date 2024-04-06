using MyShowsLibraryProject.Core.Enumeration;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Core.Models.SerieModels
{
    public class SerieQueryModel
    {
        public int SeriePerPage { get; } = 12;
        [Display(Name = "Search by text")]
        public string SearchTerm { get; set; } = string.Empty;
        public SerieSorting Sorting { get; set; }
        public int CurrentPage { get; set; } = 1;
        public int TotalSeriesCount { get; set; }
        public IEnumerable<SeriesCardInfoServiceModel> Serie { get; set; } = new List<SeriesCardInfoServiceModel>();

    }
}
