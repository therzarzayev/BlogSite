using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IAboutService
	{
		Task<IEnumerable<About>> GetAllAbouts();
	}
}
