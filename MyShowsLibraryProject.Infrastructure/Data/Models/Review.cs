using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required]
        public string Description { get; set; } = string.Empty;
        public IEnumerable<SerieReview> SerieReviews { get; set; } = new List<SerieReview>();
        public IEnumerable<MovieReview> MovieReviews { get; set; } = new List<MovieReview>();
        public IEnumerable<IdentityUser> UserReviews { get; set; } = new List<IdentityUser>();  
    }
}
