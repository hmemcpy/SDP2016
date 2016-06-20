using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfDemos
{
    public class Boxing
    {
        public static void Demo()
        {
            for (int count = 0; count < 500000; count++)
            {
                DoSomethingInALoop(count);
            }
        }

        public static void DoSomethingInALoop(object o)
        {
        }
    }
}
