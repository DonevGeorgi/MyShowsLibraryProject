namespace MyShowsLibraryProject.Core.Services.Contacts
{
    public interface ICrewSerieService
    {
        Task AddCrewToSerie(int serieId, string crewName);
        Task RemoveCrewFromSerie(int serieId, string crewName);
    }
}
