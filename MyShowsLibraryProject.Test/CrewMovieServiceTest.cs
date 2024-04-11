using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Core.Services;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data;

namespace MyShowsLibraryProject.Test
{
    [TestFixture]
    public class CrewMovieServiceTest
    {
        private ICrewMovieService crewMovieService;
        private IRepository repository;
        private IMovieService movieService;
        private ICrewService crewService;
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
            movieService = new MovieService(repository);
            crewMovieService = new CrewMovieService(repository, movieService, crewService);
        }

        [Test]
        public async Task GetCrewName()
        {
            var crewName = "Michael J. Fox";

            var crewId = await crewMovieService.GetCrewName(crewName);

            Assert.That(crewId,Is.EqualTo(3), "GetCrewName method did not return expected results!");
        }
        [Test]
        public void GetCrewNullName()
        {
            var crewName = "Joe Biden";

            Assert.ThrowsAsync<ArgumentException>(async () => await crewMovieService.GetCrewName(crewName), "Crew with this name does not exists!");
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }
    }
}
