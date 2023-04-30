using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	public class ContactController : Controller
	{
		ContactManager manager = new ContactManager(new EfContactRepository());
		
		[HttpGet]
		[Route("contact")]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		[Route("contact")]
		public async Task<IActionResult> Index(Contact contact)
		{
			contact.CreatedDate = DateTime.Now;
			contact.Status = true;
			await manager.ContactAdd(contact);
			return View();
		}
	}
}
