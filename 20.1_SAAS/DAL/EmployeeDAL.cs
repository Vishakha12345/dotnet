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
    public class EmployeeDAL
    {

            private static string conString = string.Empty;

            static EmployeeDAL()
            {
                conString = ConfigurationManager.ConnectionStrings["EStoreDBConnectionString"].ConnectionString;
            }
            public static bool Insert(Employee employee)
            {
                bool status = false;
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();

                    string query = "INSERT INTO Employees(Id, Name, Gender, City, Email, Age) Values("+employee.EmployeeId+",'"+ employee.Name+"','"+ employee.Gender+"','"+ employee.City+"','"+employee.Email+"',"+employee.Age+")";
                    SqlCommand cmd = new SqlCommand(query, con);

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

            public static bool Update(Employee employee)
            {
                bool status = false;
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();

                    string query = "UPDATE Employees SET  Name= '" + employee.Name + "', Gender= '" + employee.Gender + "' , City=' " + employee.City + "' , Email=' "+  employee.Email + "' , Age= " +employee.Age+ " where Id ="+employee.EmployeeId;
                    SqlCommand cmd = new SqlCommand(query, con);

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

            public static bool Delete(int employeeId)
            {
                bool status = false;
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        string query = "DELETE FROM Employees WHERE Id=@EmployeeId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add(new SqlParameter("@EmployeeId", employeeId));
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

            public static Employee Get(int employeeId)
            {
                Employee Employee = null;
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        string query = "SELECT * FROM Employees WHERE Id=@EmployeeId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add(new SqlParameter("@EmployeeId", employeeId));
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader != null)
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Employee = new Employee()
                                    {
                                        EmployeeId = int.Parse(reader["Id"].ToString()),
                                        Name = reader["Name"].ToString(),
                                        Gender = reader["Gender"].ToString(),
                                        City = reader["City"].ToString(),
                                        Email = reader["Email"].ToString(),
                                        Age = int.Parse(reader["Age"].ToString()),
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

                return Employee;
            }

            public static Employee Get(string employeeName)
            {
                Employee employee = null;
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        string query = "SELECT * FROM Employees WHERE Name=@EmployeeName";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add(new SqlParameter("@EmployeeName", employeeName));
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader != null)
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    employee = new Employee()
                                    {

                                        EmployeeId = int.Parse(reader["Id"].ToString()),
                                        Name = reader["Name"].ToString(),
                                        Gender = reader["Gender"].ToString(),
                                        City = reader["City"].ToString(),
                                        Email = reader["Email"].ToString(),
                                        Age = int.Parse(reader["Age"].ToString())

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

                return employee;
            }

            public static List<Employee> GetByCity(string city)
            {
                List<Employee> employees = new List<Employee>();
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        string query = "SELECT * FROM Employees WHERE City=@city";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add(new SqlParameter("@city", city));
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader != null)
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Employee Employee = new Employee()
                                    {
                                        EmployeeId = int.Parse(reader["Id"].ToString()),
                                        Name = reader["Name"].ToString(),
                                        Gender = reader["Gender"].ToString(),
                                        City = reader["City"].ToString(),
                                        Email = reader["Email"].ToString(),
                                        Age = int.Parse(reader["Age"].ToString())
                                    };
                                employees.Add(Employee);
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

                return employees;
            }

            public static List<Employee> GetAll()
            {
                List<Employee> employees = new List<Employee>();
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        string query = "SELECT * FROM Employees";
                        SqlCommand cmd = new SqlCommand(query, con);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader != null)
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Employee Employee = new Employee()
                                    {
                                        EmployeeId = int.Parse(reader["Id"].ToString()),
                                        Name = reader["Name"].ToString(),
                                        Gender = reader["Gender"].ToString(),
                                        City = reader["City"].ToString(),
                                        Email = reader["Email"].ToString(),
                                        Age = int.Parse(reader["Age"].ToString())
                                    };
                                employees.Add(Employee);
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

                return employees;
            }
        }
    }
