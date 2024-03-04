using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    [Comment("User reviews")]
    public class UserReview
    {
        [Required]
        [Comment("User identifier")]
        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;
        [Required]
        [Comment("Review identifier")]
        public int ReviewId { get; set; }
        [ForeignKey(nameof(ReviewId))]
        public Review Review { get; set; } = null!;
    }
}
