using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IWriterDal: IRepository<Writer>
    {
		Task<Writer> GetWriterByEmail(string email);
	}
}
