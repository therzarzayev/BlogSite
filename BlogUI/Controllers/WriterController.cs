using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	[AllowAnonymous]
	public class WriterController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[Route("/writer")]
		public IActionResult Test()
		{
			return View();
		}
	}
}
