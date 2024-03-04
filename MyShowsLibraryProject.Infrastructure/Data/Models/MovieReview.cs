using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    [Comment("Movie reviews")]
    public class MovieReview
    {
        [Required]
        [Comment("Movie identifier")]
        public int MovieId { get; set; }
        [ForeignKey(nameof(MovieId))]
        public Movie Movie { get; set; } = null!;
        [Required]
        [Comment("Review identifier")]
        public int ReviewId { get; set; }
        [ForeignKey(nameof(ReviewId))]
        public Review Review { get; set; } = null!;
    }
}
