using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    public class SerieCrew
    {
        [Required]
        [Comment("Serie identifier")]
        public int SerieId { get; set; }
        [ForeignKey(nameof(SerieId))]
        public Serie Serie { get; set; } = null!;
        [Required]
        [Comment("Crew identifier")]
        public int CrewId { get; set; }
        [ForeignKey(nameof(CrewId))]
        public Crew Crew { get; set; } = null!;
    }
}
