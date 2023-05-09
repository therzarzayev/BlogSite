using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents
{
	public class WriteLast5Blogs: ViewComponent
	{
		BlogManager manager = new(new EfBlogRepository());
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var blogs = await manager.GetAllBlogsWithWriterCategory();
			var last5blogs = blogs.Take(5);

            return View(last5blogs);
		}
	}
}
