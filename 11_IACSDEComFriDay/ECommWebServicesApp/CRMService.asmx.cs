using System.Web.Services;
using System.Runtime.Serialization;

namespace ECommWebServicesApp
{
    public class Customer
    {
        [DataMember]
        public string FullName { get; set; }
        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public int Age { get; set; }
    }

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
   public class CRMService : System.Web.Services.WebService
    {

        public CRMService()
        {


        }
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }


        [WebMethod]
        public Customer GetCustomer(int id)
        {
            Customer  cust = null;
            switch (id)
            {
                case 1:
                    {
                        cust = new Customer
                        {
                            FullName = "Manish Pande",
                            Age = 23,
                            Email = "manish.pande@gmail.com"
                        };
                    }
                    break;

                case 2:
                    {
                        cust = new Customer
                        {
                            FullName = "Raj Pande",
                            Age = 26,
                            Email = "raj.pande@gmail.com"
                        };
                    }
                    break;
                case 3:
                    {
                        cust = new Customer
                        {
                            FullName = "Manish Nene",
                            Age = 34,
                            Email = "manish.nene@gmail.com"
                        };
                    }
                 
                    break;

            }
            return cust;
        }
    }
}
