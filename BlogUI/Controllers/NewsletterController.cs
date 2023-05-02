using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	public class NewsletterController : Controller
	{
		NewsletterManager manager = new NewsletterManager(new EfNewsletterRepository());

		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		[Route("newsletter/subscribe")]
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
