
using System.Linq.Expressions;

namespace BusinessLayer.Abstract
{
	public interface IGService<T>
	{
		Task Add(T t);
		Task Remove(int id);
		Task Update(T t);
		Task<IEnumerable<T>> GetAll();
		Task<T?> GetById(int id);
        Task<IEnumerable<T>> GetAllFilteredAsync(Expression<Func<T, bool>> filter);
    }
}
