using MyShowsLibraryProject.Core.Models.SeasonModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface ISeasonService
    {
        Task<IEnumerable<SeasonDetailsServiceModel>> GetSeasonDetailsAsync(int seriesId);
    }
}
