using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IBlogService: IGService<Blog>
	{
		Task<IEnumerable<Blog>> GetAllBlogsWithCategory();
		Task<IEnumerable<Blog>> GetAllBlogsWithWriter(int id);
	}
}
