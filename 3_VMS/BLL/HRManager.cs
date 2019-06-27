using System;
using System.Collections.Generic;
 
using BOL;
using DAL;
namespace BLL
{
   public  class HRManager
    {

        public List< Customer> GetAllCustomers()
        {
            Repository repo = new Repository();
            return repo.GetCustomers();
        }

        public List<HR.Employee> GetAllEmployees() {
            Repository repo = new Repository();
            return repo.GetEmployees();
        }
    }
}
