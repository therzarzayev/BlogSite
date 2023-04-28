
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	public class CommentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
