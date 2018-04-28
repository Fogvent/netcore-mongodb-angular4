
namespace Fogvent.Data.Common.Sql
{
    public interface IUnitOfWork
    {
        IRepository<T> RepositoryFor<T>() where T : class;
        int SaveChanges();
    }
}
