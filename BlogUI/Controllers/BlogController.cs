using BusinessLayer.Concrete;
using BusinessLayer.Validation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogUI.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
		CategoryManager cm = new CategoryManager(new EfCategoryRepository());
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
            var blogs = bwc.Where(x => x.WriterId == 7);
            return View(blogs);
        }

        [Route("/blog/new-blog")]
        [HttpGet]
        public async Task<IActionResult> NewBlog()
        {
            List<SelectListItem> categories = (from x in await cm.GetAll() select new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString(),
            }).ToList();
            ViewBag.Categories = categories;
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
				blog.WriterId = 7;
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

		[Route("/blog/update/{id}")]
		[HttpGet]
		public async Task<IActionResult> UpdateBlog(int id)
		{
            var blog = await manager.GetById(id);
			List<SelectListItem> categories = (from x in await cm.GetAll()
											   select new SelectListItem
											   {
												   Text = x.Name,
												   Value = x.Id.ToString(),
											   }).ToList();
			ViewBag.Categories = categories;
			return View(blog);
		}

		[Route("/blog/update/{id}")]
		[HttpPost]
		public async Task<IActionResult> UpdateBlog(Blog blog)
		{
            BlogValidator bv = new();
            ValidationResult result = bv.Validate(blog);
            if (result.IsValid)
            {
                var oldBlog = await manager.GetById(blog.Id);
                blog.Id = oldBlog!.Id;
                blog.CreatedDate = oldBlog.CreatedDate;
                blog.Status = true;
                blog.WriterId = oldBlog.WriterId;
                await manager.Update(blog);
                 return RedirectToAction("my-blogs","blog");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return RedirectToAction("blog", "my-blogs");
            }
        }

		[HttpPost]
        [Route("/blog/delete")]
		public async Task<IActionResult> DeleteBlog(int Id)
		{
            var blog = await manager.GetById(Id);
            await manager.Remove(blog!);
			return Content("blogsblog");
		}
		#endregion
	}
}
