using MyShowsLibraryProject.Core.Models.RolesModels;

namespace MyShowsLibraryProject.Core.Models.CrewModels
{
    public class CrewCardInfoServiceModel
    {
        public int CrewId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PictureUrl {  get; set; } = string.Empty;
        public IEnumerable<RoleInfoServiceModel> Roles { get; set; } = new List<RoleInfoServiceModel>();
    }
}
