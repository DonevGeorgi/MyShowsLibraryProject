using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    public class UserSerie
    {
        [Required]
        [Comment("User identifier")]
        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;
        [Required]
        [Comment("Serie identifier")]
        public int SerieId { get; set; }
        [ForeignKey(nameof(SerieId))]
        public Serie Serie { get; set; } = null!;
    }
}
