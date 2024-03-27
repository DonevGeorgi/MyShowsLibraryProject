using MyShowsLibraryProject.Core.Models.MovieModels;
using MyShowsLibraryProject.Core.Models.RolesModels;
using MyShowsLibraryProject.Core.Models.SerieModels;

namespace MyShowsLibraryProject.Core.Models.CrewModels
{
    public class CrewDetailsServiceModel
    {
        public string Name { get; set; } = string.Empty;
        public string Pseudonyms { get; set; } = string.Empty;
        public string Birthdate { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
        public string PictureUrl { get; set; } = string.Empty;
        public string Biography { get; set; } = string.Empty;
        public string MoreInfo { get; set; } = string.Empty;
        public IEnumerable<RoleInfoServiceModel> Roles { get; set; } = new List<RoleInfoServiceModel>();
        public IEnumerable<SeriesCardInfoServiceModel> Series { get; set; } = new List<SeriesCardInfoServiceModel>();
        public IEnumerable<MoviesCardInfoServiceModel> Movies { get; set; } = new List<MoviesCardInfoServiceModel>();
    }
}
