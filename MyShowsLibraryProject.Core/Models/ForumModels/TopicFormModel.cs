using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Core.Models.ForumModels
{
    public class TopicFormModel
    {
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        [StringLength(DataConstants.TopicNameMaxLength,
            MinimumLength = DataConstants.TopicNameMinLength,
            ErrorMessage = MessagesConstants.LengthMessage)]
        public string Name { get; set; } = string.Empty;
    }
}
