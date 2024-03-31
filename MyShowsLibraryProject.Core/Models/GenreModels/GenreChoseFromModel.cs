namespace MyShowsLibraryProject.Core.Models.GenreModels
{
    public class GenreChoseFromModel
    {
        public string Name { get; set; } = string.Empty;
        public IEnumerable<GenreInfoSeviceModel> GenresName { get; set; } = new List<GenreInfoSeviceModel>();
    }
}
