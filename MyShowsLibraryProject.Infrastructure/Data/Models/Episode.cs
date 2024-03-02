using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    public class Episode
    {
        [Key]
        public int EpisodeId { get; set; }
        [Required]
        public string PosterUrl { get; set; } = string.Empty;
        [Required]
        public string Summary {  get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
        [Required]
        public int SeasonId { get; set; }
        [ForeignKey(nameof(SeasonId))]
        public Season Season { get; set; } = null!;
    }
}
