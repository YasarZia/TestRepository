using System;
using System.Collections.Generic;

namespace Interview
{
    public class InMemoryRepository<T> : IRepository<T> where T : IStoreable
    {
        private List<T> inMemoryList;

        public InMemoryRepository()
        {
            inMemoryList = new List<T>();
        }

        public IEnumerable<T> All()
        {
            return inMemoryList; 
        }

        public void Delete(IComparable id)
        {
            inMemoryList.RemoveAll(Match(id));
        }

        public T FindById(IComparable id)
        {
            return inMemoryList.Find(Match(id));
        }

        public void Save(T item)
        {
            Delete(item.Id);

            inMemoryList.Add(item);
        }

        private Predicate<T> Match(IComparable id)
        {
            return i => i.Id.Equals(id);
        }
    }
}
