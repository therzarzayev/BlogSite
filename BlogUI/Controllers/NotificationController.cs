using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	[AllowAnonymous]
	public class NotificationController : Controller
	{
		[Route("/notifications")]
		[HttpGet]
		public IActionResult Notifications()
		{
			return View();
		}
	}
}
