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
    public class CategoryDAL
        {
            private static string conString = string.Empty;
            static CategoryDAL()
            {
                conString = ConfigurationManager.ConnectionStrings["EStoreDBConnectionString"].ConnectionString;
            }
            public static bool Insert(Category category)
            {
                bool status = false;
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        string query = "INSERT INTO Categories (Title) values (@Title)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add(new SqlParameter("@Title", category.Title));
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
            public static bool Update(Category category)
            {
                bool status = false;
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        string query = "UPDATE Categories SET Title=@Title WHERE CategoryId=@CategoryId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add(new SqlParameter("@Title", category.Title));
                        cmd.Parameters.Add(new SqlParameter("@CategoryId", category.CategoryId));
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
            public static bool Delete(int categoryId)
            {
                bool status = false;
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        string query = "DELETE FROM Categories WHERE CategoryId=@CategoryId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add(new SqlParameter("@CategoryId", categoryId));
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
            public static Category Get(int categoryId)
            {
                Category category = null;
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        string query = "SELECT [Title] FROM Categories WHERE CategoryId=@CategoryId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add(new SqlParameter("@CategoryId", categoryId));
                        string title = cmd.ExecuteScalar().ToString();

                        if (con.State == ConnectionState.Open)
                            con.Close();
                        category = new Category() { Title = title, CategoryId = categoryId };
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return category;
            }
            public static List<Category> GetAll()
            {
                List<Category> categories = new List<Category>();
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        string query = "SELECT * FROM Categories";
                        SqlCommand cmd = new SqlCommand(query, con);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader != null)
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Category category = new Category()
                                    {
                                        Title = reader["Title"].ToString(),
                                        CategoryId = int.Parse(reader["CategoryId"].ToString())
                                    };
                                    categories.Add(category);
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

                return categories;
            }
        }
    }