using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace MultithreadedApp
{
    class Example
    {
        private static Semaphore newSemaphore;

        static void Main()
        {
            try
            {
                newSemaphore = new Semaphore(0, 4);
                for (int counter = 1; counter < 11; counter++)
                {
                    Thread newThread = new Thread(new ParameterizedThreadStart(DoWork));
                    newThread.Start(counter);
                }
                Thread.Sleep(1000);
                Console.WriteLine("Main thread calls Release(4).");
                newSemaphore.Release(4);
                Console.WriteLine("Main thread exits.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void DoWork(object number)
        {
            newSemaphore.WaitOne();
            Console.WriteLine("Thread {0} enters the semaphore.", number);
            Thread.Sleep(2000);
            Console.WriteLine("Thread {0} releases the semaphore.", number);
            newSemaphore.Release();
        }
    }
}
