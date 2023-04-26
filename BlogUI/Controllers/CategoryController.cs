using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	public class CategoryController : Controller
	{
		CategoryManager manager = new CategoryManager(new EfCategoryRepository());
		public async Task<IActionResult> Index()
		{
			var dsf = await manager.GetAllCategories();
			return View(dsf);
		}
	}
}
