using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Infrastructure.Constants;
using MyShowsLibraryProject.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Core.Models.MovieModels
{
    public class MovieFormModel
    {
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        [StringLength(DataConstants.TitleMaxLength,
            MinimumLength = DataConstants.TitleMinLength,
            ErrorMessage = MessagesConstants.LengthMessage)]
        public string Title { get; set; } = string.Empty;
        public int Duration { get; set; }
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        [StringLength(DataConstants.UrlsMaxLength,
            MinimumLength = DataConstants.UrlMinLength,
            ErrorMessage = MessagesConstants.LengthMessage)]
        [Display(Name = "movie poster URL")]
        public string PosterUrl { get; set; } = string.Empty;
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        [StringLength(DataConstants.UrlMinLength,
            MinimumLength = DataConstants.UrlMinLength,
            ErrorMessage = MessagesConstants.LengthMessage)]
        [Display( Name = "movie trailer URL")]
        public string TrailerUrl { get; set; } = string.Empty;
        [RegularExpression(DataConstants.ReleaseDataRegex,ErrorMessage = MessagesConstants.ReleaseDataFormat)]
        [Display(Name = "date of release")]
        public string DateOfRelease { get; set; } = string.Empty;
        [Required(ErrorMessage = MessagesConstants.RequiredMessage)]
        [StringLength(DataConstants.SummaryMaxLength,
            MinimumLength = DataConstants.SummaryMinLength,
            ErrorMessage = MessagesConstants.LengthMessage)]
        public string Summary { get; set; } = string.Empty;
        [MaxLength(DataConstants.MovieLenguageMaxLength)]
        [Display(Name = "Movie original audio")]
        public string OriginalAudioLanguage { get; set; } = string.Empty;
        [StringLength(DataConstants.UrlsMaxLength,
           MinimumLength = DataConstants.UrlMinLength,
           ErrorMessage = MessagesConstants.LengthMessage)]
        [Display(Name = "for more information")]
        public string ForMoreSummaryUrl { get; set; } = string.Empty;
        public IEnumerable<MovieGenre> MovieGenres { get; set; } = new List<MovieGenre>();
    }
}
