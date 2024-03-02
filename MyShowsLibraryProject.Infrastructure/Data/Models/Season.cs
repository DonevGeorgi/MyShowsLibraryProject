using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    public class Season
    {
        [Key]
        public int SeasonId { get; set; }
        [Required]
        public string PosterUrl { get; set; } = string.Empty;
        [Required]
        public string YearOfRelease {  get; set; } = string.Empty;
        [Required]
        public string EpisodesInSeason {  get; set; } = string.Empty;
        [Required]
        public int SeriesId { get; set; }
        [ForeignKey(nameof(SeriesId))]
        public Serie Serie { get; set; } = null!;
        public IEnumerable<Episode> Episodes { get; set; } = new List<Episode>();
    }
}
