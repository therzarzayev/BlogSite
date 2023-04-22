using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IBlogService
	{
		Task BlogAdd(Blog blog);
		Task BlogRemove(int id);
		Task BlogUpdate(Blog blog);
		Task<IEnumerable<Blog>> GetAllBlogs();
		Task<Blog?> GetBlogById(int id);
	}
}
