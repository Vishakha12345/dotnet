using System;
using System.Collections.Generic;
using BOL;

namespace DAL
{
    public class Repository
    {


        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer { FirstName = "Ravi", LastName = "Tambade", BirthDate = System.DateTime.Now });
            customers.Add(new Customer { FirstName = "Narendra", LastName = "Pawar", BirthDate = System.DateTime.Now });
            customers.Add(new Customer { FirstName = "Jevan", LastName = "Rane", BirthDate = System.DateTime.Now });
            customers.Add(new Customer { FirstName = "Sachin", LastName = "Kolhe", BirthDate = System.DateTime.Now });
            customers.Add(new Customer { FirstName = "Sarang", LastName = "Rane", BirthDate = System.DateTime.Now });
            customers.Add(new Customer { FirstName = "Nitin", LastName = "Jadhav", BirthDate = System.DateTime.Now });
            customers.Add(new Customer { FirstName = "Manoj", LastName = "Varma", BirthDate = System.DateTime.Now });
            customers.Add(new Customer { FirstName = "Nilesh", LastName = "Sharma", BirthDate = System.DateTime.Now });
            customers.Add(new Customer { FirstName = "Nilesh", LastName = "More", BirthDate = System.DateTime.Now });
            customers.Add(new Customer { FirstName = "Madhuri", LastName = "Patil", BirthDate = System.DateTime.Now });
            customers.Add(new Customer { FirstName = "Nilesh", LastName = "Rane", BirthDate = System.DateTime.Now });
            customers.Add(new Customer { FirstName = "Sanjay", LastName = "Rane", BirthDate = System.DateTime.Now });
            customers.Add(new Customer { FirstName = "Nilesh", LastName = "Rane", BirthDate = System.DateTime.Now });
            customers.Add(new Customer { FirstName = "Nilesh", LastName = "Kulkarni", BirthDate = System.DateTime.Now });
            customers.Add(new Customer { FirstName = "Ranvir", LastName = "Rane", BirthDate = System.DateTime.Now });
            customers.Add(new Customer { FirstName = "Chaya", LastName = "Rane", BirthDate = System.DateTime.Now });
            customers.Add(new Customer { FirstName = "Nilesh", LastName = "Rane", BirthDate = System.DateTime.Now });
            customers.Add(new Customer { FirstName = "Sham", LastName = "Manik", BirthDate = System.DateTime.Now });
            customers.Add(new Customer { FirstName = "Nilesh", LastName = "Rane", BirthDate = System.DateTime.Now });
            customers.Add(new Customer { FirstName = "Jagan", LastName = "Rane", BirthDate = System.DateTime.Now });
            customers.Add(new Customer { FirstName = "Rani", LastName = "Rane", BirthDate = System.DateTime.Now });

            return customers;
        }
        public List<HR.Employee> GetEmployees()
        {
            List<HR.Employee> employees = new List<HR.Employee>();
            //Access Data from files
            //Acces Date from database
            //Access data from REST API
            //Access data from LOB
           

            return employees;
        }
    }
}
