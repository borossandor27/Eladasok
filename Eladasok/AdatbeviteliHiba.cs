using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eladasok
{
    class AdatbeviteliHiba : Exception
    {
        public AdatbeviteliHiba(string hibaszoveg) : base(hibaszoveg) { }
    }
}
