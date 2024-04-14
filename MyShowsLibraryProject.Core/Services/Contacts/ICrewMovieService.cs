namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface ICrewMovieService
    {
        Task AddCrewToMovie(int movieId, string crewName);
        Task RemoveCrewFromMovie(int movieId, string crewName);
    }
}
