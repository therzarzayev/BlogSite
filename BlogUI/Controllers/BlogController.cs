using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	public class BlogController : Controller
	{
		BlogManager manager = new BlogManager(new EfBlogRepository());
		public async Task<IActionResult> Index()
		{
			var blogs = await manager.GetAllBlogs();
			return View(blogs);
		}
	}
}
