
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IWriterService
	{
		Task WriterAdd(Writer writer);
		Task<Writer> GetWriterByEmail(string email);
	}
}
