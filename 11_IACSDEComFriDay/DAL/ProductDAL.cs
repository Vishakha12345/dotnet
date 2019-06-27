using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BOL;

namespace DAL
{
    public static  class ProductDAL
    {
        public static string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\test\IACSDEComThursDay\IACSDEComThursDay\EComWFE\App_Data\ECommDB.mdf;Integrated Security=True";


        //invoking 
        public static void  PerformOperation()
        {  IDbConnection con = new SqlConnection(conString);
            string query = "PerformTransaction"; //name of StoredProcedure
            IDbCommand cmd = new SqlCommand(query, con as SqlConnection);
            cmd.CommandType = CommandType.StoredProcedure; //;;;;;;;
            cmd.CommandText = query;
            try
            {
             con.Open();
             cmd.ExecuteNonQuery();      
            }

            catch (SqlException exp)
            {
                string message = exp.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
           

        }

        public static  List<Product> GetAll()
        {
            List<Product> products = new List<Product>();

            IDbConnection con = new SqlConnection(conString);
            string query = "SELECT * FROM flowers ";
            IDbCommand cmd = new SqlCommand(query, con as SqlConnection);
             try
                {
                    con.Open();
                    IDataReader reader = cmd.ExecuteReader();
                    //Online data using streaming mechanism
                    while(reader.Read())
                    {
                        int id = int.Parse(reader["productID"].ToString());
                        string title = reader["title"].ToString();
                        string description = reader["description"].ToString();
                        int unitPrice = int.Parse(reader["price"].ToString());
                        int quantity = int.Parse(reader["quantity"].ToString());
                        string image = reader["picture"].ToString();
                    int likes = 4000;
                    //int.Parse(reader["Likes"].ToString());

                        products.Add(new Product() { ID = id, Title =title, Description =description,
                                                        UnitPrice = unitPrice, Quantity = quantity,
                                                        Image =image,Likes=likes });

                    }
                    reader.Close();
               }

                catch(SqlException exp)
                {
                    string message = exp.Message;
                    //report to developer 
                    //log exception message log file

                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            return products;

        }

        public static List<Product> GetAllUsingDisconnected()
        {
            List<Product> products = new List<Product>();
        
            IDbConnection con = new SqlConnection(conString);
            string query = "SELECT * FROM flowers";
            IDbCommand cmd = new SqlCommand(query, con as SqlConnection);

            IDbDataAdapter da = new SqlDataAdapter(cmd as SqlCommand);

            //Offline data Access
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataRowCollection rows = ds.Tables[0].Rows;
            foreach (DataRow row in rows)
            {
                int id = int.Parse(row["Id"].ToString());
                string title = row["Title"].ToString();
                string description = row["Description"].ToString();
                int unitPrice = int.Parse(row["UnitPrice"].ToString());
                int quantity = int.Parse(row["Quantity"].ToString());
                string image = row["Image"].ToString();
                int likes = int.Parse(row["Likes"].ToString());

                products.Add(new Product()
                {
                    ID = id,Title = title,
                    Description = description, UnitPrice = unitPrice,
                    Quantity = quantity, Image = image,
                    Likes = likes
                });
            }
            return products;
        }

        public static Product GetById(int id)
        {
            Product theProduct = null;
            //Write ado.net code to get product details  by ID







            return theProduct;
        }

        public static bool Insert(Product product)
        {
            bool status = false;
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "INSERT INTO products (Id,Title, Description, Image, UnitPrice, Quantity, Likes) " +
                        "VALUES (@Id, @Title, @Description, @Image, @UnitPrice, @Quantity, @Likes)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@Id", product.ID));
                    cmd.Parameters.Add(new SqlParameter("@Title", product.Title));
                    cmd.Parameters.Add(new SqlParameter("@Description", product.Description));
                    cmd.Parameters.Add(new SqlParameter("@Image", product.Image));
                    cmd.Parameters.Add(new SqlParameter("@UnitPrice", product.UnitPrice));
                    cmd.Parameters.Add(new SqlParameter("@Quantity", product.Quantity));
                    cmd.Parameters.Add(new SqlParameter("@Likes", product.Likes));

                    cmd.ExecuteNonQuery();

                    if (con.State == ConnectionState.Open)
                        con.Close();
                    status = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return status;
        }

        public static bool Update(Product product)
        {   bool status = false;
            try
            {  using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "UPDATE flowers SET title=@Title , Description=@Description, " +
                        "picture=@Image, Price=@UnitPrice, Quantity=@Quantity, Likes=@Likes " +
                        "WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@Id", product.ID));
                    cmd.Parameters.Add(new SqlParameter("@Title", product.Title));
                    cmd.Parameters.Add(new SqlParameter("@Description", product.Description));
                    cmd.Parameters.Add(new SqlParameter("@Image", product.Image));
                    cmd.Parameters.Add(new SqlParameter("@UnitPrice", product.UnitPrice));
                    cmd.Parameters.Add(new SqlParameter("@Quantity", product.Quantity));
                    cmd.Parameters.Add(new SqlParameter("@Likes", product.Likes));

                    cmd.ExecuteNonQuery();

                    if (con.State == ConnectionState.Open)
                        con.Close();
                    status = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return status;
        }

        public static bool Delete(int productId)
        {
            bool status = false;
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string query = "DELETE FROM products WHERE Id=@ProductId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@ProductId", productId));
                    cmd.ExecuteNonQuery();
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    status = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return status;
        }






    }
}
