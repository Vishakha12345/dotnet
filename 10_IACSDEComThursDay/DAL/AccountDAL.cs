using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public  static   class AccountDAL
    {


        public static bool Validate(string userName, string password)
        {
            bool status = false;
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\test\IACSDEComWedensDay\IACSDEComWedensDay\EComWFE\App_Data\ECommDB.mdf;Integrated Security=True";
            con.ConnectionString = conString;
            string cmdString= "SELECT * FROM USERS WHERE userName=@UserName AND password=@Password";

            cmd.CommandText = cmdString;

            cmd.Parameters.Add(new SqlParameter("@UserName", userName));
            cmd.Parameters.Add(new SqlParameter("@Password", password));


            cmd.Connection = con;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    status = true;
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
            return status;
        }
    }
}
