using System;
using System.Windows.Forms;
using System.Collections.Generic;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using CRM;
using System.Xml.Serialization;

namespace CustomerSupportApp
{
    public partial class Form1 : Form
    {
        List<Customer> customers = new List<Customer>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstName = this.txtFirstName.Text;
            string lastName = this.txtLastName.Text;
            DateTime registrationDate = this.dtpRegistrationDate.Value;
            string location = this.cmdLocation.SelectedItem.ToString();
            //double turnOver = double.Parse(this.txtTurnOver.Text);
            double turnOver = Convert.ToDouble(this.txtTurnOver.Text);

            Customer cst = new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                RegistrationDate = registrationDate,
                Location = location,
                TurnOver = turnOver
            };

            customers.Add(cst);
            this.dataGridView1.DataSource = customers;
           //this.dataGridView1.Update();
           // MessageBox.Show(cst.FirstName+ " " + cst.LastName);

        
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DeSerialization
            string path = @"d:\test\customers";
            FileStream fs = new FileStream(path, FileMode.Open);
           // XmlSerializer bf = new XmlSerializer(typeof(Customer));
         BinaryFormatter bf = new BinaryFormatter();
            this.customers=(List<Customer>) bf.Deserialize(fs);
            fs.Close();
            this.dataGridView1.DataSource = customers;
            //this.dataGridView1.Update();

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Serialization code
            string path = @"d:\test\customers";
            FileStream fs = new FileStream(path,FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
          //  XmlSerializer bf = new XmlSerializer(typeof(Customer));

            bf.Serialize(fs, this.customers);
            fs.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           // this.dataGridView1.DataSource = customers;
            

        }
    }
}
