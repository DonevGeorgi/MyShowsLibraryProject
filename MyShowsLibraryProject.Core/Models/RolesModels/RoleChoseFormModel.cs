namespace MyShowsLibraryProject.Core.Models.RolesModels
{
    public class RoleChoseFormModel
    {
        public int RoleId { get; set; }
        public IEnumerable<RoleInfoServiceModel> RoleName { get; set; } = new List<RoleInfoServiceModel>();
    }
}
