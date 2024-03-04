using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    [Comment("Serie reviews")]
    public class SerieReview
    {
        [Required]
        [Comment("Serie identifier")]
        public int SerieId { get; set; }
        [ForeignKey(nameof(SerieId))]
        public Serie Serie { get; set; } = null!;
        [Required]
        [Comment("Review identitfier")]
        public int ReviewId { get; set; }
        [ForeignKey(nameof(ReviewId))]
        public Review Review { get; set;} = null!;
    }
}
