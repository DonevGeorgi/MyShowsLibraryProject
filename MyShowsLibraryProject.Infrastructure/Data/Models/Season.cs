using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    [Comment("Show season")]
    public class Season
    {
        [Key]
        [Comment("Season identifier")]
        public int SeasonId { get; set; }
        [Required]
        [MaxLength(DataConstants.UrlsMaxLength)]
        [Comment("Url for the season poster")]
        public string PosterUrl { get; set; } = string.Empty;
        [Required]
        [MaxLength(DataConstants.YearMaxLength)]
        [Comment("The year saeson is released")]
        public string YearOfRelease {  get; set; } = string.Empty;
        [Required]
        [MaxLength(DataConstants.SeasonEpisodeMaxLength)]
        [Comment("Number of episodes in the season")]
        public string EpisodesInSeason {  get; set; } = string.Empty;
        [Required]
        [Comment("Serie identifier")]
        public int SeriesId { get; set; }
        [ForeignKey(nameof(SeriesId))]
        public Serie Serie { get; set; } = null!;
        public IEnumerable<Episode> Episodes { get; set; } = new List<Episode>();
    }
}
