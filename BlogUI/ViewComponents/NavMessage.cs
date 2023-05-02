using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents
{
	public class NavMessage:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
