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
    public class CrewRoleServiceTest
    {
        private ICrewRoleService crewRoleService;
        private IRepository repository;
        private ICrewService crewService;
        private IRoleService roleService;
        private SqliteConnection connection;
        private ApplicationDbContext dbContext;

        [SetUp]
        public void Setup()
        {
            var mockLogger = new Mock<ILogger<CrewRoleService>>();
            var mockCrewLogger = new Mock<ILogger<CrewService>>();
            var mockRoleLogger = new Mock<ILogger<RoleService>>();

            connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite(connection);
            dbContext = new ApplicationDbContext(options.Options);

            dbContext.Database.EnsureCreated();

            repository = new Repository(dbContext);
            crewService = new CrewService(mockCrewLogger.Object, repository);
            roleService = new RoleService(mockRoleLogger.Object, repository);
            crewRoleService = new CrewRoleService(mockLogger.Object, repository, crewService, roleService);
        }

        [Test]
        public async Task TakeAllRolesTest()
        {
            var roles = await crewRoleService.TakeAllRoles();

            Assert.That(roles.Count(),Is.EqualTo(9), "TakeAllRoles method did not return expected results!");
        }
        [Test]
        public async Task AddRoleToCrewAsyncTest()
        {
            var crewId = 1;
            var roleId = 8;

            await crewRoleService.AddRoleToCrewAsync(crewId,roleId);

            var count = repository.TakeAll<CrewRole>().Count();

            Assert.That(count,Is.EqualTo(24), "AddRoleToCrewAsync was not created succesfully!");
        }
        [Test]
        public async Task TryAddExistingRoleToCrewAsyncTest()
        {
            var crewId = 1;
            var roleId = 1;

            await crewRoleService.AddRoleToCrewAsync(crewId, roleId);

            var count = repository.TakeAll<CrewRole>().Count();

            Assert.That(count, Is.EqualTo(23), "AddRoleToCrewAsync created succesfully!");
        }
        [Test]
        public void AddRoleToNullCrewAsyncTest()
        {
            var crewId = 200;
            var roleId = 8;

            Assert.ThrowsAsync<NullReferenceException>(async () => await crewRoleService.AddRoleToCrewAsync(crewId, roleId), MessagesConstants.CrewDoesNotExistsMessage);
        }
        [Test]
        public async Task RemoveRoleFromCrewAsync()
        {
            var crewId = 1;
            var roleId = 1;

            await crewRoleService.RemoveRoleFromCrewAsync(crewId,roleId);

            var count = repository.TakeAll<CrewRole>().Count();

            Assert.That(count,Is.EqualTo(22), "RemoveRoleFromCrewAsync dont delete what was expected!");
        }
        [Test]
        public async Task RemoveNullRoleFromCrewAsync()
        {
            var crewId = 1;
            var roleId = 8;

            await crewRoleService.RemoveRoleFromCrewAsync(crewId, roleId);

            var count = repository.TakeAll<CrewRole>().Count();

            Assert.That(count, Is.EqualTo(23), "RemoveRoleFromCrewAsync dont delete what was expected!");
        }
        [Test]
        public void RemoveRoleFromNullCrewAsync()
        {
            var crewId = 200;
            var roleId = 8;

            Assert.ThrowsAsync<NullReferenceException>(async () => await crewRoleService.RemoveRoleFromCrewAsync(crewId, roleId), MessagesConstants.CrewDoesNotExistsMessage);
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }
    }
}
