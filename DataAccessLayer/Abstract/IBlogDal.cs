using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal : IRepository<Blog>
    {
        Task<IEnumerable<Blog>> GetBlogsWithCategory();
    }
}
