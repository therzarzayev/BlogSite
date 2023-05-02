using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
	public class CategoryManager : ICategoryService
	{
		private readonly ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public async Task Add(Category t)
		{
			await _categoryDal.AddAsync(t);
		}

		public async Task<IEnumerable<Category>> GetAll()
		{
			return await _categoryDal.GetAllAsync();
		}

        public Task<IEnumerable<Category>> GetAllFilteredAsync(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<Category?> GetById(int id)
		{
			return await _categoryDal.GetByIdAsync(id);
		}

		public async Task Remove(int id)
		{
			await _categoryDal.DeleteAsync(id);
		}

		public async Task Update(Category t)
		{
			await _categoryDal.UpdateAsync(t);
		}
	}
}
