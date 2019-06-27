using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;

namespace BLL
{
    public static class Class1
    {
        public static bool Insert(int id, String FirstName, String LastName, string Email, String city)
        {
            return Register.Insert(id, FirstName, LastName, Email, city);
        }

       public static List<Customer> GetAll()
       {
            return Register.GetAll();
       }

        public static bool Upadate(int id, string FirstName, string Email, string city)
        {
            return Register.update( id,  FirstName,  Email,  city);
        }

        public static bool Delete(int id)
        {
            return Register.Delete(id);
        }

    }
}
