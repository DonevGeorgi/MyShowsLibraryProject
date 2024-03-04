using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    [Comment("User movies")]
    public class UserMovie
    {
        [Required]
        [Comment("User identifier")]
        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;
        [Required]
        [Comment("Movie identifier")]
        public int MovieId { get; set; }
        [ForeignKey(nameof(MovieId))]
        public Movie Movie { get; set; } = null!;
    }
}
