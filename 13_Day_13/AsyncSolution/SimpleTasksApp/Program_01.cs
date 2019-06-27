using System;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleTasksApp
{
    class Program_01
    {
        static  void Main(string[] args)
        {

            Console.WriteLine("Main : Thread {0}", Thread.CurrentThread.ManagedThreadId);
            Method1();
            Method2();
            Console.ReadKey();

        }


        //callback

        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task Run : Thread {0}", Thread.CurrentThread.ManagedThreadId);

                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Task Run Method 1 : Thread {0}", Thread.CurrentThread.ManagedThreadId);

                    Console.WriteLine(" Method 1");
                }
            });
        }

        public static void Method2()
        {

            Console.WriteLine("Method 2 : Thread {0}", Thread.CurrentThread.ManagedThreadId);

            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Method 2 : Thread {0}", Thread.CurrentThread.ManagedThreadId);

                Console.WriteLine(" Method 2");
            }
        }
    }
}
