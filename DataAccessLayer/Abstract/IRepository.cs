using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
		Task<IEnumerable<T>> GetAllFilteredAsync(Expression<Func<T,bool>> filter);
		Task<T?> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}
