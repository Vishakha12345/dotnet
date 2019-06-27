using System.Data;
using System.Data.SqlClient;
using System;


namespace TestDBApp
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tfladmin\source\repos\IACSDECom\EComWFE\App_Data\ECommDB.mdf;Integrated Security=True";
            con.ConnectionString = conString;
            cmd.CommandText = "SELECT * FROM users";
            cmd.Connection = con;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["Id"].ToString());
                    string userName = reader["userName"].ToString();
                    string password = reader["password"].ToString();
                    Console.WriteLine("{0} {1}  {2}", id, userName, password);
                }
                reader.Close();
            }
            catch (SqlException exp)
            {
                Console.WriteLine(exp.Message);
            }

            finally
            {
                con.Close();
            }

        }
    }
}
