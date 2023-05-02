using BusinessLayer.Concrete;
using BusinessLayer.Validation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BlogUI.Controllers
{
	[AllowAnonymous]
	public class RegisterController : Controller
	{
		private readonly WriterManager manager = new WriterManager(new EfWriterRepository());
		[HttpGet]
		[Route("/register")]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		[Route("/register")]
		public async Task<IActionResult> Index(Writer writer)
		{
			WriterValidator wv = new WriterValidator();
			ValidationResult result = wv.Validate(writer);
			if (result.IsValid)
			{
				await manager.Add(writer);
				return RedirectToAction("index", "blog");
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
