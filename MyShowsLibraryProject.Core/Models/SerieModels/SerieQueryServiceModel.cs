namespace MyShowsLibraryProject.Core.Models.SerieModels
{
    public class SerieQueryServiceModel
    {
        public int TotalSerieCount { get; set; }
        public IEnumerable<SeriesCardInfoServiceModel> Serie { get; set; } = new List<SeriesCardInfoServiceModel>();

    }
}
