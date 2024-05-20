using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    [Comment("User series")]
    public class UserSerie
    {
        [Required]
        [Comment("User identifier")]
        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;
        [Required]
        [Comment("Serie identifier")]
        public int SerieIdentifier { get; set; }
        [ForeignKey(nameof(SerieIdentifier))]
        public Serie Serie { get; set; } = null!;
    }
}
