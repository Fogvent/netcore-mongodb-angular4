using System;
using System.Collections.Generic;
using System.Linq;
using Fogvent.Data.Common;
using Fogvent.Data.Repositories.Interfaces;
using Fogvent.Models.Entities;

namespace Fogvent.Data.Repositories.Implementations
{
    public class UsersRepository : IUsersRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public UsersRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<User> GetUsers()
        {
            return _unitOfWork.RepositoryFor<User>().Get().ToList();
        }

        public IEnumerable<User> GetUsersAsync()
        {
            throw new NotImplementedException();
        }

        public User GetUser()
        {
            throw new NotImplementedException();
        }

        public User GetUserAsync()
        {
            throw new NotImplementedException();
        }
    }
}
