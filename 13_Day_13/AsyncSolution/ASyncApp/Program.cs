using System;
using System.Threading;
using ASyncApp.Controllers;
using ASyncApp.Factory;

namespace ASyncApp
{

    public delegate int ArithmaticOperqtion(int op1, int op2);

    public delegate void TaxOperation();

    class Program
    {
    
        public static  int Addition(int op1, int op2)
        {
            int result = op1 + op2;
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine(" CAlling Addtion  Thread ID " + Thread.CurrentThread.ManagedThreadId);
            return result;
        }
        public static  int Multiplication(int op1, int op2)
        {
            int result = op1 * op2;
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" Main function invokded by Primary thread {0}.", Thread.CurrentThread.ManagedThreadId);

           ArithmaticOperqtion opn1 = new ArithmaticOperqtion(Addition);

           TaxController controller= ControllerFactory.CreateInstance();

           // Controller action method registration

            TaxOperation tax1 = new TaxOperation(controller.PayIncomeTax);
            TaxOperation tax2 = new TaxOperation(controller.PaySalesTax);
            TaxOperation tax3 = new TaxOperation(controller.PayServiceTax);


            //perform asynchronous action methods

            IAsyncResult iarTax1 = tax1.BeginInvoke(null, null);
            IAsyncResult iarTax2 = tax2.BeginInvoke(null, null);
            IAsyncResult iarTax3 = tax3.BeginInvoke(null, null);


            //Perform other tasks independent of 
            //taxation using primary Thread
            //Listen for incomming requests from client



            while (!iarTax1.AsyncWaitHandle.WaitOne(1000, true))
            {
                Console.WriteLine(".....Get other customer details!");
                Console.WriteLine("Primary thread {0}.", Thread.CurrentThread.ManagedThreadId);
            }

            while (!iarTax2.AsyncWaitHandle.WaitOne(1000, true))
            {
                Console.WriteLine(".....Get other customer details!");
                Console.WriteLine("Primary thread {0}.", Thread.CurrentThread.ManagedThreadId);
            }

            while (!iarTax3.AsyncWaitHandle.WaitOne(1000, true))
            {
                Console.WriteLine(".....Get other customer details!");
                Console.WriteLine("Primary thread {0}.", Thread.CurrentThread.ManagedThreadId);
            }

            tax1.EndInvoke(iarTax1);
            tax2.EndInvoke(iarTax2);
            tax3.EndInvoke(iarTax3);


            Console.WriteLine(" primary thread recieved notification");
            Console.WriteLine(" primary thread now started other work after taxation");

            /*
                        int op1 = 45;
                        int op2 = 3;

                        // int result = opn1(op1, op2);
                       IAsyncResult iftAR= opn1.BeginInvoke(op1, op2, null, null);

                        // This message will keep printing until the Add() method is finished.
                        while (!iftAR.AsyncWaitHandle.WaitOne(1000, true))
                        {
                            Console.WriteLine("Doing more work in Main()!");
                            Console.WriteLine("Primary thread {0}.", Thread.CurrentThread.ManagedThreadId);
                        }

                        int result = opn1.EndInvoke(iftAR);
                        Console.WriteLine(" Result = {0}", result);
                        Console.WriteLine(result);
                    */
            Console.ReadLine();
        }
    }
}
