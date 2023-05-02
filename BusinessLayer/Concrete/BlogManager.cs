using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		private readonly IBlogDal _blogDal;

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

		public async Task Add(Blog t)
		{
			await _blogDal.AddAsync(t);
		}

		public async Task Remove(int id)
		{
			await _blogDal.DeleteAsync(id);
		}

		public async Task Update(Blog t)
		{
			await _blogDal.UpdateAsync(t);
		}

		public async Task<IEnumerable<Blog>> GetAll()
		{
			return await _blogDal.GetAllAsync();
		}

		public async Task<IEnumerable<Blog>> GetAllBlogsWithCategory()
		{
			return await _blogDal.GetBlogsWithCategory();
		}

		public async Task<IEnumerable<Blog>> GetAllBlogsWithWriter(int id)
		{
			return await _blogDal.GetAllFilteredAsync(x => x.WriterId == id);
		}

		public async Task<Blog?> GetById(int id)
		{
			return await _blogDal.GetByIdAsync(id);
		}

        public async Task<IEnumerable<Blog>> GetAllFilteredAsync(Expression<Func<Blog, bool>> filter)
        {
			return await _blogDal.GetAllFilteredAsync(filter);
        }
    }
}
