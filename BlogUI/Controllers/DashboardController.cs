using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	[AllowAnonymous]
	public class DashboardController : Controller
	{
		[Route("/dashboard")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
