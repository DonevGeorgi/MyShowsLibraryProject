using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Core.Enumeration;
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
            var mockLogger = new Mock<ILogger<SerieService>>();

            connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite(connection);
            dbContext = new ApplicationDbContext(options.Options);

            dbContext.Database.EnsureCreated();

            repository = new Repository(dbContext);
            serieService = new SerieService(mockLogger.Object, repository);
        }

        [Test]
        public async Task SerieGetAllReadonlyAsyncTest()
        {
            var serie = await serieService.GetAllReadonlyAsync();

            Assert.That(serie.Count(), Is.EqualTo(12), "GetAllReadonlyAsync method did not return expected results!");
        }
        [Test]
        public async Task SerieCreateAsyncTest()
        {
            await serieService.CreateAsync(DatabaseConstants.CreateSerieModel());

            var repositoryCount = repository.TakeAll<Serie>().Count();

            Assert.That(repositoryCount, Is.EqualTo(13), "Serie was not created succesfully!");
        }
        [Test]
        public async Task SerieGetAllInPagingCardInfoAsyncTestWithoutSorting()
        {
            var testQuery = new SerieQueryModel();

            var query = await serieService.GetAllCardInfoAsync(
                testQuery.SearchTerm,
                testQuery.Sorting,
                testQuery.CurrentPage,
                testQuery.ItemsPerPage);

            Assert.That(query.Serie.Count(), Is.EqualTo(4), "GetAllCardInfoAsync method did not return expected results!");
        }
        [Test]
        public async Task SerieGetAllCardInfoAsyncTestWithoutSorting()
        {
            var testQuery = new SerieQueryModel();

            var query = await serieService.GetAllCardInfoAsync(
                testQuery.SearchTerm,
                testQuery.Sorting,
                testQuery.CurrentPage,
                testQuery.ItemsPerPage);

            Assert.That(query.TotalSerieCount, Is.EqualTo(12), "GetAllCardInfoAsync method did not return expected results!");
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
                testQuery.ItemsPerPage);

            Assert.That(query.Serie.Count(), Is.EqualTo(0), "GetAllCardInfoAsync method did not return expected results!");
        }
        [Test]
        public async Task SerieGetAllCardInfoAsyncSortingFromA()
        {
            var testQuery = new SerieQueryModel();

            testQuery.Sorting = BaseSorting.FromA;

            var query = await serieService.GetAllCardInfoAsync(
                testQuery.SearchTerm,
                testQuery.Sorting,
                testQuery.CurrentPage,
                testQuery.ItemsPerPage);

            var result = query.Serie.Take(1).Any(t => t.Title == "3 Body Problem");

            Assert.IsTrue(result, "Sorting did not return expected results!");
        }
        [Test]
        public async Task SerieGetAllCardInfoAsyncSortingToA()
        {
            var testQuery = new SerieQueryModel();

            testQuery.Sorting = BaseSorting.ToA;

            var query = await serieService.GetAllCardInfoAsync(
                testQuery.SearchTerm,
                testQuery.Sorting,
                testQuery.CurrentPage,
                testQuery.ItemsPerPage);

            var result = query.Serie.Take(1).Any(t => t.Title == "Westworld");

            Assert.IsTrue(result, "Sorting did not return expected results!");
        }
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
            var serieId = 15;

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
            var serieId = 14;
            var serieToEdit = DatabaseConstants.SerieForEdit();

            Assert.ThrowsAsync<NullReferenceException>(async () => await serieService.EditAsync(serieId, serieToEdit), MessagesConstants.SerieEditDoesNotExistMessage);
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
            var serieId = 15;

            await serieService.DeleteAsync(serieId);

            var count = repository.TakeAll<Serie>().Count();

            Assert.That(count, Is.EqualTo(12), "DeleteAsync delete unexpected record!");
        }


        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }
    }
}