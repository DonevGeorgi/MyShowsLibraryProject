using MyShowsLibraryProject.Core.Models.EpisodeModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface IEpisodeService
    {
        Task<IEnumerable<EpisodeDetailsServiceModel>> GetEpisodeDetailsAsync(int seasonId);
    }
}
