using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BLL;
namespace ECommWebServicesApp
{
   
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
 
    public class HelloService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string GetMentor()
        {
            return "Ravi Tambade";
        }

        [WebMethod]
        public DateTime GetNextTestDay()
        {
            return new DateTime(2019, 7, 12);

        }

        [WebMethod]
        public bool Validate(string userName, string password)
        {
            bool status = false;
            status = AccountManager.Validate(userName, password);
            return status;
        }
    }
}
