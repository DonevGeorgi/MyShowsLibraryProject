namespace MyShowsLibraryProject.Core.Models.GenreModels
{
    public class GenreChoseFormModel
    {
        public int GenreId { get; set; }
        public IEnumerable<GenreInfoSeviceModel> GenresName { get; set; } = new List<GenreInfoSeviceModel>();
    }
}
