using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents
{
    public class CategoryListDashboard: ViewComponent
    {
        CategoryManager manager = new(new EfCategoryRepository());
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await manager.GetAll();
            return View(categories);
        }
    }
}
