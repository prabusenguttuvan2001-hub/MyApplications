
namespace DOTNET_LEARNING_ASSESSMENT.Threads
{
    internal class ThreadClass
    {
        static void Method1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method1 : " + i);
                Thread.Sleep(1000);
            }
        }
        static void Method2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method2 : " + i);
                Thread.Sleep(1000);
            }
        }
        static void Method3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method3 : " + i);
                Thread.Sleep(1000);
            }
        }

        //static int Method4()
        //{
        //    for (int i = 1; i <= 5; i++)
        //    {
        //        return i;
        //        Thread.Sleep(1000);
        //    }
        //    return 0;
        //}
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Main Thread Started!!!");

        //    Thread t1 = new Thread(Method1);
        //    Thread t2 = new Thread(Method2);
        //    Thread t3 = new Thread(Method3);

        //    t1.Start();
        //    t2.Start();
        //    t3.Start();
        //    //t3.IsBackground = true;
        //    //t1.IsBackground = true;
        //    //t2.IsBackground = true;

        //    t1.Join();
        //    t2.Join();
        //    t3.Join();

        //    Console.WriteLine("Main Thread Completed");
        //}
    }
}
