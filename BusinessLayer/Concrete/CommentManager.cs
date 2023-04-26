using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class CommentManager : ICommentService
	{
		private readonly ICommentDal _commentDal;

		public CommentManager(ICommentDal commentDal)
		{
			_commentDal = commentDal;
		}

		public async Task CommentAdd(Comment comment)
		{
			await _commentDal.AddAsync(comment);
		}

		public async Task<IEnumerable<Comment>> GetAllComments(int id)
		{
			return await _commentDal.GetAllFilteredAsync(c => c.BlogId == id);
		}
	}
}
