using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    public class Review
    {
        [Key]
        [Comment("Review identifier")]
        public int ReviewId { get; set; }
        [Required]
        [Comment("Rating given to the movie")] 
        public int Rating { get; set; }
        [Required]
        [MaxLength(DataConstants.ReviewContentMaxLength)]
        [Comment("Review content")]
        public string Content { get; set; } = string.Empty;
        public IEnumerable<SerieReview> SerieReviews { get; set; } = new List<SerieReview>();
        public IEnumerable<MovieReview> MovieReviews { get; set; } = new List<MovieReview>();
        public IEnumerable<IdentityUser> UserReviews { get; set; } = new List<IdentityUser>();  
    }
}
