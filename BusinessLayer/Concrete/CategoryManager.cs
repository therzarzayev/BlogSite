using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class CategoryManager : ICategoryService
	{
		private readonly ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public async Task CategoryAdd(Category category)
		{
			await _categoryDal.AddAsync(category);
		}

		public async Task CategoryRemove(int id)
		{
			await _categoryDal.DeleteAsync(id);
		}

		public async Task CategoryUpdate(Category category)
		{
			await _categoryDal.UpdateAsync(category);
		}

		public async Task<IEnumerable<Category>> GetAllCategories()
		{
			return await _categoryDal.GetAllAsync();
		}

		public async Task<Category?> GetCategoryById(int id)
		{
			return await _categoryDal.GetByIdAsync(id);
		}
	}
}
