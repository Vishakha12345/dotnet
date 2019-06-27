using System.ServiceModel;
using System.ServiceModel.Web;

namespace PaymentGateway
{
  [ServiceContract]
    public interface IPaymentService
    {

        [OperationContract]
        [WebInvoke(Method = "GET",
            UriTemplate = "/PayBill/{PayId}", 
            BodyStyle = WebMessageBodyStyle.Wrapped, 
            RequestFormat = WebMessageFormat.Json, 
            ResponseFormat = WebMessageFormat.Json)]
        string PayBill(string PayId);
    }
}
