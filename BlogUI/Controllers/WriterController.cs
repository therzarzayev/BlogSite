using BlogUI.ViewModels;
using BusinessLayer.Concrete;
using BusinessLayer.Validation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace BlogUI.Controllers
{
	[AllowAnonymous]
	public class WriterController : Controller
	{
		private readonly WriterManager _manager;
        public WriterController()
        {
            _manager = new(new EfWriterRepository());
        }
        [Route("/writer/dashboard")]
		[HttpGet]
		public IActionResult DashBoard()
		{
			return View();
		}

		[Route("/writer/messages")]
		[HttpGet]
		public IActionResult Messages()
		{
			return View();
		}

		[Route("/writer/settings")]
		[HttpGet]
		public IActionResult Settings()
		{
			return View();
		}

		[Route("/writer/profile")]
		[HttpGet]
		public async Task<IActionResult> Profile()
		{
            var writer = await _manager.GetById(7);
            return View(writer);
		}

		[Route("/writer/update/{id}")]
		[HttpPost]
		public async Task<IActionResult> ProfileUpdateAsync(WriterViewModel writer)
		{
			var wr = new Writer();
			if(writer != null)
			{
				var extesion = Path.GetExtension(writer.Image?.FileName);
				var newImageName = Guid.NewGuid().ToString()+extesion;
				var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/blogImgs/",newImageName);
				var stream = new FileStream(location, FileMode.Create);
				writer.Image?.CopyTo(stream);
				wr.Image = newImageName;
			}
			wr.Email = writer.Email;
			wr.Password = writer.Password;
			wr.Status = writer.Status;
			wr.FirstName = writer.FirstName;
			wr.LastName = writer.LastName;
			await _manager.Add(wr);
			return RedirectToAction("profile", "writer");
		}
	}

}
