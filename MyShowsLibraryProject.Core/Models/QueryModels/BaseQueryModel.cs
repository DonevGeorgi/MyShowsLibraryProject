using MyShowsLibraryProject.Core.Enumeration;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Core.Models.BaseQueryModels
{
    public class BaseQueryModel
    {
        public int ItemsPerPage { get; } = 12;
        [Display(Name = "Search by text")]
        public string SearchTerm { get; set; } = string.Empty;
        public BaseSorting Sorting { get; set; }
        public int CurrentPage { get; set; } = 1;
        public int TotalItemsCount { get; set; }
    }
}
