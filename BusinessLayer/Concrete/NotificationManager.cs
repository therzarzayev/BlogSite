
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
	public class NotificationManager : INotificationService
	{
		private readonly INotificationDal _notificationDal;

		public NotificationManager(INotificationDal notificationDal)
		{
			_notificationDal = notificationDal;
		}

		public Task Add(Notification t)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Notification>> GetAll()
		{
			return await _notificationDal.GetAllAsync();
		}

		public Task<IEnumerable<Notification>> GetAllFilteredAsync(Expression<Func<Notification, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public Task<Notification?> GetById(int id)
		{
			throw new NotImplementedException();
		}

		public Task Remove(Notification t)
		{
			throw new NotImplementedException();
		}

		public Task Update(Notification t)
		{
			throw new NotImplementedException();
		}
	}
}
