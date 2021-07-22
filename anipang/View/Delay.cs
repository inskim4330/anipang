using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anipang.View
{
    class Delay
    {
        public static void MakeDelay(int ms)
        {
            System.Threading.Thread.Sleep(ms);
        }
    }
}
