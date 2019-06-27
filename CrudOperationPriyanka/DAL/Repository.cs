using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
namespace DAL
{
    public static class Repository
    {
        public static bool Validate(string username,string password)
        {
            bool status = false;
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            string connstr= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\dotNet\CrudOperation\Crud1\App_Data\Database1.mdf;Integrated Security=True";
            conn.ConnectionString = connstr;
            string qry = "select * from customer where name=@name and Password=@password";
            cmd.CommandText = qry;
            cmd.Parameters.Add(new SqlParameter("@username", username));

            cmd.Parameters.Add(new SqlParameter("@password", password));
            cmd.Connection = conn;
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    status = true;

                }
                reader.Close();

            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return status;
        }

        public static bool insert(int id,string name,string city,string password)
        {
            bool status = false;
            string qry = "insert into customer values(@id,@name,@city,@password)";
            string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\dotNet\CrudOperation\Crud1\App_Data\Database1.mdf;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                using (SqlCommand cmd = new SqlCommand(qry))
                {

                    cmd.Parameters.Add(new SqlParameter("@id", id));
                    cmd.Parameters.Add(new SqlParameter("@name",name));
                    cmd.Parameters.Add(new SqlParameter("@city",city));
                    cmd.Parameters.Add(new SqlParameter("@password",password));
                    cmd.Connection = conn;
                    conn.Open();
                    
                    var abc = cmd.ExecuteNonQuery();
                    if(abc>0)
                    {
                        return true;
                    }
                 
                }
                return false;
            }
           }
        public static bool update(int id, string city)
        {
            bool status = false;
            string qry = "update customer set city=@city where id=@id";
            string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\dotNet\CrudOperation\Crud1\App_Data\Database1.mdf;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                using (SqlCommand cmd = new SqlCommand(qry))
                {
                    cmd.Parameters.Add(new SqlParameter("@id",id));
                    cmd.Parameters.Add(new SqlParameter("@city",city));

                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    status = true;


                }
                return status;
            }

        }
        public static bool delete(int id)
        {
            bool status = false;
            string qry = "delete from customer where id=@id";
            string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\dotNet\CrudOperation\Crud1\App_Data\Database1.mdf;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                using (SqlCommand cmd = new SqlCommand(qry))
                {
                    cmd.Parameters.Add(new SqlParameter("@id", id));
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    status = true;
                }
                return status;

            }

        }
        public static  List<customer> GetAllCustomer()
            {
            string qry = "select * from customer";
            string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\dotNet\CrudOperation\Crud1\App_Data\Database1.mdf;Integrated Security=True";
            List<customer> cust = new List<customer>();
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                using (SqlCommand cmd = new SqlCommand(qry))
                {
                    
                    conn.Open();
                    cmd.Connection = conn;
                    SqlDataReader reader= cmd.ExecuteReader();
                    if(reader.HasRows)
                    {

                        while (reader.Read())
                        {

                            int cid = reader.GetInt32(0);
                            string nm = reader.GetString(1);
                            string ct = reader.GetString(2);
                            string pas = reader.GetString(3);
                            cust.Add(new BOL.customer
                            {
                                Id = cid,
                                Name = nm,
                                City = ct,
                                Password = pas
                            });
                        }
                    }
                }



                   
                }


            return cust;
        }

        }
    }

