using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Core.Models.GenreModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class GenreService : IGenreService
    {
        private readonly ILogger<GenreService> logger;
        private readonly IRepository repository;

        public GenreService(ILogger<GenreService> _logger,
            IRepository _repository)
        {
            logger = _logger;
            repository = _repository;
        }

        public async Task<IEnumerable<GenreInfoSeviceModel>> GetAllReadonlyAsync()
        {
            var genres = await repository
                .TakeAllReadOnly<Genre>()
                .Select(g => new GenreInfoSeviceModel
                {
                    GenreId = g.GenreId,
                    Name = g.Name
                })
                .ToListAsync();

            return genres;
        }
        public async Task<GenreInfoSeviceModel> GetGenreById(int genreId)
        {
            var genres = await repository
               .TakeAllReadOnly<Genre>()
               .Where(g => g.GenreId == genreId)
               .Select(g => new GenreInfoSeviceModel
               {
                   GenreId = g.GenreId,
                   Name = g.Name
               })
               .FirstOrDefaultAsync();

            return genres;
        }
        public async Task CreateAsync(GenreFormModel genre)
        {
            var genres = await GetAllReadonlyAsync();

            if (!genres.Any(g => g.Name == genre.Name))
            {
                var newGenre = new Genre()
                {
                    Name = genre.Name
                };

                await repository.AddAsync(newGenre);
                await repository.SaveChangesAsync();
                logger.LogInformation(MessagesConstants.EntityCreatedMessage,nameof(Genre),genre.Name);
            }

        }
        public async Task EditAsync(int genreId, GenreFormModel genre)
        {
            var genreToEdit = await repository.GetByIdAsync<Genre>(genreId);

            if (genreToEdit == null)
            {
                logger.LogInformation(MessagesConstants.EntityIdNotFountMessage,nameof(Genre),genreId);
                throw new NullReferenceException(MessagesConstants.GenreDoesNotExistsMessage);
            }

            genreToEdit.Name = genre.Name;

            await repository.SaveChangesAsync();
            logger.LogInformation(MessagesConstants.EntityEditedMessage,nameof(Genre),genreId);
        }
        public async Task DeleteAsync(int genreId)
        {
            await repository.DeleteAsync<Genre>(genreId);
            await repository.SaveChangesAsync();
            logger.LogInformation(MessagesConstants.EntityDeleteMessage,nameof(Genre),genreId);
        }
    }
}
