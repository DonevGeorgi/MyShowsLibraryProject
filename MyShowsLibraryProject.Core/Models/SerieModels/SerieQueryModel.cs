using MyShowsLibraryProject.Core.Models.BaseQueryModels;

namespace MyShowsLibraryProject.Core.Models.SerieModels
{
    public class SerieQueryModel : BaseQueryModel
    {
        public IEnumerable<SeriesCardInfoServiceModel> Serie { get; set; } = new List<SeriesCardInfoServiceModel>();

    }
}
