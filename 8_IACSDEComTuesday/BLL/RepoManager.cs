using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public static class RepoManager
    {

       public static  List<Product> GetAllProducts()
        {
           
            return Repository.GetAllProducts();
        }

        public static List<Customer> GetAllCustomers()
        {
            //retriving Analytical data with business query
            // will have logic in future to find top ten customers
            //LINQ Query

            return Repository.GetAllCustomers();
        }
    }
}
