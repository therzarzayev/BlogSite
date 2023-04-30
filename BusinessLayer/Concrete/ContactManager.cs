using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class ContactManager : IContactService
	{
		private readonly IContactDal _contactDal;

		public ContactManager(IContactDal contactDal)
		{
			_contactDal = contactDal;
		}

		public async Task ContactAdd(Contact contact)
		{
			await _contactDal.AddAsync(contact);
		}
	}
}
