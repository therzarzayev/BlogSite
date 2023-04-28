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
			var blogs = await manager.GetAllBlogsWithWriter(writerId);
			return View(blogs.Take(2));
		}
	}
}
