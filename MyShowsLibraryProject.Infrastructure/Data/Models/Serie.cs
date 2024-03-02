using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    public class Serie
    {
        [Key]
        public int SeriesId { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string PosterUrl { get; set; } = string.Empty;
        [Required]
        public string TrailerUrl { get; set; } = string.Empty;
        public string YearOfStart { get; set; } = string.Empty;
        public string YearOfEnd { get; set; } = string.Empty;
        [Required]
        public string Summary { get; set; } = string.Empty;
        public string OriginalAudioLanguage { get; set; } = string.Empty;
        public string ForMoreSummaryUrl { get; set; } = string.Empty;
        public IEnumerable<Genre> Genres { get; set; } = new List<Genre>();
        public IEnumerable<Season> Seasons { get; set; } = new List<Season>();
        public IEnumerable<SerieReview> SerieReviews { get; set;} = new List<SerieReview>();
        public IEnumerable<SerieCrew> SerieCrews { get; set; } = new List<SerieCrew>();
        public IEnumerable<IdentityUser> UserSerie { get; set; } = new List<IdentityUser>();
    }
}
