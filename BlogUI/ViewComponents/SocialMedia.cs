using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents
{
	public class SocialMedia: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
