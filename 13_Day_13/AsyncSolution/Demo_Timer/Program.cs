using System.Threading;
using System;
namespace Demo_Timer
{
    class Program
    {
        static Timer timer;
        static int cnt = 10;
        public static void Show(object o)
        {
            --cnt;
            if (cnt == 0)
            {
                timer.Dispose();
                Environment.Exit(0);
            }
            Console.WriteLine("Hello!");
            Console.WriteLine(" Show :Thread {0}", Thread.CurrentThread.ManagedThreadId);
        }

            static void Main(string[] args)
            {
            Console.WriteLine("Primary :Thread {0}", Thread.CurrentThread.ManagedThreadId);

            TimerCallback cb = new TimerCallback(Show);
            timer = new Timer(cb,null,0,3000);

            Console.WriteLine("Timer has started!");
            Console.WriteLine(" After Timer started :Primary :Thread {0}", Thread.CurrentThread.ManagedThreadId);

            Console.Read();
        }
    }
}
