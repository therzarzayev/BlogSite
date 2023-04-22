using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        Task CategoryAdd(Category category);
        Task CategoryRemove(int id);
        Task CategoryUpdate(Category category);
        Task<IEnumerable<Category>> GetAllCategories();
        Task<Category?> GetCategoryById(int id);
    }
}
