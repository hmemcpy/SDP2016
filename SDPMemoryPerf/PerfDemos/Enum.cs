using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfDemos
{
    class Enum
    {
        public static void Demo(ConsoleModifiers modifiers)
        {
            if (modifiers.HasFlag(ConsoleModifiers.Control))
            {
            }

            if ((modifiers & ConsoleModifiers.Control) != 0)
            {
            }
        }
    }
}
