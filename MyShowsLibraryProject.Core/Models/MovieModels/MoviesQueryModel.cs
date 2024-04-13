using MyShowsLibraryProject.Core.Enumeration;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Core.Models.MovieModels
{
    public class MoviesQueryModel
    {
        public int MoviePerPage { get; } = 4;
        [Display(Name = "Search by text")]
        public string SearchTerm { get; set; } = string.Empty;
        public MovieSorting Sorting { get; set; }
        public int CurrentPage { get; set; } = 1;
        public int TotalMoviesCount { get; set; }
        public IEnumerable<MoviesCardInfoServiceModel> Movies {  get; set; } = new List<MoviesCardInfoServiceModel>();
    }
}
