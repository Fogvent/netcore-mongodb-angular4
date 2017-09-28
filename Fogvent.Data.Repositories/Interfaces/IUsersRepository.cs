using System.Collections.Generic;
using Fogvent.Models.Entities;

namespace Fogvent.Data.Repositories.Interfaces
{
    public interface IUsersRepository
    {
        IEnumerable<User> GetUsers();
        IEnumerable<User> GetUsersAsync();
        User GetUser();
        User GetUserAsync();
    }
}
