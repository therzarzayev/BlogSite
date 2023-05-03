using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents
{
	public class Footer : ViewComponent
	{
		BlogManager manager = new(new EfBlogRepository());
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var blogs = await manager.GetAll();
			var last3blog = blogs.OrderByDescending(x => x.CreatedDate).Take(3);
			return View(last3blog);
		}
	}
}
