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
    public class CrewServiceTest
    {
        private ICrewService crewService;
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

            crewService = new CrewService(repository);
        }

        [Test]
        public async Task CrewGetAllReadonlyAsyncTest()
        {
            var crew = await crewService.GetAllReadonlyAsync();

            Assert.That(crew.Count(), Is.EqualTo(6), "GetAllReadonlyAsync method did not return expected results!");
        }
        [Test]
        public async Task CrewGetCrewNameTest()
        {
            var crewName = "Kit Harington";

            var crewId = await crewService.GetCrewName(crewName);

            Assert.That(crewId, Is.EqualTo(4), "GetCrewName method did not return expected results!");
        }
        [Test]
        public async Task CrewCreateAsyncTest()
        {
            await crewService.CreateAsync(DatabaseConstants.CreateCrewModel());

            var repositoryCount = repository.TakeAll<Crew>().Count();

            Assert.That(repositoryCount,Is.EqualTo(7), "Crew was not created succesfully!");
        }
        [Test]
        public void IsCrewIsNullCreateAsyncTest()
        {
            Assert.ThrowsAsync<ArgumentException>(async () => await crewService.CreateAsync(DatabaseConstants.CreateNullCrewModel()), "Crew with this name already exists!");
        }
        [Test]
        public async Task CrewEditAsyncTest()
        {
            int crewId = 4;
            var crewToEdit = DatabaseConstants.CrewForEdit();

            await crewService.EditAsync(crewId,crewToEdit);

            var editedCrew = await crewService.GetCrewDetailsById(crewId);

            Assert.That(crewToEdit.Name,Is.EqualTo(editedCrew.Name), "EditAsync method did not return expected results!");
        }
        [Test]
        public void CrewEditAsyncIfMovieNullTest()
        {
            var crewId = 21;
            var crewToEdit = DatabaseConstants.CrewForEdit();

            Assert.ThrowsAsync<ArgumentNullException>(async () => await crewService.EditAsync(crewId, crewToEdit), "Crew does not exists!");
        }
        [Test]
        public async Task CrewDeleteAsyncTest()
        {
            var crewId = 4;

            await crewService.DeleteAsync(crewId);

            var movie = await repository.GetByIdAsync<Crew>(crewId);

            Assert.IsNull(movie, "DeleteAsync dont delete what was expected!");
        }
        [Test]
        public async Task CrewIsNullDeleteAsyncTest()
        {
            var crewId = 26;

            await crewService.DeleteAsync(crewId);

            var count = repository.TakeAll<Crew>().Count();

            Assert.That(count, Is.EqualTo(6), "DeleteAsync delete unexpected record!");
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }
    }
}
