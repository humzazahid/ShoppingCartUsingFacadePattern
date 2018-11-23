using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2FACADE
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserName = txtUser.Text;
            string Password = txtPass.Text;
            //calling using facade class
            Checkout _Checkout = new Checkout();
            _Checkout.UsernameConfirmation(UserName, Password);
           
            

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLoginFirst_Click(object sender, EventArgs e)
        {

        }
        public Label lblLoginError
        {
            get { return this.lblLoginFirst; }
        }
        public void EnablelblFirst()
        {
            this.lblLoginFirst.Enabled = true;
        }
    }
}
