using System.Data;
using System.Data.SqlClient;
using System;


namespace TestDBApp
{
    class Program
    {
        static void Main(string[] args)
        {

            RemoteCRMReference.CRMServiceSoapClient proxy = new RemoteCRMReference.CRMServiceSoapClient();
            string result =proxy.HelloWorld();
            Console.WriteLine(result);

            RemoteCRMReference.Customer cst = null;

            cst = proxy.GetCustomer(1);
            Console.WriteLine(cst.FullName);
            Console.WriteLine(cst.Age);

            Console.WriteLine(cst.Email);


            Console.ReadLine();

        }
    }
}
