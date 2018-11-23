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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (txtCCardNum.Text.Length > 16)
            {
                lblCardNoInvalid.Text = "* Max 16 digit Allowed";
            }
            if (txtCCardNum.Text.Length == 0)
            {
                lblCardNoInvalid.Text = "* Please Enter value";
            }
            if (txtCCardNum.Text.Length > 0 && txtCCardNum.Text.Length < 16)
            {
                lblCardNoInvalid.Text = "* Please Enter Complete Value";
            }
            if (txtCcvNum.Text.Length > 3)
            {
                lblCcvError.Text = "* Max 3 digit Allowed";
            }
            if (txtCcvNum.Text.Length == 0)
            {
                lblCcvError.Text = "* Please Enter value";
            }
            if ( txtCcvNum.Text.Length < 3)
            {
                lblCcvError.Text = "* Please Enter Complete Value";
            }
            try
            {
                double CardNo = Int64.Parse(txtCCardNum.Text);
            }
            catch (FormatException)
            {
                lblCardException.Text = "* Please enter number only:";
            }

            try
            {
                double CcvNo = Int64.Parse(txtCCardNum.Text);
            }
            catch (FormatException)
            {

                lblCcvException.Text = "* Please enter number only:";
            }

           
            if (txtCCardNum.Text.Length == 16 && txtCcvNum.Text.Length == 3)
            {
                try
                {
                    double CardNo = Int64.Parse(txtCCardNum.Text);
                }
                catch (FormatException)
                {
                    lblCardException.Text = "* Please enter number only:";
                }
            
                try
                {
                    double CcvNo = Int64.Parse(txtCCardNum.Text);
                }
                catch (FormatException)
                {

                    lblCcvException.Text = "* Please enter number only:";
                }
                //calling using facade class
                Checkout _Checkout = new Checkout();
                _Checkout.CreditcardConfirmation(txtCCardNum.Text,txtCcvNum.Text, cmbMonth.Text, cmbYear.Text);
            }
          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblCardException_Click(object sender, EventArgs e)
        {

        }
    }
}
