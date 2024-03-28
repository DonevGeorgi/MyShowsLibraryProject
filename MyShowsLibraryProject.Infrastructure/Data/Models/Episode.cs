using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    [Comment("Season episode")]
    public class Episode
    {
        [Key]
        public int EpisodeId { get; set; }
        [Required]
        [Comment("Number of season")]
        public int SeasonNumber { get; set; }
        [Required]
        [Comment("Number of the episode in the season")]
        public int EpisodeNumeration { get; set; }
        [Required]
        [MaxLength(DataConstants.UrlsMaxLength)]
        [Comment("Url for the episode poster")]
        public string PosterUrl { get; set; } = string.Empty;
        [Required]
        [MaxLength(DataConstants.SummaryMaxLength)]
        [Comment("Episode summary")]
        public string Summary {  get; set; } = string.Empty;
        [Comment("Episode release date")]
        public string ReleaseDate { get; set; } = string.Empty;
        [Required]
        [Comment("Season identifier")]
        public int SeasonId { get; set; }
        [ForeignKey(nameof(SeasonId))]
        public Season Season { get; set; } = null!;
    }
}
