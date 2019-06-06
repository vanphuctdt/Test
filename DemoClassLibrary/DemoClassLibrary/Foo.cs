using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClassLibrary
{
    public class Foo
    {
        public long UtcNowTick()
        {
            return DateTime.UtcNow.Ticks;
        }
    }
}
