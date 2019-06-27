using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOL;
using DAL;


namespace VMSWinTerminalApp
{
    public partial class Form1 : Form
    {

        Repository repo = new Repository();
        List<Customer> customers = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            string firstName = this.txtFirstName.Text;
            string lastName = this.txtLastName.Text;
            DateTime birthDate = this.dtpBirthDate.Value;

            Customer theCustomer = new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate
            };

         
            //List<Customer> customers = repo.GetCustomers();
            customers.Add(theCustomer);
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = customers;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
          customers = repo.GetCustomers();
            this.dataGridView1.DataSource = customers;
        }
    }
}
