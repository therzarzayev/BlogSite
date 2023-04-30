using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	[AllowAnonymous]
	public class AboutController : Controller
	{
		AboutManager manager = new AboutManager(new EfAboutRepository());

		[Route("/about")]
		public async Task<IActionResult> Index()
		{
			var abouts = await manager.GetAllAbouts();
			var about = abouts.TakeLast(1);
			return View(about);
		}
	}
}
