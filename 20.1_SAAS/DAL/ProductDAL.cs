using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using BOL;

namespace DAL
{
    public class ProductDAL
    {

            private static string conString = string.Empty;

            static ProductDAL()
            {
                conString = ConfigurationManager.ConnectionStrings["EStoreDBConnectionString"].ConnectionString;
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
                        string query = "INSERT INTO Products (Title, Brand, Description, ImageUrl, UnitPrice, CategoryId, Balance) " +
                            "VALUES (@Title, @Brand, @Description, @ImageUrl, @UnitPrice, @CategoryId, @Balance)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add(new SqlParameter("@Title", product.Title));
                        cmd.Parameters.Add(new SqlParameter("@Brand", product.Brand));
                        cmd.Parameters.Add(new SqlParameter("@Description", product.Description));
                        cmd.Parameters.Add(new SqlParameter("@ImageUrl", product.ImageURL));
                        cmd.Parameters.Add(new SqlParameter("@UnitPrice", product.UnitPrice));
                        cmd.Parameters.Add(new SqlParameter("@CategoryId", product.CategoryInfo.CategoryId));
                        cmd.Parameters.Add(new SqlParameter("@Balance", product.Balance));
                        cmd.Parameters.Add(new SqlParameter("@ProductId", product.ProductId));
                        cmd.ExecuteNonQuery();
                        if (con.State == ConnectionState.Open)
                            con.Close();
                        status = true;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return status;
            }

            public static bool Update(Product product)
            {
                bool status = false;
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        string query = "UPDATE Products SET Title=@Title,Brand=@Brand, Description=@Description, " +
                            "ImageUrl=@ImageUrl, UnitPrice=@UnitPrice, CategoryId=@CategoryId, Balance=@Balance " +
                            "WHERE ProductId=@ProductId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add(new SqlParameter("@Title", product.Title));
                        cmd.Parameters.Add(new SqlParameter("@Brand", product.Brand));
                        cmd.Parameters.Add(new SqlParameter("@Description", product.Description));
                        cmd.Parameters.Add(new SqlParameter("@ImageUrl", product.ImageURL));
                        cmd.Parameters.Add(new SqlParameter("@UnitPrice", product.UnitPrice));
                        cmd.Parameters.Add(new SqlParameter("@CategoryId", product.CategoryInfo.CategoryId));
                        cmd.Parameters.Add(new SqlParameter("@Balance", product.Balance));
                        cmd.Parameters.Add(new SqlParameter("@ProductId", product.ProductId));
                        cmd.ExecuteNonQuery();
                        if (con.State == ConnectionState.Open)
                            con.Close();
                        status = true;
                    }
                }
                catch (Exception ex)
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
                        string query = "DELETE FROM Products WHERE ProductId=@ProductId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add(new SqlParameter("@ProductId", productId));
                        cmd.ExecuteNonQuery();
                        if (con.State == ConnectionState.Open)
                            con.Close();
                        status = true;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return status;
            }

            public static Product Get(int productId)
            {
                Product product = null;
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        string query = "SELECT * FROM Products WHERE ProductId=@ProductId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add(new SqlParameter("@ProductId", productId));
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader != null)
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    product = new Product()
                                    {

                                        ProductId = int.Parse(reader["ProductId"].ToString()),
                                        Title = reader["Title"].ToString(),
                                        Brand = reader["Brand"].ToString(),
                                        Description = reader["Description"].ToString(),
                                        ImageURL = reader["ImageUrl"].ToString(),
                                        UnitPrice = float.Parse(reader["UnitPrice"].ToString()),
                                        Balance = int.Parse(reader["Balance"].ToString()),
                                        CategoryInfo = CategoryDAL.Get(int.Parse(reader["CategoryId"].ToString()))
                                    };
                                }
                                reader.Close();
                            }
                        }
                        if (con.State == ConnectionState.Open)
                            con.Close();

                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return product;
            }

            public static Product Get(string productName)
            {
                Product product = null;
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        string query = "SELECT * FROM Products WHERE Title=@ProductName";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add(new SqlParameter("@ProductName", productName));
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader != null)
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    product = new Product()
                                    {

                                        ProductId = int.Parse(reader["ProductId"].ToString()),
                                        Title = reader["Title"].ToString(),
                                        Brand = reader["Brand"].ToString(),
                                        Description = reader["Description"].ToString(),
                                        ImageURL = reader["ImageUrl"].ToString(),
                                        UnitPrice = float.Parse(reader["UnitPrice"].ToString()),
                                        Balance = int.Parse(reader["Balance"].ToString()),
                                        CategoryInfo = CategoryDAL.Get(int.Parse(reader["CategoryId"].ToString()))
                                    };
                                }
                                reader.Close();
                            }
                        }
                        if (con.State == ConnectionState.Open)
                            con.Close();

                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return product;
            }

            public static List<Product> GetByCategory(int categoryId)
            {
                List<Product> products = new List<Product>();
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        string query = "SELECT * FROM Products WHERE CategoryId=@categoryId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add(new SqlParameter("@categoryId", categoryId));
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader != null)
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Product product = new Product()
                                    {
                                        ProductId = int.Parse(reader["ProductId"].ToString()),
                                        Title = reader["Title"].ToString(),
                                        Brand = reader["Brand"].ToString(),
                                        Description = reader["Description"].ToString(),
                                        ImageURL = reader["ImageUrl"].ToString(),
                                        UnitPrice = float.Parse(reader["UnitPrice"].ToString()),
                                        Balance = int.Parse(reader["Balance"].ToString()),
                                        CategoryInfo = CategoryDAL.Get(int.Parse(reader["CategoryId"].ToString()))
                                    };
                                    products.Add(product);
                                }
                                reader.Close();
                            }
                        }
                        if (con.State == ConnectionState.Open)
                            con.Close();

                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return products;
            }

            public static List<Product> GetAll()
            {
                List<Product> products = new List<Product>();
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        string query = "SELECT * FROM Products";
                        SqlCommand cmd = new SqlCommand(query, con);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader != null)
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Product product = new Product()
                                    {
                                        ProductId = int.Parse(reader["ProductId"].ToString()),
                                        Title = reader["Title"].ToString(),
                                        Brand = reader["Brand"].ToString(),
                                        Description = reader["Description"].ToString(),
                                        ImageURL = reader["ImageUrl"].ToString(),
                                        UnitPrice = float.Parse(reader["UnitPrice"].ToString()),
                                        Balance = int.Parse(reader["Balance"].ToString()),
                                        CategoryInfo = CategoryDAL.Get(int.Parse(reader["CategoryId"].ToString()))
                                    };
                                    products.Add(product);
                                }
                                reader.Close();
                            }
                        }
                        if (con.State == ConnectionState.Open)
                            con.Close();

                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return products;
            }
        }
    }
