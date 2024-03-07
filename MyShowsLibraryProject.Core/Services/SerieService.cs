using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Models.SerieModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class SerieService : ISerieService
    {
        private readonly IRepository repository;

        public SerieService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<SeriesCardInfoServiceModel>> GetAllReadonlyAsync()
            => await repository
            .TakeAllReadOnly<Serie>()
            .Select(s => new SeriesCardInfoServiceModel()
            {
                Title = s.Title,
                PosterUrl = s.PosterUrl,
                //Later when you add review try make method and add null check not implemented yet
                Rating = repository
                        .TakeAll<SerieReview>()
                        .Where(sr => sr.SerieId == s.SeriesId)
                        .Average(sr => sr.Review.Rating)
                        .ToString()
            })
            .ToListAsync();
    }
}
