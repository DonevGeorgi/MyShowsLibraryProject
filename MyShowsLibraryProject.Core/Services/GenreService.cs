using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Models.GenreModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;
using System.Runtime.InteropServices;

namespace MyShowsLibraryProject.Core.Services
{
    public class GenreService : IGenreService
    {
        private readonly IRepository repository;
        
        public GenreService(IRepository _repository) 
        {
            repository = _repository;
        }

        public async Task<IEnumerable<GenreInfoSeviceModel>> GetAllReadonlyAsync()
        {
            var genres = await repository
                .TakeAllReadOnly<Genre>()
                .Select(g => new GenreInfoSeviceModel
                {
                    Name = g.Name
                })
                .ToListAsync();

            return genres;
        }
        public async Task<int> GetGenreIdFromName(string name)
        {
            var genreId = await repository
                .TakeAllReadOnly<Genre>()
                .Where(g => g.Name == name)
                .FirstOrDefaultAsync();

            if (genreId == null)
            {
                return 0;
            }

            return genreId.GenreId;
        }
        public async Task CreateAsync(GenreFormModel genre)
        {
            var newGenre = new Genre()
            {
                Name = genre.Name
            };

            await repository.AddAsync(newGenre);
            await repository.SaveChangesAsync();
        }
    }
}
