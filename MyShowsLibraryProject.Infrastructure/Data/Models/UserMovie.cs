using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    [Comment("User movies")]
    public class UserMovie
    {
        [Required]
        [Comment("User identifier")]
        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;
        [Required]
        [Comment("Movie identifier")]
        public int MovieIdentifier { get; set; }
        [ForeignKey(nameof(MovieIdentifier))]
        public Movie Movie { get; set; } = null!;
    }
}
