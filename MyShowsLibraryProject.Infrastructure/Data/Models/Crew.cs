using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    public class Crew
    {
        [Key]
        public int CrewId { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public DateTime Birthdate { get; set; }
        [Required]
        public string Nationality {  get; set; } = string.Empty;
        [Required]
        public string PictureUrl { get; set; } = string.Empty ;
        [Required]
        public string Biography { get; set; } = string.Empty;
        public string MoreInfo { get; set; } = string.Empty;
        public IEnumerable<SerieCrew> SerieCrew { get; set; } = new List<SerieCrew>();
        public IEnumerable<MovieCrew> MovieCrew { get; set; } = new List<MovieCrew>();
    }
}
