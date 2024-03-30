using MyShowsLibraryProject.Core.Models.SeasonModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface ISeasonService
    {
        Task<IEnumerable<SeasonInfoServiceModel>> GetAllSeasonForSeries(int seriesId);
        Task<IEnumerable<SeasonDetailsServiceModel>> GetSeasonDetailsAsync(int seriesId);
        Task<SeasonDetailsServiceModel> GetSeasonDetailsById(int seasonId);
        Task<int> CreateAsync(SeasonFormModel season, int seriesId);
        Task EditAsync(int seasonId, SeasonFormModel season);
        Task DeleteAsync(int seasonId);
    }
}
