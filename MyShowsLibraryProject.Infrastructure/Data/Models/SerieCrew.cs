using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    public class SerieCrew
    {
        [Required]
        public int SerieId { get; set; }
        [ForeignKey(nameof(SerieId))]
        public Serie Serie { get; set; } = null!;
        [Required]
        public int CrewId { get; set; }
        [ForeignKey(nameof(CrewId))]
        public Crew Crew { get; set; } = null!;
    }
}
