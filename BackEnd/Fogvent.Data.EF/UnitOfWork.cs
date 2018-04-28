using Fogvent.Data.Common.Sql;
using Microsoft.EntityFrameworkCore;
using System;

namespace Fogvent.Data.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Fields
        private readonly DbContext _context;
        #endregion

        #region Constructor
        public UnitOfWork(DbContextOptions<AppContext> options)
        {
            _context = new AppContext(options);
        }
        #endregion


        #region Interface Implementation
        public IRepository<TEntity> RepositoryFor<TEntity>() where TEntity : class
        {
            return new Repository<TEntity>(_context);
        }

        public int SaveChanges()
        {
            foreach (var entry in _context.ChangeTracker.Entries<Entities.BaseEntity>())
            {
                var entity = entry.Entity;
                if (entry.State == EntityState.Added)
                {
                    entity.Id = Guid.NewGuid();
                    entity.CreatedOn = DateTime.Now;
                }

                entity.ModifiedOn = DateTime.Now;
            }

            return _context.SaveChanges();
        }
        #endregion
    }
}
