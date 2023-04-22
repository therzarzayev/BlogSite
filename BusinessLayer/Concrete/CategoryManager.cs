using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly EfCategoryRepository repository;
        public CategoryManager()
        {
            repository = new EfCategoryRepository();
        }

        public async Task CategoryAdd(Category category)
        {
            await repository.AddAsync(category);
        }

        public async Task CategoryRemove(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task CategoryUpdate(Category category)
        {
            await repository.UpdateAsync(category);
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await repository.GetAllAsync();
        }

        public async Task<Category?> GetCategoryById(int id)
        {
            return await repository.GetByIdAsync(id);
        }
    }
}
