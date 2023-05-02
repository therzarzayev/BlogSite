using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents
{
	public class NavNotification:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
