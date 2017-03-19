using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_MutexWaitOne
{
    class Program
    {
        private static int Runs = 0;
        static Mutex mutex = new Mutex(false, "RunsMutex");

        public static void CountUp()
        {
            while (Runs < 10)
            {
                // acquire the mutex
                mutex.WaitOne();
                int Temp = Runs;
                Temp++;
                Console.WriteLine(Thread.CurrentThread.Name + " " + Temp);
                Thread.Sleep(800);
                Runs = Temp;
                // release the mutex
                mutex.ReleaseMutex();
            }
        }

        public static void Main()
        {
            Thread t2 = new Thread(new ThreadStart(CountUp));
            t2.Name = "t2";
            Thread t3 = new Thread(new ThreadStart(CountUp));
            t3.Name = "t3";
            t2.Start();
            t3.Start();
            Console.Read();
        }
    }
}
