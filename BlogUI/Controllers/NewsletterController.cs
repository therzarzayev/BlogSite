using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	[AllowAnonymous]
	public class NewsletterController : Controller
	{
		NewsletterManager manager = new NewsletterManager(new EfNewsletterRepository());

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		[Route("/subscribe")]
		public async Task<IActionResult> Index(string mail)
		{
			if (!string.IsNullOrEmpty(mail))
			{
				var subscriber = new NewsLetter { Mail = mail, Status = true };
				await manager.Add(subscriber);
				return Content("success");
			}
			return Content("error");
		}
	}
}
