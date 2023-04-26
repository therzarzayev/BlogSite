using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
