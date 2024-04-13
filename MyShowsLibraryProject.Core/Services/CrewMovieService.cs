using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class CrewMovieService : ICrewMovieService
    {
        private readonly IRepository repository;
        private readonly IMovieService movieService;
        private readonly ICrewService crewService;

        public CrewMovieService(IRepository _repository,
            IMovieService _movieService,
            ICrewService _crewService)
        {
            repository = _repository;
            movieService = _movieService;
            crewService = _crewService;
        }

        public async Task<int> GetCrewName(string crewName)
        {
            var crew = await crewService.GetCrewName(crewName);

            if (crew == 0)
            {
                throw new NullReferenceException("Crew with this name does not exists!");
            }

            return crew;
        }
        public async Task AddCrewToMovie(int movieId, string crewName)
        {
            var movie = await movieService.GetMovieDetailsByIdAsync(movieId);
            var crewId = await GetCrewName(crewName);

            if (movie == null)
            {
                throw new NullReferenceException();
            }

            if (movie.Crews.Any(g => g.Name == crewName))
            {
                throw new NullReferenceException("Movie contains crew already!");
            }

            var newMovieCrew = new MovieCrew()
            {
                MovieId = movie.MovieId,
                CrewId = crewId
            };

            await repository.AddAsync(newMovieCrew);
            await repository.SaveChangesAsync();
        }
        public async  Task RemoveCrewFromMovie(int movieId, string crewName)
        {
            var movie = await movieService.GetMovieDetailsByIdAsync(movieId);
            var crewId = await GetCrewName(crewName);

            if (movie == null)
            {
                throw new NullReferenceException("Movie you chose dont exist!");
            }

            if (!movie.Crews.Any())
            {
                throw new NullReferenceException("Movie dont have any crew!");
            }

            if (!movie.Crews.Any(c => c.CrewId == crewId))
            {
                throw new NullReferenceException("Movie dont have this crew!");
            }

            var modelToRemove = new MovieCrew()
            {
                MovieId = movie.MovieId,
                CrewId = crewId
            };

            repository.Remove<MovieCrew>(modelToRemove);
            await repository.SaveChangesAsync();
        }
    }
}
