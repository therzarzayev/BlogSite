
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
	public class AboutManager : IAboutService
	{
		private IAboutDal _aboutDal;

		public AboutManager(IAboutDal aboutDal)
		{
			_aboutDal = aboutDal;
		}

		public Task Add(About t)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<About>> GetAll()
		{
			return await _aboutDal.GetAllAsync();
		}

        public Task<IEnumerable<About>> GetAllFilteredAsync(Expression<Func<About, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<About?> GetById(int id)
		{
			throw new NotImplementedException();
		}

		public Task Remove(int id)
		{
			throw new NotImplementedException();
		}

		public Task Update(About t)
		{
			throw new NotImplementedException();
		}
	}
}
