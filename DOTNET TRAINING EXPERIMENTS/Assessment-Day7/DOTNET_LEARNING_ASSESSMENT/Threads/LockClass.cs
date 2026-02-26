using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_LEARNING_ASSESSMENT.Threads
{
    class Counter
    {
        public int count = 0;

       
        private readonly object lockObj = new object();

        public void Increment()
        {
            lock (lockObj)
            {
                count++;
            }

           
        }
    }
    internal class LockClass
    {
        static Counter counter = new Counter();

        static void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                counter.Increment();
            }
            Console.WriteLine(Thread.CurrentThread.Name + " is executed!");
            Console.WriteLine("Count After " + Thread.CurrentThread.Name + " : " + counter.count);
        }
        //static void Main()
        //{
        //    Task t = Task.Run(() => { });
        //    Thread t1 = new Thread(Run);
        //    t1.Name = "Thread1";
        //    Thread t2 = new Thread(Run);
        //    t2.Name = "Thread2";

        //    t1.Start();
        //    t2.Start();

        //    t1.Join();
        //    t2.Join();

        //    Console.WriteLine("Final Count: " + counter.count);
        //}

       
    }
   

}
