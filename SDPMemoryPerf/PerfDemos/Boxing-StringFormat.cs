using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfDemos
{
    public class BoxingStringFormat
    {
        public static void Demo()
        {
            for (int count = 0; count < 50000; count++)
            {
                var message = string.Format("count = {0}", count);
                Console.WriteLine(message);
            }
        }
    }
}
