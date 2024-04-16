using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Models.MovieModels;
using MyShowsLibraryProject.Core.Models.SerieModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class HomeService : IHomeService
    {
        public readonly IRepository repository;

        public HomeService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<MoviesCardInfoServiceModel> GetHighestRatedLastAddedMovies()
        {
            var movie = await repository
               .TakeAllReadOnly<Movie>()
               .Select(m => new MoviesCardInfoServiceModel()
               {
                   MovieId = m.MovieId,
                   Title = m.Title,
                   YearOfRelease = m.DateOfRelease,
                   PosterUrl = m.PosterUrl,
                   Rating = Math.Round(((double)repository
                        .TakeAll<MovieReview>()
                        .Where(r => r.MovieId == m.MovieId)
                        .Average(mr => mr.Review.Rating)), 2)
                        .ToString()
               })
               .OrderByDescending(m => m.Rating)
               .Take(1)
               .FirstOrDefaultAsync();

            return movie;
        }
        public async Task<SeriesCardInfoServiceModel> GetHighestRatedLastAddedSeries()
        {
            var serie = await repository
               .TakeAllReadOnly<Serie>()
               .Select(s => new SeriesCardInfoServiceModel()
               {
                   SerieId = s.SeriesId,
                   Title = s.Title,
                   PosterUrl = s.PosterUrl,
                   StartYear = s.YearOfStart,
                   EndYear = s.YearOfEnd,
                   Rating = Math.Round(((double)repository
                        .TakeAll<SerieReview>()
                        .Where(r => r.SerieId == s.SeriesId)
                        .Average(mr => mr.Review.Rating)), 2)
                        .ToString()
               })
               .OrderByDescending(s => s.Rating)
               .Take(1)
               .FirstOrDefaultAsync();

            return serie;
        }
        public async Task<IEnumerable<MoviesCardInfoServiceModel>> GetLastAddedMovies()
        {
            var movies = await repository
               .TakeAllReadOnly<Movie>()
               .OrderByDescending(m => m.MovieId)
               .Take(4)
               .Select(m => new MoviesCardInfoServiceModel()
               {
                   MovieId = m.MovieId,
                   Title = m.Title,
                   YearOfRelease = m.DateOfRelease,
                   PosterUrl = m.PosterUrl,
                   Rating = Math.Round(((double)repository
                        .TakeAll<MovieReview>()
                        .Where(r => r.MovieId == m.MovieId)
                        .Average(mr => mr.Review.Rating)), 2)
                        .ToString()
               })
               .ToListAsync();

            return movies;
        }
        public async Task<IEnumerable<SeriesCardInfoServiceModel>> GetLastAddedSeries()
        {
            var series = await repository
               .TakeAllReadOnly<Serie>()
               .OrderByDescending(s => s.SeriesId)
               .Take(4)
               .Select(s => new SeriesCardInfoServiceModel()
               {
                   SerieId = s.SeriesId,
                   Title = s.Title,
                   PosterUrl = s.PosterUrl,
                   StartYear = s.YearOfStart,
                   EndYear = s.YearOfEnd,
                   Rating = Math.Round(((double)repository
                        .TakeAll<SerieReview>()
                        .Where(r => r.SerieId == s.SeriesId)
                        .Average(mr => mr.Review.Rating)), 2)
                        .ToString()
               })
               .ToListAsync();

            return series;
        }
    }
}
