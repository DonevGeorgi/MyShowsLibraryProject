using MyShowsLibraryProject.Core.Models.SerieModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface ISerieService
    {
        Task<IEnumerable<SeriesCardInfoServiceModel>> GetAllReadonlyAsync();
    }
}
