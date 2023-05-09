using BusinessLayer.Concrete;
using BusinessLayer.Validation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
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
		[Route("/auth/login")]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		[Route("/auth/login")]
		public async Task<IActionResult> Index(Writer writer)
		{
			LoginValidator lv = new();
			ValidationResult result = lv.Validate(writer);
			if (result.IsValid)
			{
				var w = await manager.GetWriterByEmail(writer.Email!);
				if (w != null)
				{
					if (w.Password == writer.Password)
					{
						var claims = new List<Claim>()
						{
							new Claim(ClaimTypes.Name, writer.Email!)
						};

						var userIdentity = new ClaimsIdentity(claims, "a");
						ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
						await HttpContext.SignInAsync(principal);
						return RedirectToAction("Index", "Blog");
					}
					else
					{
						ModelState.AddModelError("Password", "Yalnış parol");
						return View();
					}
				}
				else
				{
					ModelState.AddModelError("Email", "İstifadəçi mövcud deyil");
					return View();
				}
			}
			else
			{
				foreach (var error in result.Errors)
				{
					ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
				}
				return View();
			}
		}
	}
}
