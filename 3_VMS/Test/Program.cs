using System;
using System.Collections.Generic;
using BOL;
using BLL;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            HRManager mgr = new HRManager();
            List<Customer> customers = mgr.GetAllCustomers();
            foreach (Customer  cst in customers){
                Console.WriteLine(cst.FirstName + " " + cst.LastName);
            }

            Console.ReadLine();
        }
    }
}
