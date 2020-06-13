using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AutomacaoDal
{
    public interface IGenericCrudDal<T>
    {
        void create(T oEntity);
        void delete(Func<T, bool> predicate);
        void update(T oEntity);
        IEnumerable<T> read();
        Task<List<T>> listAsyncAll();
        Task<List<T>> listAsync(Expression<Func<T, bool>> predicate);
        Task<T> readAsync(Expression<Func<T, bool>> predicate);
        Task<T> findAsync(int id);
    }
}
