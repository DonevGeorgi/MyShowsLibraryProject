using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using MyShowsLibraryProject.Core.Constants;
using MyShowsLibraryProject.Core.Services;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Test
{
    [TestFixture]
    public class EpisodeServiceTest
    {
        private IEpisodeService episodeService;
        private ISeasonService seasonService;
        private IRepository repository;
        private SqliteConnection connection;
        private ApplicationDbContext dbContext;

        [SetUp]
        public void Setup()
        {
            var mockLogger = new Mock<ILogger<EpisodeService>>();
            var mockSeasonLogger = new Mock<ILogger<SeasonService>>();

            connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite(connection);
            dbContext = new ApplicationDbContext(options.Options);

            dbContext.Database.EnsureCreated();

            repository = new Repository(dbContext);
            seasonService = new SeasonService(mockSeasonLogger.Object, repository);
            episodeService = new EpisodeService(mockLogger.Object, repository, seasonService);
        }

        [Test]
        public async Task GetEpisodeForSeasonTest()
        {
            var seasonId = 1;

            var episodes = await episodeService.GetEpisodeForSeason(seasonId);

            Assert.That(episodes.Count(), Is.EqualTo(10), "GetEpisodeForSeason method did not return expected results!");
        }
        [Test]
        public async Task GetEpisodeDetailsAsync()
        {
            var seasonId = 1;

            var episodes = await episodeService.GetEpisodeDetailsAsync(seasonId);

            Assert.That(episodes.Count(), Is.EqualTo(10), "GetEpisodeDetailsAsync method did not return expected results!");
        }
        [Test]
        public async Task GetEpisodeDetailsById()
        {
            var episodeId = 1;

            var episode = await episodeService.GetEpisodeDetailsById(episodeId);

            Assert.That(episode.EpisodeId, Is.EqualTo(episodeId), "GetSeasonDetailsById method did not return expected results!");
        }
        [Test]
        public async Task EpisodeCreateAsyncTest()
        {
            var seasonId = 1;
            var seasonNumeration = 1;

            var episode = DatabaseConstants.CreateEpisodeModel();

            await episodeService.CreateAsync(episode, seasonId, seasonNumeration);

            var repositoryCount = repository.TakeAll<Episode>().Count();

            Assert.That(repositoryCount, Is.EqualTo(41), "Episode was not created succesfully!");
        }
        [Test]
        public void NullEpisodeCreateAsyncTest()
        {
            var seasonId = 33;
            var seasonNumeration = 1;

            Assert.ThrowsAsync<NullReferenceException>(async () => await episodeService.CreateAsync(DatabaseConstants.CreateEpisodeModel(), seasonId, seasonNumeration), MessagesConstants.SeasonDoesNotExistsMessage);
        }
        [Test]
        public async Task EpisodeEditAsyncTest()
        {
            var episodeId = 1;
            var episodeToEdit = DatabaseConstants.EpisodeForEdit();

            await episodeService.EditAsync(episodeId, episodeToEdit);

            var editedEpisode = await repository.GetByIdAsync<Episode>(episodeId);

            Assert.That(editedEpisode.ReleaseDate, Is.EqualTo(episodeToEdit.ReleaseDate), "EditAsync method did not return expected results!");
        }
        [Test]
        public void NullSeasonEditAsyncTest()
        {
            var episodeId = 120;

            Assert.ThrowsAsync<NullReferenceException>(async () => await episodeService.EditAsync(episodeId, DatabaseConstants.EpisodeForEdit()), MessagesConstants.EpisodeDoesNotExistsMessage);
        }
        [Test]
        public async Task EpisodeDeleteAsyncTest()
        {
            var episodeId = 1;

            await episodeService.DeleteAsync(episodeId);

            var episode = await repository.GetByIdAsync<Episode>(episodeId);

            Assert.IsNull(episode, "DeleteAsync dont delete what was expected!");
        }
        [Test]
        public async Task EpisodeIsNullDeleteAsyncTest()
        {
            var episodeId = 120;

            await episodeService.DeleteAsync(episodeId);

            var count = repository.TakeAll<Episode>().Count();

            Assert.That(count, Is.EqualTo(40), "DeleteAsync delete unexpected record!");
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }
    }
}
