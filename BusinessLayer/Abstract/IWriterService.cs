
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IWriterService: IGService<Writer>
	{
		Task<Writer> GetWriterByEmail(string email);
	}
}
