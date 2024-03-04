using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    [Comment("Movie genres")]
    public class MovieGenre
    {
        [Required]
        [Comment("Movie identifier")]
        public int MovieId { get; set; }
        [ForeignKey(nameof(MovieId))]
        public Movie Movie { get; set; } = null!;
        [Required]
        [Comment("Genre identifier")]
        public int GenreId { get; set; }
        [ForeignKey(nameof(GenreId))]
        public Genre Genre { get; set; } = null!;
    }
}
