using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Core.Models.ForumModels
{
    public class ReplyFormModel
    {
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        [StringLength(DataConstants.ReplyBodyMaxLength,
            MinimumLength = DataConstants.ReplyBodyMinLength,
            ErrorMessage = MessagesConstants.LengthMessage)]
        public string ReplyBody { get; set; } = string.Empty;
    }
}
