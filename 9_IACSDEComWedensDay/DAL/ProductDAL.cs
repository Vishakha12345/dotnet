using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BOL;

namespace DAL
{
    public static  class ProductDAL
    {
        public static  List<Product> GetAll()
        {
            List<Product> products = new List<Product>();

            //Create Connection object with connection string
            // string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ravit\source\repos\ECommerceSolution\EStore\App_Data\ECommerceDB.mdf;Integrated Security=True";
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tfladmin\source\repos\IACSDECom\EComWFE\App_Data\ECommDB.mdf;Integrated Security=True";

            IDbConnection con = new SqlConnection(conString);
            string query = "SELECT * FROM flowers";
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

        public static Product GetById(int id)
        {
            Product theProduct = null;
            //Write ado.net code to get product details  by ID

            return theProduct;
        }
    }
}
