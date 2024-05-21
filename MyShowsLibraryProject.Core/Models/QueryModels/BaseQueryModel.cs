using MyShowsLibraryProject.Core.Enumeration;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Core.Models.BaseQueryModels
{
    public class BaseQueryModel
    {
        public int ShowsPerPage { get; } = 4;
        [Display(Name = "Search by text")]
        public string SearchTerm { get; set; } = string.Empty;
        public ShowSorting Sorting { get; set; }
        public int CurrentPage { get; set; } = 1;
        public int TotalShowsCount { get; set; }
    }
}
