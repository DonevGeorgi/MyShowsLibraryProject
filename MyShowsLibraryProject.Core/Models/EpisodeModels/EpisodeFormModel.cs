using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Core.Models.EpisodeModels
{
    public class EpisodeFormModel
    {
        public int SeasonNumber { get; set; }
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        [Range(DataConstants.EpisodeNumerationMinLength,
            DataConstants.EpisodeNumerationMaxLength,
            ErrorMessage = MessagesConstants.RangeMessage)]
        [Display(Name = "episode numeration")]
        public int EpisodeNumeration { get; set; }
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        [StringLength(DataConstants.UrlsMaxLength,
            MinimumLength = DataConstants.UrlMinLength,
            ErrorMessage = MessagesConstants.LengthMessage)]
        [Display(Name = "episode poster URL")]
        public string PosterUrl { get; set; } = string.Empty;
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        [StringLength(DataConstants.SummaryMaxLength,
            MinimumLength = DataConstants.SummaryMinLength,
            ErrorMessage = MessagesConstants.LengthMessage)]
        public string Summary { get; set; } = string.Empty;
        [Display(Name = "release date")]
        [RegularExpression(DataConstants.DataRegex,
            ErrorMessage = MessagesConstants.DataFormat)]
        public string ReleaseDate { get; set; } = string.Empty;
        public int SeasonId { get; set; }
    }
}
