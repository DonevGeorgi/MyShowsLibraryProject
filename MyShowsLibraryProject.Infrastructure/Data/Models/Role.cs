using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public int CrewId { get; set; }
        [ForeignKey(nameof(CrewId))]
        public Crew Crew { get; set; } = null!;
    }
}
