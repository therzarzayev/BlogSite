using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents
{
	public class AdminSidebar: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
