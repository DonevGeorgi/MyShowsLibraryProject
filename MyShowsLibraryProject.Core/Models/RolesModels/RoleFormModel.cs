using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Core.Models.RolesModels
{
    public class RoleFormModel
    {
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        [StringLength(DataConstants.RoleNameMaxLength,
            MinimumLength = DataConstants.RoleNameMinLength,
            ErrorMessage = MessagesConstants.LengthMessage)]
        public string Name { get; set; } = string.Empty;
    }
}
