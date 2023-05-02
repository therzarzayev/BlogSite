using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents
{
	public class Footer : ViewComponent
	{
		BlogManager manager = new(new EfBlogRepository());
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var blogs = await manager.GetAll();
			return View(blogs.TakeLast(3));
		}
	}
}
