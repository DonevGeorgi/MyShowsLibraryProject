using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    [Comment("Crew role in the show")]
    public class Role
    {
        [Key]
        [Comment("Role identifier")]
        public int RoleId { get; set; }
        [Required]
        [MaxLength(DataConstants.RoleNameMaxLength)]
        [Comment("Role name")]
        public string Name { get; set; } = string.Empty;
        public IEnumerable<CrewRole> CrewRoles { get; set; } = new List<CrewRole>();
    }
}
