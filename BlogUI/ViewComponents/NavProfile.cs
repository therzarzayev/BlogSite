using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents
{
	public class NavProfile:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
