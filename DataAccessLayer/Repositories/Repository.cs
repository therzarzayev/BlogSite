using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            using (var context = new Context())
            {
                return await context.Set<T>().ToListAsync();
            }
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            using (var context = new Context())
            {
                return await context.Set<T>().FindAsync(id);
            }
        }

        public async Task AddAsync(T entity)
        {
            using (var context = new Context())
            {
                await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(T entity)
        {
            using (var context = new Context())
            {
                context.Entry(entity).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            using (var context = new Context())
            {
                var entity = await GetByIdAsync(id);
                if (entity != null)
                {
                    context.Set<T>().Remove(entity);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
