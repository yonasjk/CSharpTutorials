using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_NamedMutex
{
    class Program
    {
        public static void Main(string[] args)
        {
            string mutexName = "akshay";
            Mutex m = new Mutex(false, mutexName);
            for (;;)
            {
                m.WaitOne();
                Console.WriteLine("Have Mutex");
                Console.WriteLine("Releasing");
                m.ReleaseMutex();
            }
            Console.Read();
        }
    }
}
