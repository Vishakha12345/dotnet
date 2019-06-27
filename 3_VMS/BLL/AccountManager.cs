using BOL;

namespace BLL
{
    public class AccountManager
    {


        public static  bool Validate(Claim theClaim)
        {
            bool status = false;
            if (theClaim.Email=="ravi.tambade@transflower.in"
                &&  
                theClaim.Password=="iacsd")
            {
                status = true;
            }
            return status;
        }
    }
}
