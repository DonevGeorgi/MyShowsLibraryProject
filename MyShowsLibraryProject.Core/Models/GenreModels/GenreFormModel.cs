using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Core.Models.GenreModels
{
    public class GenreFormModel
    {
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        [StringLength(DataConstants.GenreNameMaxLength,
            MinimumLength = DataConstants.GenreNameMinLength,
            ErrorMessage = MessagesConstants.LengthMessage)]
        public string Name { get; set; } = string.Empty;
    }
}
