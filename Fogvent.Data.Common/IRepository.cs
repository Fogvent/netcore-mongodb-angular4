using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Fogvent.Data.Common
{
    public interface IRepository<TEntity>:IDisposable
    {
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            IList<Expression<Func<TEntity, object>>> includedProperties = null, int? pageIndex = null, int? pageSize = null);
        Task<ICollection<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, 
            IList<Expression<Func<TEntity, object>>> includedProperties = null, int? pageIndex = null, int? pageSize = null);
        TEntity GetById(object id);
        Task<TEntity> GetAsyncById(object id);
        TEntity Insert(TEntity entity);
        IEnumerable<TEntity> BulkInsert(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Delete(Expression<Func<TEntity, bool>> where);
        void BulkDelete(IQueryable<TEntity> entities);
        void Detach(TEntity entity);
    }
}
