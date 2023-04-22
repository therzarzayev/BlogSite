

using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		private readonly IBlogDal _blogDal;

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

        public async Task BlogAdd(Blog blog)
		{
			await _blogDal.AddAsync(blog);
		}

		public async Task BlogRemove(int id)
		{
			await _blogDal.DeleteAsync(id);
		}

		public async Task BlogUpdate(Blog blog)
		{
			await _blogDal.UpdateAsync(blog);
		}

		public async Task<IEnumerable<Blog>> GetAllBlogs()
		{
			return await _blogDal.GetAllAsync();
		}

		public async Task<Blog?> GetBlogById(int id)
		{
			return await _blogDal.GetByIdAsync(id);
		}
	}
}
