using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Models.SerieModels;
using MyShowsLibraryProject.Core.Services;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Test
{
    [TestFixture]
    public class SerieServiceTest
    {
        private ISerieService serieService;
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
            serieService = new SerieService(repository);
        }

        [Test]
        public async Task SerieGetAllReadonlyAsyncTest()
        {
            var serie = await serieService.GetAllReadonlyAsync();

            Assert.That(serie.Count(), Is.EqualTo(1), "GetAllReadonlyAsync method did not return expected results!");
        }
        [Test]
        public async Task SerieCreateAsyncTest()
        {
            await serieService.CreateAsync(DatabaseConstants.CreateSerieModel());

            var repositoryCount = repository.TakeAll<Serie>().Count();

            Assert.That(repositoryCount, Is.EqualTo(2), "Serie was not created succesfully!");
        }
        [Test]
        public async Task SerieGetAllCardInfoAsyncTestWithoutSorting()
        {
            var testQuery = new SerieQueryModel();

            var query = await serieService.GetAllCardInfoAsync(
                testQuery.SearchTerm,
                testQuery.Sorting,
                testQuery.CurrentPage,
                testQuery.SeriePerPage);

            Assert.That(query.Serie.Count(), Is.EqualTo(1), "GetAllCardInfoAsync method did not return expected results!");
        }
        [Test]
        public async Task SerieGetAllCardInfoAsyncTestWithtSorting()
        {
            var testQuery = new SerieQueryModel();

            testQuery.SearchTerm = "friends";

            var query = await serieService.GetAllCardInfoAsync(
                testQuery.SearchTerm,
                testQuery.Sorting,
                testQuery.CurrentPage,
                testQuery.SeriePerPage);

            Assert.That(query.Serie.Count(), Is.EqualTo(0), "GetAllCardInfoAsync method did not return expected results!");
        }
        //Place test for alphabeticaly and nonalphabeticaly when seed more data
        [Test]
        public async Task IsSeriePresentTest()
        {
            var serieId = 1;

            var result = await serieService.IsSeriePresent(serieId);

            Assert.IsTrue(result, "IsSeriePresent method did not return expected results!");
        }
        [Test]
        public async Task IsSeriePresentTestReturnFalse()
        {
            var serieId = 5;

            var result = await serieService.IsSeriePresent(serieId);

            Assert.IsFalse(result, "IsSeriePresent method did not return expected results!");
        }
        [Test]
        public async Task SerieEditAsyncTest()
        {
            var serieId = 1;
            var serieToEdit = DatabaseConstants.SerieForEdit();

            await serieService.EditAsync(serieId, serieToEdit);

            var editedSerie = await repository.GetByIdAsync<Serie>(serieId);

            Assert.That(editedSerie.Title, Is.EqualTo(serieToEdit.Title), "EditAsync method did not return expected results!");
        }
        [Test]
        public void SerieEditAsyncIfMovieNullTest()
        {
            var serieId = 4;
            var serieToEdit = DatabaseConstants.SerieForEdit();

            Assert.ThrowsAsync<NullReferenceException>(async () => await serieService.EditAsync(serieId, serieToEdit), "Serie you want to edit does not exists!");
        }
        [Test]
        public async Task SerieDeleteAsyncTest()
        {
            var serieId = 1;

            await serieService.DeleteAsync(serieId);

            var serie = await repository.GetByIdAsync<Serie>(serieId);

            Assert.IsNull(serie, "DeleteAsync dont delete what was expected!");
        }
        [Test]
        public async Task SerieIsNullDeleteAsyncTest()
        {
            var serieId = 5;

            await serieService.DeleteAsync(serieId);

            var count = repository.TakeAll<Serie>().Count();

            Assert.That(count, Is.EqualTo(1), "DeleteAsync delete unexpected record!");
        }


        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }
    }
}