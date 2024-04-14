using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using MyShowsLibraryProject.Core.Services;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data;
using MyShowsLibraryProject.Infrastructure.Data.Common;

namespace MyShowsLibraryProject.Test
{
    [TestFixture]
    public class MovieGenreServiceTest
    {
        private IMovieGenreService movieGenreService;
        private IRepository repository;
        private IMovieService movieService;
        private IGenreService genreService;
        private SqliteConnection connection;
        private ApplicationDbContext dbContext;

        [SetUp]
        public void Setup()
        {
            var mockLogger = new Mock<ILogger<MovieGenreService>>();
            var mockGenreLogger = new Mock<ILogger<GenreService>>();
            var mockMovieLogger = new Mock<ILogger<MovieService>>();

            connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite(connection);
            dbContext = new ApplicationDbContext(options.Options);

            dbContext.Database.EnsureCreated();

            repository = new Repository(dbContext);
            movieService = new MovieService(mockMovieLogger.Object, repository);
            genreService = new GenreService(mockGenreLogger.Object, repository);
            movieGenreService = new MovieGenreService(mockLogger.Object, repository, movieService,genreService);
        }

        [Test]
        public async Task TakeAllGenresTest()
        {
            var genres = await movieGenreService.TakeAllGenres();

            Assert.That(genres.Count(),Is.EqualTo(11), "TakeAllGenres method did not return expected results!");
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }
    }
}
