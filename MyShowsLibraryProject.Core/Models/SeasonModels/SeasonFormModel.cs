using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Core.Models.SeasonModels
{
    public class SeasonFormModel
    {
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        [StringLength(DataConstants.UrlsMaxLength,
            MinimumLength = DataConstants.UrlMinLength,
            ErrorMessage = MessagesConstants.LengthMessage)]
        [Display(Name = "season poster URL")]
        public string PosterUrl { get; set; } = string.Empty;
        [Range(DataConstants.SeasonEpisodeMinLength,
            DataConstants.SeasonEpisodeMaxLength,
            ErrorMessage = MessagesConstants.RangeMessage)]
        public int SeasonNumberation { get; set; }
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        [RegularExpression(DataConstants.ReleaseAndEndYearRegex,
            ErrorMessage = MessagesConstants.ReleaseAndEndDateFormat)]
        [Display(Name = "release year")]
        public string YearOfRelease { get; set; } = string.Empty;
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        [StringLength(DataConstants.SeasonEpisodeMaxLength,
            MinimumLength = DataConstants.SeasonEpisodeMinLength,
            ErrorMessage = MessagesConstants.LengthMessage)]
        [Display(Name = "episode in the season")]
        public string EpisodesInSeason { get; set; } = string.Empty;
        public int SeriesId { get; set; }
    }
}
