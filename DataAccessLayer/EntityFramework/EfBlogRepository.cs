﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
	public class EfBlogRepository : Repository<Blog>, IBlogDal
	{
		public async Task<IEnumerable<Blog>> GetBlogsWithCategory()
		{
			using (var context = new Context())
			{
				return await context.Blogs.Include(b => b.Category).ToListAsync();
			}
		}
	}
}
