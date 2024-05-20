using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    [Comment("Serie model")]
    public class Serie
    {
        [Key]
        [Comment("Serie identifier")]
        public int SeriesId { get; set; }
        [Required]
        [MaxLength(DataConstants.TitleMaxLength)]
        [Comment("Serie title")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MaxLength(DataConstants.UrlsMaxLength)]
        [Comment("Serie poster URL")]
        public string PosterUrl { get; set; } = string.Empty;
        [Required]
        [MaxLength(DataConstants.UrlsMaxLength)]
        [Comment("Serie trailer URL")]
        public string TrailerUrl { get; set; } = string.Empty;
        [Required]
        [MaxLength(DataConstants.YearMaxLength)]
        [Comment("Serie start year")]
        public string YearOfStart { get; set; } = string.Empty;
        [Comment("Series end year")]
        [MaxLength(DataConstants.YearMaxLength)]
        public string YearOfEnd { get; set; } = string.Empty;
        [Required]
        [MaxLength(DataConstants.SummaryMaxLength)]
        [Comment("Serie summary")]
        public string Summary { get; set; } = string.Empty;
        [MaxLength(DataConstants.SerieLenguageMaxLength)]
        [Comment("Serie original language")]
        public string OriginalAudioLanguage { get; set; } = string.Empty;
        [MaxLength(DataConstants.UrlsMaxLength)]
        [Comment("URL for more info")]
        public string ForMoreSummaryUrl { get; set; } = string.Empty;
        public IEnumerable<SerieGenre> SerieGenres { get; set; } = new List<SerieGenre>();
        public IEnumerable<Season> Seasons { get; set; } = new List<Season>();
        public IEnumerable<SerieReview> SerieReviews { get; set;} = new List<SerieReview>();
        public IEnumerable<SerieCrew> SerieCrews { get; set; } = new List<SerieCrew>();
        public IEnumerable<UserSerie> UserSerie { get; set; } = new List<UserSerie>();
    }
}
