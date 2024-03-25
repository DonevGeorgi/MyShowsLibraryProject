using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    [Comment("Movie model")]
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [Required]
        [MaxLength(DataConstants.TitleMaxLength)]
        [Comment("Movie title")]
        public string Title { get; set; } = string.Empty;
        [Comment("Movie runtime")]
        public int Duration { get; set; }
        [Required]
        [MaxLength(DataConstants.UrlsMaxLength)]
        [Comment("Movie poster URL")]
        public string PosterUrl { get; set; } = string.Empty;
        [Required]
        [MaxLength(DataConstants.UrlsMaxLength)]
        [Comment("Movie trailer URL")]
        public string TrailerUrl { get; set; } = string.Empty;
        [Comment("Movie release date")]
        [MaxLength(DataConstants.MovieReleaseDateMaxLength)]
        public string DateOfRelease { get; set; } = string.Empty;
        [Required]
        [MaxLength(DataConstants.SummaryMaxLength)]
        [Comment("Movie summary")]
        public string Summary { get; set; } = string.Empty;
        [MaxLength(DataConstants.LenguageMaxLength)]
        [Comment("Movie original lenguage")]
        public string OriginalAudioLanguage { get; set; } = string.Empty;
        [MaxLength(DataConstants.UrlsMaxLength)]
        [Comment("URL for more info")]
        public string ForMoreSummaryUrl { get; set; } = string.Empty;
        public IEnumerable<MovieGenre> MovieGenres { get; set; } = new List<MovieGenre>();
        public IEnumerable<MovieReview> MovieReviews { get; set; } = new List<MovieReview>();
        public IEnumerable<MovieCrew> MovieCrews { get; set; } = new List<MovieCrew>();
        public IEnumerable<IdentityUser> UserMovies { get; set; } = new List<IdentityUser>();
    }
}
