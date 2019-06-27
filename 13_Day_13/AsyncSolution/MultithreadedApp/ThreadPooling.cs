using System;
using System.Collections.Generic;
using System.Threading;


namespace MultithreadedApp
{
    using System;
    using System.Threading;

    public class TestClass
    {
        int fromNum, toNum;
        int primes;
        int lastPrime;
        string myName;

        public TestClass(string name, int from, int to)
        {
            myName = name;
            fromNum = from;
            toNum = to;
        }

        void CalcPrime(int minInt, int maxInt)
        {
            int maxIter, i, num;
            primes = 0;
            lastPrime = 0;

            for (num = minInt; num < maxInt; num++)
            {
                maxIter = (int)(Math.Sqrt(num));
                if (num % 2 == 0)
                    continue;
                for (i = 3; i <= maxIter; i += 2)
                    if (num % i == 0)
                        break;
                if (i > maxIter)
                {
                    lastPrime = num;
                    primes++;
                }
            }
        }
        public void DoLongCalc(object obj)
        {
            Console.WriteLine("Start calculating prime> {0}", myName);
            CalcPrime(fromNum, toNum);
            Console.WriteLine("Calculating finished> {0}", myName);
            Console.WriteLine("Primes from {0} to {1}", fromNum, toNum);
            Console.WriteLine("Last prime {0}, found {1} primes", lastPrime, primes);
        }
        public void DoLongCalc1(object obj, bool signaled)
        {
            DoLongCalc(obj);
        }
    }

    public class ThreadPooingMainClass
    {
        static void Test1()
        {
            TestClass[] manyObj = new TestClass[200];
            Console.WriteLine("--- Start creating objects ---");
            for (int i = 0; i < 200; i++)
            {
                manyObj[i] = new TestClass(i.ToString(), 0, 1000000);
                ThreadPool.QueueUserWorkItem(new WaitCallback(manyObj[i].DoLongCalc));
            }
            Console.WriteLine("--- Objects created ---");
            Thread.Sleep(100000);
        }
        static void Test2()
        {
            TestClass[] manyObj = new TestClass[100];
            AutoResetEvent[] startEvent = new AutoResetEvent[10];
            Console.WriteLine("--- Start creating events ---");
            for (int i = 0; i < 10; i++)
            {
                startEvent[i] = new AutoResetEvent(false);
            }
            Console.WriteLine("--- Start creating objects ---");
            for (int i = 0; i < 100; i++)
            {
                manyObj[i] = new TestClass(i.ToString(), 0, 10000);
                ThreadPool.RegisterWaitForSingleObject(
                            startEvent[i / 10],
                            new WaitOrTimerCallback(manyObj[i].DoLongCalc1),
                            null, 10000, true);
            }
            Console.WriteLine("--- Objects created ---");
            Console.WriteLine("--- Fire events ---");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Fire event: {0}", i);
                startEvent[i].Set();
                Thread.Sleep(2000);
            }
            Thread.Sleep(2000);
        }
        public static int Main(string[] args)
        {
            Test2();
            return 0;
        }
    }
}
