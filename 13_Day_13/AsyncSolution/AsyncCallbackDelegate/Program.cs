using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;


namespace AsyncCallbackDelegate
{
    public delegate int ArithmaticOperation(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  AsyncCallbackDelegate Example *****");
            Console.WriteLine("Main() invoked on thread {0}.",
            Thread.CurrentThread.ManagedThreadId);


            ArithmaticOperation b = new ArithmaticOperation(Sub);



            IAsyncResult iftAR = b.BeginInvoke(20, 10,
                                               new AsyncCallback(OnSubtraction),
                                               "Main() thank you for subtracting these numbers.");




            // Assume other work is performed here...

            Console.ReadLine();
        }

        #region Target for AsyncCallback delegate
        // Don't forget to add a 'using' directive for 
        // System.Runtime.Remoting.Messaging!
        static void OnSubtraction(IAsyncResult itfAR)
        {

            //it is like a handler

            Console.WriteLine("SubComplete() invoked on thread {0}.",
                               Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Your subtraction is complete");

            // Now get the result.
            AsyncResult ar = (AsyncResult)itfAR;
            ArithmaticOperation b = (ArithmaticOperation)ar.AsyncDelegate;
            Console.WriteLine("20 - 10 is {0}.", b.EndInvoke(itfAR));

            // Retrieve the informational object and cast it to string
            string msg = (string)itfAR.AsyncState;
            Console.WriteLine(msg);
        }


        static void OnAddition(IAsyncResult itfAR)
        {

            //it is like a handler

            Console.WriteLine("SubComplete() invoked on thread {0}.",
                               Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Your subtraction is complete");

            // Now get the result.
            AsyncResult ar = (AsyncResult)itfAR;
            ArithmaticOperation b = (ArithmaticOperation)ar.AsyncDelegate;
            Console.WriteLine("20 - 10 is {0}.", b.EndInvoke(itfAR));

            // Retrieve the informational object and cast it to string
            string msg = (string)itfAR.AsyncState;
            Console.WriteLine(msg);
        }

        static void OnMultiplication(IAsyncResult itfAR)
        {

            //it is like a handler

            Console.WriteLine("SubComplete() invoked on thread {0}.",
                               Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Your subtraction is complete");

            // Now get the result.
            AsyncResult ar = (AsyncResult)itfAR;
            ArithmaticOperation b = (ArithmaticOperation)ar.AsyncDelegate;
            Console.WriteLine("20 - 10 is {0}.", b.EndInvoke(itfAR));

            // Retrieve the informational object and cast it to string
            string msg = (string)itfAR.AsyncState;
            Console.WriteLine(msg);
        }
        #endregion

        #region Target for ArithmaticOperation delegate

        static int Add(int x, int y)
        {
            Console.WriteLine("Add() invoked on thread {0}.",
                               Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            return x + y;
        }

        static int Sub(int x, int y)
        {
            Console.WriteLine("Sub() invoked on thread {0}.",
                                Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            return x - y;
        }

        static int Multiply(int x, int y)
        {
            Console.WriteLine("Add() invoked on thread {0}.",
                               Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            return x * y;
        }

        static int Division(int x, int y)
        {
            Console.WriteLine("Add() invoked on thread {0}.",
                                Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            return x / y;
        }

        #endregion
    }
}
