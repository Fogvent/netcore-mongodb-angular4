using System;
using Fogvent.Data.Repositories.Implementations;
using Fogvent.Data.Repositories.Interfaces;
using Fogvent.Data.SQL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fogvent.Test.Repositories
{
    [TestClass]
    public class UsersTests
    {
        private readonly IUsersRepository _usersRepository = new UsersRepository(new EfUnitOfWork());

        [TestMethod, DeploymentItem(@"E:\Source Code\Learning\Fogvent\netcore-mssql-angular4\Fogvent.Data.SQL\bin\Debug\EntityFramework.dll"), DeploymentItem(@"E:\Source Code\Learning\Fogvent\netcore-mssql-angular4\Fogvent.Data.SQL\bin\Debug\EntityFramework.SqlServer.dll")]
        public void TestMethod1()
        {
            var users = _usersRepository.GetUsers();

            Assert.IsNotNull(users);
        }
    }
}
