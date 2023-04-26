using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents
{
	public class AddComment: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
