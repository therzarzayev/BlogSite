using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	public class ErrorController : Controller
	{
		[Route("/error/{0}")]
		public IActionResult Error(int code)
		{
			return View();
		}
	}
}
