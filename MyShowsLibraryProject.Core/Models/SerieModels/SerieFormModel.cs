using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Infrastructure.Constants;
using MyShowsLibraryProject.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Core.Models.SerieModels
{
    public class SerieFormModel
    {
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        [StringLength(DataConstants.TitleMaxLength,
            MinimumLength = DataConstants.TitleMinLength,
            ErrorMessage = MessagesConstants.LengthMessage)]
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        [StringLength(DataConstants.UrlsMaxLength,
            MinimumLength = DataConstants.UrlMinLength,
            ErrorMessage = MessagesConstants.LengthMessage)]
        [Display(Name = "serie poster URL")]
        public string PosterUrl { get; set; } = string.Empty;
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        [StringLength(DataConstants.UrlsMaxLength,
            MinimumLength = DataConstants.UrlMinLength,
            ErrorMessage = MessagesConstants.LengthMessage)]
        [Display(Name = "serie poster URL")]
        public string TrailerUrl { get; set; } = string.Empty;
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        [RegularExpression(DataConstants.ReleaseAndEndYearRegex, ErrorMessage = MessagesConstants.ReleaseAndEndDateFormat)]
        [Display(Name = "release year")]
        public string YearOfStart { get; set; } = string.Empty;
        [RegularExpression(DataConstants.ReleaseAndEndYearRegex, ErrorMessage = MessagesConstants.ReleaseAndEndDateFormat)]
        [Display(Name = "end year")]
        public string YearOfEnd { get; set; } = string.Empty;
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        [StringLength(DataConstants.SummaryMaxLength,
            MinimumLength = DataConstants.SummaryMinLength,
            ErrorMessage = MessagesConstants.LengthMessage)]
        public string Summary { get; set; } = string.Empty;
        [StringLength(DataConstants.LenguageMaxLength,
                MinimumLength = DataConstants.LenguageMinLength,
                ErrorMessage = MessagesConstants.LengthMessage)]
        [Display(Name = "serie original audio")]
        public string OriginalAudioLanguage { get; set; } = string.Empty;
        [StringLength(DataConstants.UrlsMaxLength,
            MinimumLength = DataConstants.UrlMinLength,
            ErrorMessage = MessagesConstants.LengthMessage)]
        [Display(Name = "for more information")]
        public string ForMoreSummaryUrl { get; set; } = string.Empty;
        public string SerieGenres { get; set; } = string.Empty;
        public IEnumerable<Season> Seasons { get; set; } = new List<Season>();
    }
}
