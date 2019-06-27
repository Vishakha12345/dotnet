using BLL;
namespace WCFAuthApp
{
     public class AuthService :IAuthService
    {  public   bool Validate(string userName, string password)
        {
            bool status = false;
            status = AccountManager.Validate(userName, password);
            return status;

        }
       public  Customer GetCustomer(int id)
        {
            Customer cust = null;
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