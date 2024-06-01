using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Core.Models.ForumModels
{
    public class PostFormModel
    {
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        [StringLength(DataConstants.PostBodyMaxLength,
            MinimumLength = DataConstants.PostBodyMinLength,
            ErrorMessage = MessagesConstants.LengthMessage)]
        public string PostBody { get; set; } = string.Empty;
    }
}
