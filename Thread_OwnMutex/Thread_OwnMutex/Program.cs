using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_OwnMutex
{

    class Program
    {
        public static void Main()
        {
            bool ownsMutex;
            using (Mutex mutex = new Mutex(true, "MutexExample", out ownsMutex))
            {
                if (ownsMutex)
                {
                    Console.WriteLine("Owned");
                    mutex.ReleaseMutex();
                }
                else
                {
                    Console.WriteLine("Another instance of this application " + " already owns the mutex named MutexExample.");
                }
            }
            Console.Read();
        }
    }
}
