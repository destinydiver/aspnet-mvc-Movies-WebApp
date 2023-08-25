using MoviesWebApp.Models;

namespace MoviesWebApp.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task<Actor> UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);
    }