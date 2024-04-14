using Microsoft.Extensions.Logging;
using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class CrewMovieService : ICrewMovieService
    {
        private readonly ILogger<CrewMovieService> logger;
        private readonly IRepository repository;
        private readonly IMovieService movieService;
        private readonly ICrewService crewService;

        public CrewMovieService(ILogger<CrewMovieService> _logger,
            IRepository _repository,
            IMovieService _movieService,
            ICrewService _crewService)
        {
            logger = _logger;
            repository = _repository;
            movieService = _movieService;
            crewService = _crewService;
        }

        public async Task AddCrewToMovie(int movieId, string crewName)
        {
            var movie = await movieService.GetMovieDetailsByIdAsync(movieId);
            var crewId = await crewService.GetCrewName(crewName);

            if (movie == null)
            {
                logger.LogInformation(MessagesConstants.EntityIdNotFountMessage, nameof(Movie), movieId);
                throw new NullReferenceException(MessagesConstants.MovieDoesNotExistsMessage);
            }

            if (!movie.Crews.Any(g => g.Name == crewName))
            {
                var newMovieCrew = new MovieCrew()
                {
                    MovieId = movie.MovieId,
                    CrewId = crewId
                };

                await repository.AddAsync(newMovieCrew);
                await repository.SaveChangesAsync();
                logger.LogInformation(MessagesConstants.EntityCreatedSuccesfullyMessage,nameof(MovieCrew));
            }
        }
        public async Task RemoveCrewFromMovie(int movieId, string crewName)
        {
            var movie = await movieService.GetMovieDetailsByIdAsync(movieId);
            var crewId = await crewService.GetCrewName(crewName);

            if (movie == null)
            {
                logger.LogInformation(MessagesConstants.EntityIdNotFountMessage, nameof(Movie), movieId);
                throw new NullReferenceException(MessagesConstants.MovieDoesNotExistsMessage);
            }

            if (movie.Crews.Any())
            {
                if (movie.Crews.Any(c => c.CrewId == crewId))
                {
                    var modelToRemove = new MovieCrew()
                    {
                        MovieId = movie.MovieId,
                        CrewId = crewId
                    };

                    repository.Remove<MovieCrew>(modelToRemove);
                    await repository.SaveChangesAsync();
                    logger.LogInformation(MessagesConstants.EntityDeleteSuccesfullyMessage,nameof(MovieCrew));
                }
            }
        }
    }
}
