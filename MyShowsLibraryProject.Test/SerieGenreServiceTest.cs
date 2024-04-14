using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Core.Services;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data;
using Microsoft.Extensions.Logging;

namespace MyShowsLibraryProject.Test
{
    [TestFixture]
    public class SerieGenreServiceTest
    {
        private ILogger<SerieGenreService> logger;
        private ILogger<GenreService> loggerGenre;
        private ILogger<SerieService> loggerSerie;
        private ISerieGenreService serieGenreService;
        private IRepository repository;
        private ISerieService serieService;
        private IGenreService genreService;
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
            serieService = new SerieService(loggerSerie,repository);
            genreService = new GenreService(loggerGenre,repository);
            serieGenreService = new SerieGenreService(logger, repository, serieService, genreService);
        }

        [Test]
        public async Task TakeAllGenresTest()
        {
            var genres = await serieGenreService.TakeAllGenres();

            Assert.That(genres.Count(), Is.EqualTo(11), "TakeAllGenres method did not return expected results!");
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }
    }
}
