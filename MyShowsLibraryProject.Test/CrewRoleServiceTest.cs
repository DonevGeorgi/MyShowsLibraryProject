using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Core.Services;
using MyShowsLibraryProject.Infrastructure.Data.Common;
using MyShowsLibraryProject.Infrastructure.Data;
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
            connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite(connection);
            dbContext = new ApplicationDbContext(options.Options);

            dbContext.Database.EnsureCreated();

            repository = new Repository(dbContext);
            crewService = new CrewService(repository);
            roleService = new RoleService(repository);
            crewRoleService = new CrewRoleService(repository, crewService, roleService);
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

            Assert.That(count,Is.EqualTo(24), "CrewRole was not created succesfully!");
        }
        [Test]
        public void TryAddExistingRoleToCrewAsyncTest()
        {
            var crewId = 1;
            var roleId = 1;

            Assert.ThrowsAsync<NullReferenceException>(async () => await crewRoleService.AddRoleToCrewAsync(crewId, roleId), "Crew contains role already!");
        }
        [Test]
        public void AddRoleToNullCrewAsyncTest()
        {
            var crewId = 200;
            var roleId = 8;

            Assert.ThrowsAsync<NullReferenceException>(async () => await crewRoleService.AddRoleToCrewAsync(crewId, roleId), "Crew does not exists!");
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
        public void RemoveNullRoleFromCrewAsync()
        {
            var crewId = 1;
            var roleId = 8;

            Assert.ThrowsAsync<NullReferenceException>(async () => await crewRoleService.RemoveRoleFromCrewAsync(crewId, roleId), "Crew dont have chosen role!");
        }
        [Test]
        public void RemoveRoleFromNullCrewAsync()
        {
            var crewId = 200;
            var roleId = 8;

            Assert.ThrowsAsync<NullReferenceException>(async () => await crewRoleService.RemoveRoleFromCrewAsync(crewId, roleId), "Crew does not exists!");
        }


        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }
    }
}
