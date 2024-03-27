using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Core.Models.CrewModels
{
    public class CrewFormModel
    {
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        [StringLength(DataConstants.CrewNameMaxLength,
            MinimumLength = DataConstants.CrewNameMinLength,
            ErrorMessage = MessagesConstants.LengthMessage)]
        public string Name { get; set; } = string.Empty;
        [StringLength(DataConstants.CrewPseudonymMaxLength,
            MinimumLength = DataConstants.CrewPseudonymMinLength,
            ErrorMessage = MessagesConstants.LengthMessage)]
        public string Pseudonyms { get; set; } = string.Empty;
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        [RegularExpression(DataConstants.DataRegex, ErrorMessage = MessagesConstants.DataFormat)]
        public string Birthdate { get; set; } = string.Empty;
        [StringLength(DataConstants.CrewNationalityMaxLength,
           MinimumLength = DataConstants.CrewNationalityMinLength,
           ErrorMessage = MessagesConstants.LengthMessage)]
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        public string Nationality { get; set; } = string.Empty;
        [StringLength(DataConstants.UrlsMaxLength,
           MinimumLength = DataConstants.UrlMinLength,
           ErrorMessage = MessagesConstants.LengthMessage)]
        [Display(Name = "crew picture")]
        public string PictureUrl { get; set; } = string.Empty;
        [StringLength(DataConstants.CrewBiographyMaxLength,
           MinimumLength = DataConstants.CrewBiographyMinLength,
           ErrorMessage = MessagesConstants.LengthMessage)]
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        public string Biography { get; set; } = string.Empty;
        [StringLength(DataConstants.UrlsMaxLength,
        MinimumLength = DataConstants.UrlMinLength,
        ErrorMessage = MessagesConstants.LengthMessage)]
        [Display(Name = "for more information")]
        public string MoreInfo { get; set; } = string.Empty;
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        [RegularExpression(DataConstants.GenresInFormat, ErrorMessage = DataConstants.RoleFormat)]
        public string Roles { get; set; } = string.Empty;
    }
}
