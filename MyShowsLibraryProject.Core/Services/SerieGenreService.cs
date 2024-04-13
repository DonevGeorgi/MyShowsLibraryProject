using MyShowsLibraryProject.Core.Models.GenreModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class SerieGenreService : ISerieGenreService
    {
        private readonly IRepository repository;
        private readonly ISerieService serieService;
        private readonly IGenreService genreService;    

        public SerieGenreService(IRepository _repository,
            ISerieService _serieService,
            IGenreService _genreService)
        {
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
                throw new NullReferenceException("Serie you chose dont exist!");
            }

            if (serie.Genres.Any(g => g.GenreId == genreId))
            {
                throw new NullReferenceException("Serie contains genre already!");
            }

            var newSerieGenre = new SerieGenre()
            {
                SerieId = serie.SerieId,
                GenreId = genreId
            };

            await repository.AddAsync(newSerieGenre);
            await repository.SaveChangesAsync();
        }
        public async Task RemoveGenreFromSerieAsync(int serieId, int genreId)
        {
            var serie = await serieService.GetSerieDetailsByIdAsync(serieId);

            if (!serie.Genres.Any())
            {
                throw new NullReferenceException("Serie dont have genres!");
            }

            if (!serie.Genres.Any(g => g.GenreId == genreId))
            {
                throw new NullReferenceException("Serie dont have chosen genre!");
            }

            var modelToRemove = new SerieGenre()
            {
                SerieId = serie.SerieId,
                GenreId = genreId
            };

            repository.Remove<SerieGenre>(modelToRemove);
            await repository.SaveChangesAsync();
        }
    }
}
