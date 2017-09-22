using System;
using System.Data.Entity;
using Fogvent.Data.Common;
using Fogvent.Models.Entities;

namespace Fogvent.Data.SQL
{
    public class EfUnitOfWork : DbContext, IUnitOfWork
    {
        private readonly DbContext _context;

        public EfUnitOfWork(DbContext context)
        {
            if (context == null) throw new Exception("Context cannot be null");

            _context = context;
        }


        public IRepository<TEntity> RepositoryFor<TEntity>() where TEntity : EntityBase
        {
            return new EfRepository<TEntity>(_context);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries<EntityBase>())
            {
                var entity = entry.Entity;
                if (entry.State == EntityState.Added)
                {
                    entity.CreatedOn = DateTime.Now;
                    entity.ModifiedOn = DateTime.Now;
                }
                else if (entry.State == EntityState.Modified)
                    entity.ModifiedOn = DateTime.Now;
            }
            return base.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
