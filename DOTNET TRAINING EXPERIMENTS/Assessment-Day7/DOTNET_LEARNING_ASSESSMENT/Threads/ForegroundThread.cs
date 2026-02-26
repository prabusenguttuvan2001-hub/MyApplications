using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_LEARNING_ASSESSMENT.Threads
{
    internal class ForegroundThread
    {
        //static void Main()
        //{
        //    Thread t1 = new Thread(Work);
        //    Thread t2 = new Thread(Eat);
        //    // t.IsBackground = false;   // Foreground thread if you change it as true means its a background thread.
        //    t1.Priority = ThreadPriority.Highest;
        //    t2.Priority = ThreadPriority.BelowNormal; // setting priority is a request not a guarantee
        //    t1.Start();
        //    t2.Start();

        //    Console.WriteLine("Main Thread Ends");
        //}

        static void Work()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Working... " + i);
                Thread.Sleep(1000);
            }
        }
        static void Eat()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Eating..  " + i);
                Thread.Sleep(1000);
            }
        }
    }
}
