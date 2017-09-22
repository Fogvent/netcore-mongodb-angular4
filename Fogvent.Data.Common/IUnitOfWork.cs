using System;

namespace Fogvent.Data.Common
{
    public interface IUnitOfWork:IDisposable
    {
        IRepository<T> RepositoryFor<T>() where T : class;
        int SaveChanges();
    }
}
