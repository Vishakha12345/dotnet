using System;
using System.Threading;


namespace ASyncApp.Controllers
{

    public class TaxController
    {
        public void PayServiceTax()
        {

            Console.WriteLine(" PayService Tax thread {0}.", Thread.CurrentThread.ManagedThreadId);

            Thread.Sleep(6000);
        }
        public void PaySalesTax()
        {
            Console.WriteLine(" Pay Sales Tax thread {0}.", Thread.CurrentThread.ManagedThreadId);

            Thread.Sleep(4000);
        }
        public void PayIncomeTax()
        {

            Console.WriteLine(" Pay Income Tax thread {0}.", Thread.CurrentThread.ManagedThreadId);

            Thread.Sleep(5000);
        }
        public void PayProfessionalTax()
        {
            Console.WriteLine("thread {0}.", Thread.CurrentThread.ManagedThreadId);

            Thread.Sleep(2000);
        }
    }
}
