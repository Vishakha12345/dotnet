using System.Runtime.Serialization;
using System.ServiceModel;
namespace WCFAuthApp
{

    //user defined class used for communication
    //between client application and WCF Service

    [DataContract]
    public class Customer
    {
        [DataMember]
        public string FullName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public int Age { get; set; }
    }

   [ServiceContract]
    public interface IAuthService
    {
        [OperationContract]
        bool Validate(string userName, string password);

        [OperationContract]
        Customer GetCustomer(int id);
        

    }

}
