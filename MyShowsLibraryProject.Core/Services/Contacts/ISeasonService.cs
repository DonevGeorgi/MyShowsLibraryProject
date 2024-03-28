using MyShowsLibraryProject.Core.Models.SeasonModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface ISeasonService
    {
        Task<IEnumerable<SeasonInfoServiceModel>> GetAllSeasonForSeries(int seriesId);
        Task<int> CreateAsync(SeasonFormModel season, int seriesId);
        Task<IEnumerable<SeasonDetailsServiceModel>> GetSeasonDetailsAsync(int seriesId);
    }
}
