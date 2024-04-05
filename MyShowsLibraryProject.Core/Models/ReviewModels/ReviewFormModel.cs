using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Core.Models.ReviewModels
{
    public class ReviewFormModel
    {
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        [Range(DataConstants.RatingMinLength, DataConstants.RatingMaxLength,
            ErrorMessage = MessagesConstants.RangeMessage)]
        public int Rating { get; set; }
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        [StringLength(DataConstants.ReviewContentMaxLength,
            ErrorMessage = MessagesConstants.LengthMessage)]
        public string Content { get; set; } = string.Empty;
    }
}
