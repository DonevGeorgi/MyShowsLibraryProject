namespace MyShowsLibraryProject.Core.Models.GenreModels
{
    public class GenreChoseFromModel
    {
        public int GenreId { get; set; }
        public IEnumerable<GenreInfoSeviceModel> GenresName { get; set; } = new List<GenreInfoSeviceModel>();
    }
}
