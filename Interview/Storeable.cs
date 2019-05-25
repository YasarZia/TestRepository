using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class Storeable : IStoreable
    {
        public IComparable Id { get; set; }
        public string Name { get; set; }
    }
}
