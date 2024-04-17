using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Core.Services;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data;
using MyShowsLibraryProject.Infrastructure.Data.Models;
using MyShowsLibraryProject.Core.Constants;

namespace MyShowsLibraryProject.Test
{
    [TestFixture]
    public class UserServiceTest
    {
        private IUserService userService;
        private IRepository repository;
        private SqliteConnection connection;
        private ApplicationDbContext dbContext;

        [SetUp]
        public void Setup()
        {
            var mockLogger = new Mock<ILogger<UserService>>();

            connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite(connection);
            dbContext = new ApplicationDbContext(options.Options);

            dbContext.Database.EnsureCreated();

            repository = new Repository(dbContext);
            userService = new UserService(mockLogger.Object, repository);
        }

        [Test]
        public async Task MovieCreateAsyncTest()
        {
            var userId = "8e656345-a56d-4543-a7c6-4556d32d4db2";
            var movieId = 1;

            await userService.AddMovieToWatchLater(movieId, userId);

            var repositoryCount = repository.TakeAll<UserMovie>().Count();

            Assert.That(repositoryCount, Is.EqualTo(1), "Movie was not created succesfully!");
        }
        [Test]
        public async Task IfMovieIsNullCreateAsyncTest()
        {
            var userId = "8e656345-a56d-4543-a7c6-4556d32d4db2";
            var movieId = 22;

            Assert.ThrowsAsync<NullReferenceException>(async () => await userService.AddMovieToWatchLater(movieId, userId), MessagesConstants.MovieDoesNotExistsMessage);
        }
        [Test]
        public async Task IsMoviePrezentTest()
        {
            var movieId = 1;
            var userId = "8e656345-a56d-4543-a7c6-4556d32d4db2";

            var result = await userService.IsMovieAvailable(movieId, userId);

            Assert.IsTrue(result, "IsMoviePresent method did not return expected results!");
        }
        [Test]
        public async Task SerieCreateAsyncTest()
        {
            var userId = "8e656345-a56d-4543-a7c6-4556d32d4db2";
            var serieId = 1;

            await userService.AddSerieToWatchLater(serieId, userId);

            var repositoryCount = repository.TakeAll<UserSerie>().Count();

            Assert.That(repositoryCount, Is.EqualTo(1), "Serie was not created succesfully!");
        }
        [Test]
        public async Task IfSerieIsNullCreateAsyncTest()
        {
            var userId = "8e656345-a56d-4543-a7c6-4556d32d4db2";
            var serieId = 22;

            Assert.ThrowsAsync<NullReferenceException>(async () => await userService.AddMovieToWatchLater(serieId, userId), MessagesConstants.SerieDoesNotExistsMessage);
        }
        [Test]
        public async Task IsSeriePrezentTest()
        {
            var serieId = 1;
            var userId = "8e656345-a56d-4543-a7c6-4556d32d4db2";

            var result = await userService.IsSerieAvailable(serieId, userId);

            Assert.IsTrue(result, "IsSerieAvailable method did not return expected results!");
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }
    }
}
