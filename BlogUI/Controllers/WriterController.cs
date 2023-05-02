using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	[AllowAnonymous]
	public class WriterController : Controller
	{
		private readonly BlogManager _manager;
        public WriterController()
        {
            _manager = new(new EfBlogRepository());
        }
        [Route("/writer/dashboard")]
		[HttpGet]
		public IActionResult DashBoard()
		{
			return View();
		}

		[Route("/writer/messages")]
		[HttpGet]
		public IActionResult Messages()
		{
			return View();
		}

		[Route("/writer/notifications")]
		[HttpGet]
		public IActionResult Notifications()
		{
			return View();
		}

		[Route("/writer/settings")]
		[HttpGet]
		public IActionResult Settings()
		{
			return View();
		}

		[Route("/writer/profile")]
		[HttpGet]
		public IActionResult Profile()
		{
			return View();
		}
	}

}
