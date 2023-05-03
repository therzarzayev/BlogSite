
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
	public class NewsletterManager : INewsletterService
	{
		private readonly INewsletterDal _newsletterDal;
		public NewsletterManager(INewsletterDal newsletterDal)
		{
			_newsletterDal = newsletterDal;
		}

		public async Task Add(NewsLetter t)
		{
			await _newsletterDal.AddAsync(t);
		}

		public async Task<IEnumerable<NewsLetter>> GetAll()
		{
			return await _newsletterDal.GetAllAsync();
		}

        public Task<IEnumerable<NewsLetter>> GetAllFilteredAsync(Expression<Func<NewsLetter, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<NewsLetter?> GetById(int id)
		{
			return await _newsletterDal.GetByIdAsync(id);
		}

		public async Task Remove(NewsLetter t)
		{
			await _newsletterDal.DeleteAsync(t);
		}

		public async Task Update(NewsLetter t)
		{
			await _newsletterDal.UpdateAsync(t);
		}
	}
}
