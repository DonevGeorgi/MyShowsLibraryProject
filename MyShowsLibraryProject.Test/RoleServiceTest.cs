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
    public class RoleServiceTest
    {
        private IRoleService roleService;
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
            roleService = new RoleService(repository);
        }

        [Test]
        public async Task RoleGetAllReadonlyAsyncTest()
        {
            var role = await roleService.GetAllReadonlyAsync();

            Assert.That(role.Count(), Is.EqualTo(9), "GetAllReadonlyAsync method did not return expected results!");
        }
        [Test]
        public async Task GetRoleByIdTest()
        {
            var roleId = 7;

            var role = await roleService.GetRoleById(roleId);

            Assert.That(role.RoleId, Is.EqualTo(roleId), "GetRoleById method did not return expected results!");
        }
        [Test]
        public void GetRoleByIdIfRoleIsNullTest()
        {
            var roleId = 72;

            Assert.ThrowsAsync<NullReferenceException>(async () => await roleService.GetRoleById(roleId), "Role does not exists!");
        }
        [Test]
        public async Task IsRolePresentTest()
        {
            var role = DatabaseConstants.ExistedRole();

            var result = await roleService.IsRolePresent(role.Name);

            Assert.IsTrue(result, "ExistedRole method did not return expected results!");
        }
        [Test]
        public async Task IsNullRolePresentTest()
        {
            var role = DatabaseConstants.RoleForEditAndCreate();

            var result = await roleService.IsRolePresent(role.Name);

            Assert.IsFalse(result, "ExistedRole method did not return expected results!");
        }
        [Test]
        public async Task RoleCreateAsyncTest()
        {
            var role = DatabaseConstants.RoleForEditAndCreate();

            await roleService.CreateAsync(role);

            var repositoryCount = repository.TakeAll<Role>().Count();

            Assert.That(repositoryCount, Is.EqualTo(10), "Role was not created succesfully!");
        }
        [Test]
        public void RoleNullCreateAsyncTest()
        {
            var role = DatabaseConstants.ExistedRole();

            Assert.ThrowsAsync<NullReferenceException>(async () => await roleService.CreateAsync(role), "Role does not exists!");
        }
        [Test]
        public async Task RoleEditAsyncTest()
        {
            var roleId = 7;

            var role = DatabaseConstants.RoleForEditAndCreate();

            await roleService.EditAsync(roleId, role);

            var editedModel = await roleService.GetRoleById(roleId);

            Assert.That(editedModel.Name, Is.EqualTo(role.Name), "EditAsync method did not return expected results!");
        }
        [Test]
        public void NullRoleEditAsyncTest()
        {
            var roleId = 22;

            var role = DatabaseConstants.RoleForEditAndCreate();

            Assert.ThrowsAsync<NullReferenceException>(async () => await roleService.EditAsync(roleId, role), "Role you want to edit does not exists!");
        }
        [Test]
        public async Task RoleDeleteAsyncTest()
        {
            var roleId = 7;

            await roleService.DeleteAsync(roleId);

            var role = await repository.GetByIdAsync<Role>(roleId);

            Assert.IsNull(role, "DeleteAsync dont delete what was expected!");
        }
        [Test]
        public async Task RoleIsNullDeleteAsyncTest()
        {
            var roleId = 22;

            await roleService.DeleteAsync(roleId);

            var count = repository.TakeAll<Role>().Count();

            Assert.That(count, Is.EqualTo(9), "DeleteAsync delete unexpected record!");
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }
    }
}
