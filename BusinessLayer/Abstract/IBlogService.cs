﻿using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IBlogService
	{
		Task BlogAdd(Blog blog);
		Task BlogRemove(int id);
		Task BlogUpdate(Blog blog);
		Task<IEnumerable<Blog>> GetAllBlogs();
		Task<IEnumerable<Blog>> GetAllBlogsWithCategory();
		Task<Blog?> GetBlogById(int id);
	}
}
