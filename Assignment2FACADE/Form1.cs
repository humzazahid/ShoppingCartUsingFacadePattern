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
    public partial class Form1 : Form
    {
         double HeadPrice = 0;
         double HidPrice = 0;
         double CctvPrice = 0;
         double Salesprice = 0;
         double Shippingcharges = 0;
         double WhtTax = 0;
         double Total = 0;
        public double ReturnSalesprice()
        {
            return Salesprice;
        }
        public double ReturnWhtTax()
        {
            return WhtTax;
        }
        public double ReturnShippingCharges()
        {
            return Shippingcharges;
        }
        public double ReturnTotal()
        {
            return Total;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.lblLoginError.Text = "*Please Login First";
            obj.ShowDialog();

        }
        public Button Btnbutton1
        {
            get { return this.button1; }
        }
        public void EnableButton1()
        {
            this.button1.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkhead.Checked == true)
            {
                HeadPrice = Convert.ToInt32(Math.Round(decimal.Parse(Headset.Text), 2));
                Salesprice +=  HeadPrice;
                SalesPrice.Text = Salesprice.ToString();
                Shippingcharges += 145;
                txtShipping.Text = Shippingcharges.ToString();
                WhtTax += (HeadPrice + 145)*7 /100;
                txtWht.Text = WhtTax.ToString();
                Total += HeadPrice + 145 + ((HeadPrice + 145) * 7 / 100);
                txtTotal.Text = Total.ToString();
            }
            if (chkhead.Checked == false)
            {
                HeadPrice = Convert.ToInt32(Math.Round(decimal.Parse(Headset.Text), 2));
                Salesprice -= HeadPrice;
                SalesPrice.Text = Salesprice.ToString();
                Shippingcharges -= 145;
                txtShipping.Text = Shippingcharges.ToString();
                WhtTax -= (HeadPrice + 145) * 7 / 100;
                txtWht.Text = WhtTax.ToString();
                Total -= (HeadPrice + 145 + ((HeadPrice + 145) * 7 / 100));
                txtTotal.Text = Total.ToString();
                if (Salesprice == 0)
                {
                    txtTotal.Text = "0";
                    txtWht.Text = "0";

                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Hid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Cctv_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

            
        }

        private void chkcctv_CheckedChanged(object sender, EventArgs e)
        {

            if (chkcctv.Checked == true)
            {
                CctvPrice = Convert.ToInt32(Math.Round(decimal.Parse(Cctv.Text), 2));
                Salesprice += CctvPrice;
                SalesPrice.Text = Salesprice.ToString();
                Shippingcharges += 145;
                txtShipping.Text = Shippingcharges.ToString();
                WhtTax += (CctvPrice + 145) * 7 / 100;
                txtWht.Text = WhtTax.ToString();
                Total += CctvPrice + 145 + ((CctvPrice + 145) * 7 / 100);
                txtTotal.Text = Total.ToString();
            }

            if (chkcctv.Checked == false)
            {
                CctvPrice = Convert.ToInt32(Math.Round(decimal.Parse(Cctv.Text), 2));
                Salesprice -= CctvPrice ;
                SalesPrice.Text = Salesprice.ToString();
                Shippingcharges -= 145;
                txtShipping.Text = Shippingcharges.ToString();
                WhtTax -= (CctvPrice + 145) * 7 / 100;
                txtWht.Text = WhtTax.ToString();
                Total -= CctvPrice + 145 + ((CctvPrice + 145) * 7 / 100);
                txtTotal.Text = Total.ToString();
                if (Salesprice == 0)
                {
                    txtTotal.Text = "0";
                    txtWht.Text = "0";

                }
            }



        }

        private void chkHid_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHid.Checked == true)
            {
                HidPrice = Convert.ToInt32(Math.Round(decimal.Parse(Hid.Text), 2));
                Salesprice += HidPrice;
                SalesPrice.Text = Salesprice.ToString();
                Shippingcharges += 145;
                txtShipping.Text = Shippingcharges.ToString();
                WhtTax += (HidPrice + 145) * 7 / 100;
                txtWht.Text = WhtTax.ToString();
                Total += HidPrice + 145 + ((HidPrice + 145) * 7 / 100);
                txtTotal.Text = Total.ToString();
            }

            if (chkHid.Checked == false )
            {
                HidPrice = Convert.ToInt32(Math.Round(decimal.Parse(Hid.Text), 2));
                Salesprice -= HidPrice;
                SalesPrice.Text = Salesprice.ToString();
                Shippingcharges -= 145;
                txtShipping.Text = Shippingcharges.ToString();
                WhtTax -= (HidPrice + 145) * 7 / 100;
                txtWht.Text = WhtTax.ToString();
                Total -= HidPrice + 145 + ((HidPrice + 145) * 7 / 100);
                txtTotal.Text = Total.ToString();
                if(Salesprice == 0)
                {
                    txtTotal.Text = "0" ;
                    txtWht.Text = "0";

                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btbContinue_Click(object sender, EventArgs e)
        {
            
            
            if (chkcctv.Checked || chkhead.Checked || chkHid.Checked)
            {
                Form5 obj = new Form5();
                obj.lblSalesprice.Text = Salesprice.ToString();
                obj.lblSippingharges.Text = Shippingcharges.ToString();
                obj.lblSubTtl.Text = (Shippingcharges + Salesprice).ToString();
                obj.lblWhtTx.Text = WhtTax.ToString();
                obj.lblTtl.Text = Total.ToString();
                obj.ShowDialog();
            }
            else
                lblContinue.Text = "*Please select Atleast One Product";
        }
        public Button Btncontinue
        {
            get { return this.btbContinue; }
        }
        public void EnableContinue()
        {
            this.btbContinue.Enabled = true;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        public Button BtnSignout
        {
            get { return this.btnSignOut; }
        }
        public void Enablesignout()
        {
            this.btnSignOut.Enabled = true;
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
        public Label LblName
        {
            get { return this.lblName; }
        }
        public void EnableNamet()
        {
            this.lblName.Enabled = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.ShowDialog();
        }
        public Button BtnLogin
        {
            get { return this.btnLogin; }
        }
        public void EnableLogin()
        {
            this.btbContinue.Enabled = true;
        }

        private void lbltxtCarlimit_Click(object sender, EventArgs e)
        {

        }
        public Label LbltxtCardLimtit
        {
            get { return this.lbltxtCarlimit; }
        }
        public void Enablelbltxtcarlimit()
        {
            this.lbltxtCarlimit.Enabled = true;
        }

        private void lbltxtCardRemainingBln_Click(object sender, EventArgs e)
        {

        }
        public Label LbltxtRemainbalance
        {
            get { return this.lbltxtCardRemainingBln; }
        }
        public void EnablelbltxtcardRamainingBln()
        {
            this.lbltxtCardRemainingBln.Enabled = true;
        }

        private void lblShowCardlimit_Click(object sender, EventArgs e)
        {

        }
        public Label LblShowRaiminglimit
        {
            get { return this.lblShowCardlimit; }
        }
        public void EnableLblShowLimit()
        {
            this.lblShowCardlimit.Enabled = true;
        }

        private void lblRmainingLimit_Click(object sender, EventArgs e)
        {

        }
        public Label LblShowRaimingBln
        {
            get { return this.lblRmainingLimit; }
        }
        public void EnableLblShowbln()
        {
            this.lblRmainingLimit.Enabled = true;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
        public Button BtnExit
        {
            get { return this.btnexit; }
        }
        public void EnablebtnExit()
        {
            this.btnexit.Enabled = true;
        }
    }
}
