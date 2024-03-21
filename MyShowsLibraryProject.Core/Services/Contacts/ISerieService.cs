using MyShowsLibraryProject.Core.Models.SerieModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface ISerieService
    {
        Task<IEnumerable<SeriesCardInfoServiceModel>> GetAllReadonlyAsync();
        Task<SeriesDetailsServiceModel> GetSerieDetailsByIdAsync(int serieId);
        Task<bool> IsSeriePresent(int serieId);
    }
}
