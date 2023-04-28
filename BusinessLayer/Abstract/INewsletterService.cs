
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface INewsletterService
	{
		Task AddNewsletter(NewsLetter newsLetter);
	}
}
