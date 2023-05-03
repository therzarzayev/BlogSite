using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents
{
	public class LastBlog: ViewComponent
	{
		BlogManager manager = new BlogManager(new EfBlogRepository());
		public async Task<IViewComponentResult> InvokeAsync(int writerId)
		{
			var blogs = await manager.GetAll();
			var last2blog = blogs.OrderByDescending(x => x.CreatedDate).Where(x => x.WriterId == writerId).Take(2);
			return View(last2blog);
		}
	}
}
