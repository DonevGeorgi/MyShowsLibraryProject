using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    public class Genre
    {
        [Key]
        [Comment("Genre identifier")]
        public int GenreId { get; set; }
        [Required]
        [MaxLength(DataConstants.GenreNameMaxLength)]
        [Comment("Genre name")]
        public string Name { get; set; } = string.Empty;
        public IEnumerable<MovieGenre> MovieGenres { get; set; } = new List<MovieGenre>();
        public IEnumerable<SerieGenre> SerieGenres { get; set; } = new List<SerieGenre>();
    }
}
