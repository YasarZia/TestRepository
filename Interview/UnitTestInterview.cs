using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interview
{
    [TestClass]
    public class UnitTestInterview
    {
        private InMemoryRepository<Storeable> repository;

        [TestMethod]
        public void Test_All()
        {
            repository = new InMemoryRepository<Storeable>();
            var result = repository.All();

            Assert.IsInstanceOfType(result, typeof(IEnumerable<Storeable>));
        }
    }
}
