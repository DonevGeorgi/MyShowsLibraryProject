﻿using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Models.GenreModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

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

            if (genres == null)
            {
                throw new NullReferenceException("Genre does not exist!");
            }

            return genres;
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
        public async Task EditAsync(int genreId, GenreFormModel genre)
        {
            var genreToEdit = await repository.GetByIdAsync<Genre>(genreId);

            if (genreToEdit == null)
            {
                throw new NullReferenceException("Genre to edit dont exist!");
            }

            genreToEdit.Name = genre.Name;

            await repository.SaveChangesAsync();
        }
        public async Task DeleteAsync(int genreId)
        {
            await repository.DeleteAsync<Genre>(genreId);
            await repository.SaveChangesAsync();
        }
    }
}
