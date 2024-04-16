using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Core.Services;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Test
{
    [TestFixture]
    public class HomeServiceTest
    {
        private IHomeService homeService;
        private IRepository repository;
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
            homeService = new HomeService(repository);
        }

        [Test]
        public async Task GetHighestRatedLastAddedMoviesTest()
        {
            var expectedTitle = "Back to the Future";

            var movie = await homeService.GetHighestRatedLastAddedMovies();

            Assert.That(movie.Title, Is.EqualTo(expectedTitle), "GetHighestRatedLastAddedMovies method did not return expected results!");
        }

        [Test]
        public async Task GetHighestRatedLastAddedSeriesTest()
        {
            var expectedTitle = "Game of Thrones";

            var serie = await homeService.GetHighestRatedLastAddedSeries();

            Assert.That(serie.Title, Is.EqualTo(expectedTitle), "GetHighestRatedLastAddedSeries method did not return expected results!");
        }

        [Test]
        public async Task GetLastAddedMoviesTest()
        {
            var movies = await homeService.GetLastAddedMovies();

            Assert.That(movies.Count(), Is.EqualTo(4), "GetLastAddedMovies method did not return expected results!");
        }
        [Test]
        public async Task GetLastAddedSeriesTest()
        {
            var series = await homeService.GetLastAddedSeries();

            Assert.That(series.Count(), Is.EqualTo(4), "GetLastAddedSeries method did not return expected results!");
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }
    }
}
