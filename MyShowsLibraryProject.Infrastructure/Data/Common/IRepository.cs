namespace MyShowsLibraryProject.Infrastructure.Data.Common
{
    public interface IRepository
    {
        IQueryable<T> TakeAll<T>() where T : class;
        IQueryable<T> TakeAllReadOnly<T>() where T : class;
        Task AddAsync<T>(T entity) where T : class;
        Task SaveChangesAsync();
        Task<T?> GetByIdAsync<T>(object id) where T : class;
        Task DeleteAsync<T>(object id) where T : class;
    }
}
