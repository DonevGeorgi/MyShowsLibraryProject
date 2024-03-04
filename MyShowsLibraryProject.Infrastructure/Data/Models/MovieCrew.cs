using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    [Comment("Movie crew")]
    public class MovieCrew
    {
        [Required]
        [Comment("Movie identifier")]
        public int MovieId { get; set; }
        [ForeignKey(nameof(MovieId))]
        public Movie Movie { get; set; } = null!;
        [Required]
        [Comment("Crew identifier")]
        public int CrewId { get; set; }
        [ForeignKey(nameof(CrewId))]
        public Crew Crew { get; set; } = null!;
    }
}
