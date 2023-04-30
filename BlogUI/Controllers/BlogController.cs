using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	[AllowAnonymous]
	public class BlogController : Controller
	{
		BlogManager manager = new BlogManager(new EfBlogRepository());

		[Route("")]
		[Route("{controller}")]
		public async Task<IActionResult> Index()
		{
			var blogs = await manager.GetAllBlogsWithCategory();
			return View(blogs);
		}

		[HttpGet]
		[Route("{controller}/{id}")]
		public async Task<IActionResult> BlogDetail(int id)
		{
			var blog = await manager.GetBlogById(id);
			return View(blog);
		}
	}
}
