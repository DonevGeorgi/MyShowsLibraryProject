using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    [Comment("Crew role")]
    public class CrewRole
    {
        [Required]
        [Comment("Crew identifier")]
        public int CrewId { get; set; }
        [ForeignKey(nameof(CrewId))]
        public Crew Crew { get; set; } = null!;
        [Required]
        [Comment("Role identifier")]
        public int RoleId { get; set; }
        [ForeignKey(nameof(RoleId))]
        public Role Role { get; set; } = null!;
    }
}
