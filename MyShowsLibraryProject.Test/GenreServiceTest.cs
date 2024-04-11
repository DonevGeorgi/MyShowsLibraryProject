using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Services;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Test
{
    [TestFixture]
    public class GenreServiceTest
    {
        private IGenreService genreService;
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
            genreService = new GenreService(repository);
        }

        [Test]
        public async Task GenreGetAllReadonlyAsyncTest()
        {
            var genre = await genreService.GetAllReadonlyAsync();

            Assert.That(genre.Count(), Is.EqualTo(11), "GetAllReadonlyAsync method did not return expected results!");
        }
        [Test]
        public async Task GetGenreByIdTest()
        {
            var genreId = 3;

            var genre = await genreService.GetGenreById(genreId);

            Assert.That(genre.GenreId,Is.EqualTo(genreId), "GetGenreById method did not return expected results!");
        }
        [Test]
        public void GetGenreByIdIfGenreIsNullTest()
        {
            var genreId = 63;

            Assert.ThrowsAsync<NullReferenceException>(async () => await genreService.GetGenreById(genreId), "Genre does not exist!");
        }
        [Test]
        public async Task GenreCreateAsyncTest()
        {
            var genre = DatabaseConstants.GenreForEditAndCreate();

            await genreService.CreateAsync(genre);

            var repositoryCount = repository.TakeAll<Genre>().Count();

            Assert.That(repositoryCount,Is.EqualTo(12), "Genre was not created succesfully!");
        }
        [Test]
        public async Task GenreEditAsyncTest()
        {
            var genreId = 3;

            var genre = DatabaseConstants.GenreForEditAndCreate();

            await genreService.EditAsync(genreId,genre);

            var editedModel = await genreService.GetGenreById(genreId);

            Assert.That(editedModel.Name,Is.EqualTo(genre.Name), "EditAsync method did not return expected results!");
        }
        [Test]
        public void NullGenreEditAsyncTest()
        {
            var genreId = 333;

            var genre = DatabaseConstants.GenreForEditAndCreate();

            Assert.ThrowsAsync<NullReferenceException>(async () => await genreService.EditAsync(genreId,genre), "Genre to edit dont exist!");
        }
        [Test]
        public async Task GenreDeleteAsyncTest()
        {
            var genreId = 3;

            await genreService.DeleteAsync(genreId);

            var genre = await repository.GetByIdAsync<Genre>(genreId);

            Assert.IsNull(genre, "DeleteAsync dont delete what was expected!");
        }
        [Test]
        public async Task GenreIsNullDeleteAsyncTest()
        {
            var genreId = 333;

            await genreService.DeleteAsync(genreId);

            var count = repository.TakeAll<Genre>().Count();

            Assert.That(count, Is.EqualTo(11), "DeleteAsync delete unexpected record!");
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }
    }
}
