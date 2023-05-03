using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
	public class WriterManager : IWriterService
	{
		private readonly IWriterDal _writerDal;

		public WriterManager(IWriterDal writerDal)
		{
			_writerDal = writerDal;
		}

		public async Task Add(Writer t)
		{
			await _writerDal.AddAsync(t);
		}

		public async Task<IEnumerable<Writer>> GetAll()
		{
			return await _writerDal.GetAllAsync();
		}

        public async Task<IEnumerable<Writer>> GetAllFilteredAsync(Expression<Func<Writer, bool>> filter)
        {
			return await _writerDal.GetAllFilteredAsync(filter);
        }

        public async Task<Writer?> GetById(int id)
		{
			return await _writerDal.GetByIdAsync(id);
		}

		public async Task<Writer> GetWriterByEmail(string email)
		{
			return await _writerDal.GetWriterByEmail(email);
		}

		public async Task Remove(Writer t)
		{
			await _writerDal.DeleteAsync(t);
		}

		public async Task Update(Writer t)
		{
			await _writerDal.UpdateAsync(t);
		}
	}
}
