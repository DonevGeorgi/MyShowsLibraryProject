namespace MyShowsLibraryProject.Core.Models.CrewModels
{
    public class CrewChoseFormModel
    {
        public int CrewId { get; set; }
        public IEnumerable<CrewInfoServiceModel> CrewNames { get; set; } = new List<CrewInfoServiceModel>();
    }
}
