using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fogvent.Data.Common;

namespace Fogvent.Data.SQL
{
    public class EfUnitOfWork : DbContext, IUnitOfWork
    {
        private DbContext _context;

        public EfUnitOfWork(DbContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");

            _context = context;
        }


        public IRepository<T> RepositoryFor<T>() where T : class
        {
           return  new EfRepository<T>(_context);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
