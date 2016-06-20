using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfDemos
{
    class Program
    {
        static void Main()
        {
            Enum.Demo(ConsoleModifiers.Control | ConsoleModifiers.Shift);
        }
    }
}
