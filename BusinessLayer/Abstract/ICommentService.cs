using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface ICommentService
	{
		Task CommentAdd(Comment comment);
		Task<IEnumerable<Comment>> GetAllComments(int id);
	}
}
