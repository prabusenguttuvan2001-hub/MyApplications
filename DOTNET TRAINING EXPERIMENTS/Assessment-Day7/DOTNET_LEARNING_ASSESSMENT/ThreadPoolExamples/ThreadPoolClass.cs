

namespace DOTNET_LEARNING_ASSESSMENT.ThreadPoolExamples
{
    internal class ThreadPoolClass
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

        static void Main(string []args)
        {
        //    ThreadPool.GetMinThreads(out int worker, out int io);
        //    ThreadPool.GetMaxThreads(out int maxWorker, out int maxIO);

        //    Console.WriteLine($"Min Worker: {worker}");
        //    Console.WriteLine($"Max Worker: {maxWorker}");

        //    ThreadPool.QueueUserWorkItem(_ => Method1());
        //    ThreadPool.QueueUserWorkItem(_ => Method2());
        //    ThreadPool.QueueUserWorkItem(_ => Method3());

        //    Console.WriteLine("ThreadPool count= " + ThreadPool.ThreadCount);
        Task<int> task = Task.Run(() =>
        {
            Thread.Sleep(2000);
            return 10;
        });

            int num = task.Result;
        }
    }
}
