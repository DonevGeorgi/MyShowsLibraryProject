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
                    Name = g.Name
                })
                .ToListAsync();

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

    }
}