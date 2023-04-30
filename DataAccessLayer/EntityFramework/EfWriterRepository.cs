using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
	public class EfWriterRepository : Repository<Writer>, IWriterDal
	{
		public async Task<Writer> GetWriterByEmail(string email)
		{
			using (var context = new Context())
			{
				return await context.Writers.FirstOrDefaultAsync(x => x.Email == email);
			}
		}
	}
}
