using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents
{
	public class CommentList: ViewComponent
	{
		CommentManager manager = new CommentManager(new EfCommentRepository());
		public async Task<IViewComponentResult> InvokeAsync(int blogId)
		{
			var comments = await manager.GetAllComments(blogId);
			return View(comments);
		}
	}
}
