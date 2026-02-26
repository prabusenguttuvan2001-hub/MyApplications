using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_LEARNING_ASSESSMENT.Threads
{
    internal class ThreadProperties
    {
        //static void Main()
        //{
        //    Thread t = new Thread(DemoMethod);

        //    t.Name = "MyThread"; // we can give thread a name
        //    t.IsBackground = false; // make background or foregroundthread
        //    t.Priority = ThreadPriority.AboveNormal; // set thread priority

        //    t.Start();

        //    Console.WriteLine("Thread Name: " + t.Name);
        //    Console.WriteLine("Thread Id: " + t.ManagedThreadId); // unique id for every thread
        //    Console.WriteLine("Is Alive: " + t.IsAlive); 
        //    Console.WriteLine("State: " + t.ThreadState); 
        //}

        static void DemoMethod()
        {
            Console.WriteLine("Running in thread: " + Thread.CurrentThread.ManagedThreadId);
        }
    }
}
