using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BlogUI.Controllers
{
	[AllowAnonymous]
	public class LoginController : Controller
	{
		WriterManager manager = new(new EfWriterRepository());
		[HttpGet]
		[Route("/login")]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		[Route("/login")]
		public async Task<IActionResult> Index(Writer writer)
		{
			var w = await manager.GetWriterByEmail(writer.Email);
			if (w != null)
			{
				if (w.Password == writer.Password)
				{
					var claims = new List<Claim>()
					{
						new Claim(ClaimTypes.Name,writer.Email)
					};

					var userIdentity = new ClaimsIdentity(claims,"a");
					ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
					await HttpContext.SignInAsync(principal);
					return RedirectToAction("Index", "Blog");
				}
				else
				{
					return Content("Incorrect password!");
				}
			}
			return Content("User not found!");
		}
	}
}
