using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        public int Duration { get; set; }
        [Required]
        public string PosterUrl { get; set; } = string.Empty;
        [Required]
        public string TrailerUrl { get; set; } = string.Empty;
        public DateTime DateOfRelease { get; set; }
        [Required]
        public string Summary { get; set; } = string.Empty;
        public string OriginalAudioLanguage { get; set; } = string.Empty;
        public string ForMoreSummaryUrl { get; set; } = string.Empty;
        public IEnumerable<Genre> Genres { get; set; } = new List<Genre>();
        public IEnumerable<MovieReview> MovieReviews { get; set; } = new List<MovieReview>();
        public IEnumerable<MovieCrew> MovieCrews { get; set; } = new List<MovieCrew>();
        public IEnumerable<IdentityUser> UserMovies { get; set; } = new List<IdentityUser>();
    }
}
