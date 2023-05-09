using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents
{
	public class NavNotification:ViewComponent
	{
		NotificationManager manager = new(new EfNotificationRepository());
		public async Task<IViewComponentResult> InvokeAsync()
		{
			
			
			var notifications = await manager.GetAll();
			return View(notifications);
		}
	}
}
