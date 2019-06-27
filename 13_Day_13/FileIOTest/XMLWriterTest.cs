using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FileIOTest
{
    class XMLWriterTest
    {
        class Employee
        {   public int Id { set; get; }
            public string FirstName { set; get; }
            public string LastName { set; get; }
            public int Salary { set; get; }
            public Employee(int id, string firstName, string lastName, int salary)
            {
                this.Id = id;
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Salary = salary;
            }  
        }
        static void Main()
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee(1, "Raj", "Sharma", 10000);
            employees[1] = new Employee(3, "Vanita", "Patil", 30000);
            employees[2] = new Employee(4, "Omkar", "Hinge", 20000);
            employees[3] = new Employee(12, "Jessica", "Pinto", 120000);

            using (XmlWriter writer = XmlWriter.Create("employees.xml"))
            {   writer.WriteStartDocument();
                writer.WriteStartElement("Employees");
                foreach (Employee employee in employees)
                {
                    writer.WriteStartElement("Employee");

                    writer.WriteElementString("ID", employee.Id.ToString());
                    writer.WriteElementString("FirstName", employee.FirstName);
                    writer.WriteElementString("LastName", employee.LastName);
                    writer.WriteElementString("Salary", employee.Salary.ToString());

                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            Console.ReadLine();
        }
    }
}      
 
