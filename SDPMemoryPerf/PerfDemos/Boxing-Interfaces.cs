using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfDemos
{
    public class BoxingInterfaces
    {
        public static void Demo()
        {
            for (int count = 0; count < 50000; count++)
            {
                using (AcquireLock()) 
                {
                    // Do something that requires locking
                }
            }
        }

        private static IDisposable AcquireLock()
        {
            return new LockCookie();
        }

        private struct LockCookie : IDisposable
        {
            public void Dispose()
            {
                // free the lock
            }
        }
    }
}
