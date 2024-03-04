using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    [Comment("Serie genres")]
    public class SerieGenre
    {
        [Required]
        [Comment("Serie identifier")]
        public int SerieId { get; set; }
        [ForeignKey(nameof(SerieId))]
        public Serie Serie { get; set; } = null!;
        [Required]
        [Comment("Genre identifier")]
        public int GenreId { get; set; }
        [ForeignKey(nameof(GenreId))]
        public Genre Genre { get; set; } = null!;
    }
}
