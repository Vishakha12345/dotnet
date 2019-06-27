using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
   public static class AccountManager
    {

        public static bool Validate(string userName, string password)
        {
            return AccountDAL.Validate(userName, password);
        }
    }
}
