using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Core.Models.CrewModels
{
    public class CrewNameFromModel
    {
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        [StringLength(DataConstants.CrewNameMaxLength,
        MinimumLength = DataConstants.CrewNameMinLength,
        ErrorMessage = MessagesConstants.LengthMessage)]
        public string CrewName { get; set; } = string.Empty;
    }
}
