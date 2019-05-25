using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            T result = default(T);

            IStoreable storeable = new Storeable() { Id = id, Name = "" };

            foreach(var s in inMemoryList)
            {
                if(s.Id.ToString() == storeable.Id.ToString())
                {
                    result = s;
                }
            }

            return result;
        }

        public void Save(T item)
        {
            inMemoryList.Add(item);
        }

        private Predicate<T> Match(IComparable id)
        {
            return i => i.Id.Equals(id);
        }
    }
}
