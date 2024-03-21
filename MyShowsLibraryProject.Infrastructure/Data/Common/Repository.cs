
using Microsoft.EntityFrameworkCore;

namespace MyShowsLibraryProject.Infrastructure.Data.Common
{
    public class Repository : IRepository
    {
        private readonly DbContext dbContext;

        public Repository(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        private DbSet<T> DbSet<T>() where T : class 
            => dbContext.Set<T>();

        public async Task AddAsync<T>(T entity) where T : class
            => await DbSet<T>().AddAsync(entity);

        public IQueryable<T> TakeAll<T>() where T : class
            => DbSet<T>();

        public IQueryable<T> TakeAllReadOnly<T>() where T : class
            => DbSet<T>()
                .AsNoTracking();
        public async Task<T?> GetByIdAsync<T>(object id) where T : class
            => await DbSet<T>().FindAsync(id);

        public async Task<bool> CheckIfExistAsync<T>(object id) where T : class
            => await DbSet<T>().ContainsAsync(id);

        public async Task SaveChangesAsyn()
            => await dbContext.SaveChangesAsync();

    }
}
