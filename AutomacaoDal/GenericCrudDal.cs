using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AutomacaoDal
{
    public abstract class GenericCrudDal<T> : IGenericCrudDal<T> where T : class, new()
    {
        protected AutomacaoDbContext ctx = new AutomacaoDbContext();

        public void create(T oEntity)
        {
            ctx.Set<T>().Add(oEntity);
            ctx.SaveChanges();
        }
        public void delete(Func<T, bool> predicate)
        {
            ctx.Set<T>()
           .Where(predicate).ToList()
           .ForEach(del => ctx.Set<T>().Remove(del));
            ctx.SaveChanges();
        }
        public void update(T oEntity)
        {
            ctx.Entry(oEntity).State = EntityState.Modified;
            ctx.SaveChanges();
        }
        public IEnumerable<T> read()
        {
            return ctx.Set<T>();
        }
        public async Task<List<T>> listAsync(Expression<Func<T, bool>> predicate)
        {
            return await ctx.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<List<T>> listAsyncAll()
        {
            return await ctx.Set<T>().ToListAsync();
        }

        public async Task<T> readAsync(Expression<Func<T, bool>> predicate)
        {
            return await ctx.Set<T>().FirstOrDefaultAsync<T>(predicate);
        }
        public async Task<T> findAsync(int id)
        {
            return await ctx.Set<T>().FindAsync(id);
        }
    }
}
