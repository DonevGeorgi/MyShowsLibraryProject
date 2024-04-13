using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Core.Services;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data;

namespace MyShowsLibraryProject.Test
{
    [TestFixture]
    public class CrewSerieServiceTest
    {
        private ICrewSerieService crewSerieService;
        private IRepository repository;
        private ICrewService crewService;
        private ISerieService serieService;
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
            serieService = new SerieService(repository);
            crewSerieService = new CrewSerieService(repository, crewService, serieService);
        }

        [Test]
        public async Task GetCrewName()
        {
            var crewName = "Kit Harington";

            var crewId = await crewSerieService.GetCrewName(crewName);

            Assert.That(crewId, Is.EqualTo(4), "GetCrewName method did not return expected results!");
        }
        [Test]
        public void GetCrewNullName()
        {
            var crewName = "Donald Trump";

            Assert.ThrowsAsync<NullReferenceException>(async () => await crewSerieService.GetCrewName(crewName), "Crew with this name does not exists!");
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }
    }
}
