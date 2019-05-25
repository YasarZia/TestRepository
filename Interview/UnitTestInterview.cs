using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interview
{
    [TestClass]
    public class UnitTestInterview
    {
        private InMemoryRepository<Storeable> repository;
        private object result;

        [TestMethod]
        public void Test_All()
        {
            repository = new InMemoryRepository<Storeable>();
            result = repository.All();

            Assert.IsInstanceOfType(result, typeof(IEnumerable<Storeable>));
        }
    }
}
