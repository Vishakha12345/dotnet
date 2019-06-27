using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public class AccountManager
    {
        public static bool Validate(string username, string password)
        {
            return Repository.Validate(username, password);
        }
        public static bool insert(int id,string name,string city,string password)
        {


            return Repository.insert(id,name,city,password);
        }
        public static bool update(int id,string city)
        {
            return Repository.update(id,city);

        }
        public static bool delete(int id)
        {
            return Repository.delete(id);
        }
        public static List<customer> getcust()
        {
            return Repository.GetAllCustomer();
        }
    }
}
