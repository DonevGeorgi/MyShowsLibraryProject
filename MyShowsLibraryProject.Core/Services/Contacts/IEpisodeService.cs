using MyShowsLibraryProject.Core.Models.EpisodeModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface IEpisodeService
    {
        Task<IEnumerable<EpisodeInfoServiceModel>> GetEpisodeForSeason(int seasonId);
        Task CreateAsync(EpisodeFormModel episode, int seasonId, int seasonNumeration);
        Task<IEnumerable<EpisodeDetailsServiceModel>> GetEpisodeDetailsAsync(int seasonId);
    }
}
