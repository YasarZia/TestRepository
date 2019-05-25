using System;

namespace Interview
{
    class Storeable : IStoreable
    {
        public IComparable Id { get; set; }
        public string Name { get; set; }
    }
}
