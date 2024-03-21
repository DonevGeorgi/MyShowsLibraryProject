using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Models.CrewModels;
using MyShowsLibraryProject.Core.Models.GenreModels;
using MyShowsLibraryProject.Core.Models.MovieModels;
using MyShowsLibraryProject.Core.Models.ReviewModels;
using MyShowsLibraryProject.Core.Models.RolesModels;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Core.Services
{
    public class MovieService : IMovieService
    {
        private readonly IRepository repository;

        public MovieService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<MoviesCardInfoServiceModel>> GetAllReadonlyAsync()
            => await repository
            .TakeAllReadOnly<Movie>()
            .Select(m => new MoviesCardInfoServiceModel()
            {
                MovieId = m.MovieId,
                Title = m.Title,
                PosterUrl = m.PosterUrl,
                YearOfRelease = m.DateOfRelease,
                //Later when you add review try make method and add null check not implemented yet
                Rating = repository
                        .TakeAll<MovieReview>()
                        .Where(r => r.MovieId == m.MovieId)
                        .Average(mr => mr.Review.Rating)
                        .ToString()
            })
            .ToListAsync();
        public async Task<MoviesDetailsServiceModel> GetMovieDetailsByIdAsync(int movieId)
        {
            var movie = await repository
             .TakeAllReadOnly<Movie>()
             .Where(m => m.MovieId == movieId)
             .Select(m => new MoviesDetailsServiceModel()
             {
                 MovieId = m.MovieId,
                 Title = m.Title,
                 Duration = m.Duration.ToString(),
                 PosterUrl = m.PosterUrl,
                 TrailerUrl = m.TrailerUrl,
                 DateOfRelease = m.DateOfRelease,
                 Summary = m.Summary,
                 OriginalAudioLanguage = m.OriginalAudioLanguage,
                 ForMoreSummaryUrl = m.ForMoreSummaryUrl,
                 Genres = repository
                     .TakeAllReadOnly<MovieGenre>()
                     .Where(mg => mg.MovieId == movieId)
                     .Select(mg => new GenreInfoSeviceModel()
                     {
                         Name = mg.Genre.Name
                     })
                     .ToList(),
                 Crews = repository
                     .TakeAllReadOnly<MovieCrew>()
                     .Where(mr => mr.MovieId == movieId)
                     .Select(mr => new CrewInfoServiceModel
                     {
                         CrewId = mr.CrewId,
                         Name = mr.Crew.Name,
                         PictureUrl = mr.Crew.PictureUrl,
                         Roles = repository
                         .TakeAllReadOnly<CrewRole>()
                         .Where(cr => cr.CrewId == mr.CrewId)
                         .Select(r => new RoleInfoServiceModel
                         {
                             Name = r.Role.Name
                         })
                         .ToList()
                     })
                     .ToList(),
                 Reviews = repository
                    .TakeAllReadOnly<MovieReview>()
                    .Where(r => r.MovieId == movieId)
                    .Select(r => new ReviewInfoServiceModel
                    {
                        Rating = r.Review.Rating.ToString(),
                        Content = r.Review.Content,
                        UserUsername = repository
                        .TakeAllReadOnly<UserReview>()
                        .Where(ur => ur.ReviewId == r.ReviewId)
                        .Select(ur => ur.User.UserName)
                        .First()
                    })
                    .ToList()
             })
            .FirstAsync();

            return movie;
        }
        public async Task<bool> IsMoviePresent(int movieId)
        {
            var result = await repository.GetByIdAsync<Movie>(movieId);

            if (result == null)
            {
                return false;
            }

            return true;
        }
    }
}
