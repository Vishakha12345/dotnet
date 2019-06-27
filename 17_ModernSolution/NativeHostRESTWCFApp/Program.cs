using System;
using System.ServiceModel.Description;
using System.ServiceModel.Web;

namespace NativeHostRESTWCFApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri httpUrl = new Uri("http://localhost:9898/HRService/EmployeeService");
            WebServiceHost host = new WebServiceHost(typeof(NativeHostRESTWCFApp.EmployeeService), httpUrl);
            host.Open();

            foreach (ServiceEndpoint se in host.Description.Endpoints)
                Console.WriteLine("Service is host with endpoint " + se.Address);
            //Console.WriteLine("ASP.Net : " + ServiceHostingEnvironment.AspNetCompatibilityEnabled);
            Console.WriteLine("Host is running... Press < Enter > key to stop");
            Console.ReadLine();
        }
    }
}
