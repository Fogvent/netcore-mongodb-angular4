using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fogvent.Data.Common
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        IQueryable<T> Find(Expression<Func<T, bool>> where);
        void Insert(T entity);
        void Update(T entity);
        void Delete(object id);
        void Attach(T entity);

    }
}
