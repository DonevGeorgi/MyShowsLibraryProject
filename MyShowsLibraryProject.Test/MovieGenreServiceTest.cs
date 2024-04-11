using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
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
            connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite(connection);
            dbContext = new ApplicationDbContext(options.Options);

            dbContext.Database.EnsureCreated();

            repository = new Repository(dbContext);
            movieService = new MovieService(repository);
            genreService = new GenreService(repository);
            movieGenreService = new MovieGenreService(repository,movieService,genreService);
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
