using System;
using Fogvent.CrossCutting;
using Fogvent.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fogvent.Test.Data
{
    [TestClass]
    public class UnitTest1
    {
        //private IContainer _contianer;
        private IUnitOfWork _uof;
        

        [TestInitialize]
        public void Initialize()
        {
           // _contianer = new ContainerConfig().ConfigureAutofac();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var test = _uof;
            
        }
    }
}
