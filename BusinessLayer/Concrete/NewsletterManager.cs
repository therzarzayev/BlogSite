
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class NewsletterManager : INewsletterService
	{
		private readonly INewsletterDal _newsletterDal;
		public NewsletterManager(INewsletterDal newsletterDal)
		{
			_newsletterDal = newsletterDal;
		}
		public async Task AddNewsletter(NewsLetter newsLetter)
		{
			await _newsletterDal.AddAsync(newsLetter);
		}
	}
}
