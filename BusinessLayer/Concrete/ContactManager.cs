using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
	public class ContactManager : IContactService
	{
		private readonly IContactDal _contactDal;

		public ContactManager(IContactDal contactDal)
		{
			_contactDal = contactDal;
		}

		public async Task Add(Contact t)
		{
			await _contactDal.AddAsync(t);
		}

		public async Task<IEnumerable<Contact>> GetAll()
		{
			return await _contactDal.GetAllAsync();
		}

        public Task<IEnumerable<Contact>> GetAllFilteredAsync(Expression<Func<Contact, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<Contact?> GetById(int id)
		{
			return await _contactDal.GetByIdAsync(id);
		}

		public async Task Remove(Contact t)
		{
			await _contactDal.DeleteAsync(t);
		}

		public async Task Update(Contact t)
		{
			await _contactDal.UpdateAsync(t);
		}
	}
}
