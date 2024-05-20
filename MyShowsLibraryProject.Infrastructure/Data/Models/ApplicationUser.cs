 using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(DataConstants.FirstNameMaxLength)]
        [PersonalData]
        [Comment("User first name")]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        [MaxLength(DataConstants.LastNameMaxLength)]
        [PersonalData]
        [Comment("User last name")]
        public string LastName { get; set; } = string.Empty;
        public IEnumerable<Post> Posts { get; set; } = new List<Post>();
    }
}
