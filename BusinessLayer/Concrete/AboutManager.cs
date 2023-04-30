
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class AboutManager : IAboutService
	{
		private IAboutDal _aboutDal;

		public AboutManager(IAboutDal aboutDal)
		{
			_aboutDal = aboutDal;
		}

		public async Task<IEnumerable<About>> GetAllAbouts()
		{
			return await _aboutDal.GetAllAsync();
		}
	}
}
