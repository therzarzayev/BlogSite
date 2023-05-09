using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	public class AdminController : Controller
	{
		[Route("/admin")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
