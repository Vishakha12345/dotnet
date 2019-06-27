namespace PaymentGateway
{
    public class PaymentService : IPaymentService
    {
        public string PayBill(string PayId)
        {
            return "Transaction having PayId " + PayId + " was successful";
        }

    }
}
