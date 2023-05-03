using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
	public class CommentManager : ICommentService
	{
		private readonly ICommentDal _commentDal;

		public CommentManager(ICommentDal commentDal)
		{
			_commentDal = commentDal;
		}

		public async Task<IEnumerable<Comment>> GetAllComments(int id)
		{
			return await _commentDal.GetAllFilteredAsync(c => c.BlogId == id);
		}
		public async Task Add(Comment t)
		{
			await _commentDal.AddAsync(t);
		}

		public async Task<IEnumerable<Comment>> GetAll()
		{
			return await _commentDal.GetAllAsync();
		}

		public async Task<Comment?> GetById(int id)
		{
			return await _commentDal.GetByIdAsync(id);
		}

		public async Task Remove(Comment t)
		{
			await _commentDal.DeleteAsync(t);
		}

		public async Task Update(Comment t)
		{
			await _commentDal.UpdateAsync(t);
		}

        public Task<IEnumerable<Comment>> GetAllFilteredAsync(Expression<Func<Comment, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
