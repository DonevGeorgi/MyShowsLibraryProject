using MyShowsLibraryProject.Core.Models.CrewModels;

namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface ICrewMovieService
    {
        Task<IEnumerable<CrewInfoServiceModel>> TakeAllCrews(int movieId);
        Task AddCrewToMovie(int movieId, string crewName);
        Task RemoveCrewFromMovie(int movieId, string crewName);
    }
}
