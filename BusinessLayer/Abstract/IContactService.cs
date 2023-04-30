using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IContactService
	{
		Task ContactAdd(Contact contact);
	}
}
