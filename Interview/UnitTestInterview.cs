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

        [TestMethod]
        public void Test_All()
        {
            repository = new InMemoryRepository<Storeable>();
            var result = repository.All();

            Assert.IsInstanceOfType(result, typeof(IEnumerable<Storeable>));
        }

        [TestMethod]
        public void Test_Find()
        {
            repository = new InMemoryRepository<Storeable>();
            var firstItem = new Storeable { Id = 1, Name = "First Item" };
            var secondItem = new Storeable { Id = 2, Name = "Second Item" };
            var thirdItem = new Storeable { Id = 3, Name = "Third Item" };

            repository.Save(firstItem);
            repository.Save(secondItem);
            repository.Save(thirdItem);

            var result = repository.FindById(2);
            Assert.AreEqual(secondItem, result);
        }

        [TestMethod]
        public void Test_Save()
        {
            repository = new InMemoryRepository<Storeable>();
            var newitem = new Storeable { Id = 1, Name = "New Item" };

            repository.Save(newitem);

            var result = repository.All();
            Assert.IsTrue(((IEnumerable<Storeable>)result).Contains(newitem));

        }
    }
}
