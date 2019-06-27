using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BOL;

namespace DAL
{
    public static class Register
    {
        public static int id;
        public static string FirstName;
        public static string LastName;
        public static string Email;
        public static string city;


        public static Boolean Insert(int id, string FirstName, string LastName, string Email, string city)
        {
            string connStr = @"Data Source =(LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\dac\source\repos\Test\WebApplication1\App_Data\abc1.mdf; Integrated Security = True";
            string query = "insert into Register values(@id,@FirstName,@LastName,@Email,@city)";

            bool status = false;
            using (SqlConnection s1 = new SqlConnection(connStr))
            {
                using (SqlCommand s2 = new SqlCommand(query))
                {

                    s2.Parameters.Add(new SqlParameter("@id", id));
                    s2.Parameters.Add(new SqlParameter("@FirstName", FirstName));
                    s2.Parameters.Add(new SqlParameter("@LastName", LastName));
                    s2.Parameters.Add(new SqlParameter("@Email", Email));
                    s2.Parameters.Add(new SqlParameter("@city", city));
                    s1.Open();
                    s2.Connection = s1;
                    s2.ExecuteNonQuery();
                    status = true;
                }
            }
            return status;
        }
        public static List<Customer> GetAll()
        {
            List<Customer> products = new List<Customer>();
            string connStr = @"Data Source =(LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\dac\source\repos\Test\WebApplication1\App_Data\abc1.mdf; Integrated Security = True";

            string query = "select * from Register";
            using (SqlConnection s1 = new SqlConnection(connStr))
            {
                using (SqlCommand s2 = new SqlCommand(query))
                {
                    s1.Open();
                    s2.Connection = s1;
                    s2.ExecuteNonQuery();
                    SqlDataReader reader = s2.ExecuteReader();
                    while(reader.Read())
                    {
                        int id = int.Parse(reader["id"].ToString());
                        string FirstName = reader["FirstName"].ToString();
                        string LastName = reader["LastName"].ToString();
                        string Email = reader["Email"].ToString();
                        string city = reader["city"].ToString();
                        products.Add(new Customer()
                        {
                            id = id,
                            FirstName = FirstName,
                            LastName = LastName,
                            Email = Email,
                            city = city
                        });
                    }
                    reader.Close();
                   
                }
            }
                
                return products;


        }

        public static Boolean update(int id, string FirstName, string Email, string city)
        {
            string connStr = @"Data Source =(LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\dac\source\repos\Test\WebApplication1\App_Data\abc1.mdf; Integrated Security = True";
            string query = "update Register set FirstName=@FirstName,Email=@Email,city=@city where Id=@id ";
            bool status = false;
            using (SqlConnection s1 = new SqlConnection(connStr))
            {
                using (SqlCommand s2 = new SqlCommand(query))
                {

                    s2.Parameters.Add(new SqlParameter("@id", id));
                    s2.Parameters.Add(new SqlParameter("@FirstName", FirstName));
                    s2.Parameters.Add(new SqlParameter("@Email", Email));
                    s2.Parameters.Add(new SqlParameter("@city", city));



                    s1.Open();
                    s2.Connection = s1;
                    s2.ExecuteNonQuery();
                    status = true;
                }
            }

            return status;
        }
        public static bool Delete(int id)
        {
            bool status = false;
            string connStr = @"Data Source =(LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\dac\source\repos\Test\WebApplication1\App_Data\abc1.mdf; Integrated Security = True";
            string query = "Delete from Register where id=@id";
            using (SqlConnection s1 = new SqlConnection(connStr))
            {
                using (SqlCommand s2 = new SqlCommand(query))
                {
                 
                    s2.Parameters.Add(new SqlParameter("@id", id));
                    s1.Open();
                    s2.Connection = s1;
                    s2.ExecuteNonQuery();
                    status = true;
                }
            }
            return status;
    }
   
    }
}
