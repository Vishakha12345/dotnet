using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EComWebFormsApp
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            string userName = this.txtUserName.Text;
            string password = this.txtPassword.Text;
            ServiceReference1.HelloServiceSoapClient proxy = new ServiceReference1.HelloServiceSoapClient();
            bool status = proxy.Validate(userName, password);
            if (status)
            {
                this.lblStatus.Text = "Welcome to  Web";
            }
            else
            {
                this.lblStatus.Text = "Invalid User , Please try again";
            }
        }
    }
}