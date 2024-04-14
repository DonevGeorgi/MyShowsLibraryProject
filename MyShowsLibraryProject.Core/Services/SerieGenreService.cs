using Microsoft.Extensions.Logging;
using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Core.Models.GenreModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class SerieGenreService : ISerieGenreService
    {
        private readonly ILogger<SerieGenreService> logger;
        private readonly IRepository repository;
        private readonly ISerieService serieService;
        private readonly IGenreService genreService;

        public SerieGenreService(ILogger<SerieGenreService> _logger,
            IRepository _repository,
            ISerieService _serieService,
            IGenreService _genreService)
        {
            logger = _logger;
            repository = _repository;
            serieService = _serieService;
            genreService = _genreService;
        }

        public async Task<IEnumerable<GenreInfoSeviceModel>> TakeAllGenres()
        {
            var genres = await genreService.GetAllReadonlyAsync();

            return genres;
        }
        public async Task AddGenreToSerieAsync(int serieId, int genreId)
        {
            var serie = await serieService.GetSerieDetailsByIdAsync(serieId);

            if (serie == null)
            {
                logger.LogInformation(MessagesConstants.EntityIdNotFountMessage, nameof(Movie), serieId);
                throw new NullReferenceException(MessagesConstants.SerieDoesNotExistsMessage);
            }

            if (!serie.Genres.Any(g => g.GenreId == genreId))
            {
                var newSerieGenre = new SerieGenre()
                {
                    SerieId = serie.SerieId,
                    GenreId = genreId
                };

                await repository.AddAsync(newSerieGenre);
                await repository.SaveChangesAsync();
                logger.LogInformation(MessagesConstants.EntityCreatedSuccesfullyMessage,nameof(SerieGenre));
            }
        }
        public async Task RemoveGenreFromSerieAsync(int serieId, int genreId)
        {
            var serie = await serieService.GetSerieDetailsByIdAsync(serieId);

            if (serie == null)
            {
                logger.LogInformation(MessagesConstants.EntityIdNotFountMessage, nameof(Movie), serieId);
                throw new NullReferenceException(MessagesConstants.SerieDoesNotExistsMessage);
            }

            if (serie.Genres.Any())
            {
                if (serie.Genres.Any(g => g.GenreId == genreId))
                {
                    var modelToRemove = new SerieGenre()
                    {
                        SerieId = serie.SerieId,
                        GenreId = genreId
                    };

                    repository.Remove<SerieGenre>(modelToRemove);
                    await repository.SaveChangesAsync();
                    logger.LogInformation(MessagesConstants.EntityDeleteSuccesfullyMessage,nameof(SerieGenre));
                }
            }
        }
    }
}
