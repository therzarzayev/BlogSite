using BusinessLayer.Concrete;
using BusinessLayer.Validation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	[AllowAnonymous]
	public class BlogController : Controller
	{
		BlogManager manager = new BlogManager(new EfBlogRepository());

		[Route("")]
		[Route("/blog")]
		public async Task<IActionResult> Index()
		{
			var blogs = await manager.GetAllBlogsWithCategory();
			return View(blogs);
		}

		[HttpGet]
		[Route("/blog/{id}")]
		public async Task<IActionResult> BlogDetail(int id)
		{
			var blog = await manager.GetById(id);
			return View(blog);
		}

		#region Author
		[Route("/blog/my-blogs")]
		[HttpGet]
		public async Task<IActionResult> Blogs()
		{
			var bwc = await manager.GetAllBlogsWithCategory();
			var blogs = bwc.Where(x => x.Id == 7);
			return View(blogs);
		}

		[Route("/blog/new-blog")]
		[HttpGet]
		public IActionResult NewBlog()
		{
			return View();
		}

		[Route("/blog/new-blog")]
		[HttpPost]
		public async Task<IActionResult> NewBlog(Blog blog)
		{
			BlogValidator bv = new();
			ValidationResult result = bv.Validate(blog);
			if (result.IsValid)
			{
				blog.CreatedDate = DateTime.Now;
				blog.Status = true;
				await manager.Add(blog);
				return View();
			}
			else
			{
				foreach (var error in result.Errors)
				{
					ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
				}
				return View();
			}
		}

		#endregion
	}
}
