using System;
using System.Threading;
namespace MultithreadedApp
{
    class Program
    {

        public static void Show()
        {
            while (true)
            {
                Console.WriteLine("...Showing data");
                Thread.Sleep(2000);
                Console.WriteLine(" Thread ID {0}", Thread.CurrentThread.ManagedThreadId);
            }
        }
        static void Main(string[] args)
        {
            int count = 1000;
            bool status = false;

            ThreadStart thStart = new ThreadStart(Show);

            Thread th1 = new Thread(thStart);

            th1.Start();
          

            while (!status)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Performing Primary Thread task");
                if(count == 0)
                {
                    status = true;
                }
                count--;
            }
            Console.WriteLine("Main function is about to terminate");
            Console.ReadLine();
        }
    }
}
