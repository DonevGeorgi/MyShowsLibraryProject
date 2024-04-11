using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Models.MovieModels;
using MyShowsLibraryProject.Core.Services;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Test
{
    [TestFixture]
    public class MovieServiceTest
    {
        private IMovieService movieService;
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
            movieService = new MovieService(repository);
        }

        [Test]
        public async Task MovieGetAllReadonlyAsyncTest()
        {
            var movies = await movieService.GetAllReadonlyAsync();

            Assert.That(movies.Count(),Is.EqualTo(1), "GetAllReadonlyAsync method did not return expected results!");
        }
        [Test]
        public async Task MovieCreateAsyncTest()
        {
            await movieService.CreateAsync(DatabaseConstants.CreateMovieModel());

            var repositoryCount = repository.TakeAll<Movie>().Count();

            Assert.That(repositoryCount, Is.EqualTo(2), "Movie was not created succesfully!");
        }
        [Test]
        public async Task MovieGetAllCardInfoAsyncTestWithoutSorting()
        {
            var testQuery = new MoviesQueryModel();

            var query = await movieService.GetAllCardInfoAsync(
                testQuery.SearchTerm,
                testQuery.Sorting,
                testQuery.CurrentPage,
                testQuery.MoviePerPage);

            Assert.That(query.Movies.Count(),Is.EqualTo(1), "GetAllCardInfoAsync method did not return expected results!");
        }
        [Test]
        public async Task MovieGetAllCardInfoAsyncTestWithtSorting()
        {
            var testQuery = new MoviesQueryModel();

            testQuery.SearchTerm = "star wars";

            var query = await movieService.GetAllCardInfoAsync(
                testQuery.SearchTerm,
                testQuery.Sorting,
                testQuery.CurrentPage,
                testQuery.MoviePerPage);

            Assert.That(query.Movies.Count(), Is.EqualTo(0), "GetAllCardInfoAsync method did not return expected results!");
        }
        //Place test for alphabeticaly and nonalphabeticaly when seed more data
        [Test]
        public async Task IsMoviePresentTest()
        {
            var movieId = 1;

            var result = await movieService.IsMoviePresent(movieId);

            Assert.IsTrue(result, "IsMoviePresent method did not return expected results!");
        }
        [Test]
        public async Task IsMoviePresentTestReturnFalse()
        {
            var movieId = 5;

            var result = await movieService.IsMoviePresent(movieId);

            Assert.IsFalse(result, "IsMoviePresent method did not return expected results!");
        }
        [Test]
        public async Task MovieEditAsyncTest()
        {
            var movieId = 1;
            var movieToEdit = DatabaseConstants.MovieForEdit();

            await movieService.EditAsync(movieId, movieToEdit);

            var editedMovie = await repository.GetByIdAsync<Movie>(movieId);

            Assert.That(editedMovie.Title, Is.EqualTo(movieToEdit.Title), "EditAsync method did not return expected results!");
        }
        [Test]
        public void MovieEditAsyncIfMovieNullTest()
        {
            var movieId = 4;
            var movieToEdit = DatabaseConstants.MovieForEdit();

            Assert.ThrowsAsync<NullReferenceException>(async () => await movieService.EditAsync(movieId, movieToEdit), "Movie you want to edit does not exists!");
        }
        [Test]
        public async Task MovieDeleteAsyncTest()
        {
            var movieId = 1;

            await movieService.DeleteAsync(movieId);

            var movie = await repository.GetByIdAsync<Movie>(movieId);

            Assert.IsNull(movie, "DeleteAsync dont delete what was expected!");
        }
        [Test]
        public async Task MovieIsNullDeleteAsyncTest()
        {
            var movieId = 5;

            await movieService.DeleteAsync(movieId);

            var count = repository.TakeAll<Movie>().Count();

            Assert.That(count,Is.EqualTo(1), "DeleteAsync delete unexpected record!");
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }
    }
}