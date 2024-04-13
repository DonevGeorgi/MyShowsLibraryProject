using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Core.Services;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data;
using MyShowsLibraryProject.Infrastructure.Data.Models;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;

namespace MyShowsLibraryProject.Test
{
    [TestFixture]
    public class SeasonServiceTest
    {
        private ISeasonService seasonService;
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
            seasonService = new SeasonService(repository);
        }

        [Test]
        public async Task GetAllSeasonForSeriesTest()
        {
            var serieId = 1;

            var seasons = await seasonService.GetAllSeasonForSeries(serieId);

            Assert.That(seasons.Count(), Is.EqualTo(4), "GetAllSeasonForSeries method did not return expected results!");
        }
        [Test]
        public async Task GetSeasonDetailsAsyncTest()
        {
            var serieId = 1;

            var seasons = await seasonService.GetSeasonDetailsAsync(serieId);

            Assert.That(seasons.Count(), Is.EqualTo(4), "GetSeasonDetailsAsync method did not return expected results!");
        }
        [Test]
        public async Task GetSeasonDetailsById()
        {
            var seasonId = 1;

            var season = await seasonService.GetSeasonDetailsById(seasonId);

            Assert.That(season.SeasonId, Is.EqualTo(seasonId), "GetSeasonDetailsById method did not return expected results!");
        }
        [Test]
        public void GetSeasonDetailsByIdIfNull()
        {
            var seasonId = 12;

            Assert.ThrowsAsync<NullReferenceException>(async () => await seasonService.GetSeasonDetailsById(seasonId), "Season does not exists!");
        }
        [Test]
        public async Task SeasonCreateAsyncTest()
        {
            var serieId = 1;

            await seasonService.CreateAsync(DatabaseConstants.CreateSeasonModel(), serieId);

            var repositoryCount = repository.TakeAll<Season>().Count();

            Assert.That(repositoryCount, Is.EqualTo(9), "Season was not created succesfully!");
        }
        [Test]
        public void NullSeasonCreateAsyncTest()
        {
            var serieId = 33;

            Assert.ThrowsAsync<NullReferenceException>(async () => await seasonService.CreateAsync(DatabaseConstants.CreateSeasonModel(),serieId), "Serie does not exists!");
        }
        [Test]
        public async Task SeasonEditAsyncTest()
        {
            var seasonId = 1;
            var seasonToEdit = DatabaseConstants.SeasonForEdit();

            await seasonService.EditAsync(seasonId, seasonToEdit);

            var editedSeason = await repository.GetByIdAsync<Season>(seasonId);

            Assert.That(editedSeason.YearOfRelease, Is.EqualTo(seasonToEdit.YearOfRelease), "EditAsync method did not return expected results!");
        }
        [Test]
        public void NullSeasonEditAsyncTest()
        {
            var serieId = 33;

            Assert.ThrowsAsync<NullReferenceException>(async () => await seasonService.EditAsync(serieId, DatabaseConstants.SeasonForEdit()), "Season does not exists!");
        }
        [Test]
        public async Task SeasonDeleteAsyncTest()
        {
            var seasonId = 1;

            await seasonService.DeleteAsync(seasonId);

            var movie = await repository.GetByIdAsync<Season>(seasonId);

            Assert.IsNull(movie, "DeleteAsync dont delete what was expected!");
        }
        [Test]
        public async Task SeasonIsNullDeleteAsyncTest()
        {
            var seasonId = 12;

            await seasonService.DeleteAsync(seasonId);

            var count = repository.TakeAll<Season>().Count();

            Assert.That(count, Is.EqualTo(8), "DeleteAsync delete unexpected record!");
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }
    }
}
