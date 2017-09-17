using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Fogvent.Data.Common;

namespace Fogvent.Data.SQL
{
    public class Repository<T> : IRepository<T> where T : class
    {
        #region MyRegion

        

        #endregion
        private DbSet<T> _entitySet;

        public Repository(DbContext context)
        {
            if (context == null) throw new Exception("Context cannot be null");

            _entitySet = context.Set<T>();
        }



        public void Attach(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
