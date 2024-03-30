using MyShowsLibraryProject.Core.Models.EpisodeModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface IEpisodeService
    {
        Task<IEnumerable<EpisodeInfoServiceModel>> GetEpisodeForSeason(int seasonId);
        Task<IEnumerable<EpisodeDetailsServiceModel>> GetEpisodeDetailsAsync(int seasonId);
        Task<EpisodeDetailsServiceModel> GetEpisodeDetailsById(int episodeId);
        Task CreateAsync(EpisodeFormModel episode, int seasonId, int seasonNumeration);
        Task EditAsync(int episodeId, EpisodeFormModel episode);
        Task DeleteAsync(int episodeId);
    }
}
