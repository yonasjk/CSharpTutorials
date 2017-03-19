using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_JoinMethod
{
    class Program
    {
        static TimeSpan waitTime = new TimeSpan(0, 0, 10);

        public static void Main()
        {
            Thread newThread =
                new Thread(new ThreadStart(Work));
            newThread.Start();

            if (newThread.Join(waitTime + waitTime))
            {
                Console.WriteLine("New thread terminated.");
            }
            else
            {
                Console.WriteLine("Join timed out.");
            }
        }

        static void Work()
        {
            Thread.Sleep(waitTime);
        }
    }
}
