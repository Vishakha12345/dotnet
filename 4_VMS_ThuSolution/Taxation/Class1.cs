using System;

namespace Taxation
{
    public class Tax
    {


        //every  Tax handler should match input parameter
        //and out parameter syntax with delegate syntax

        public static void PaySalesT(double amount)
        {
            Console.WriteLine("Sales Tax applied Rs. " + amount.ToString());
        }
        public static void PayIT(double amount)
        {
            Console.WriteLine("Income Tax applied Rs. " + amount.ToString());
        }


        public static void PayGST(double amount)
        {
            Console.WriteLine("Sales Tax applied Rs. " + amount.ToString());

        }


    }



}
