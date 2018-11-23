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
    public partial class Form5 : Form
    {
        
        public Form5()
        {
            InitializeComponent();
        }

        private void lblSalesPrice_Click(object sender, EventArgs e)
        {

        }
        public Label lblSalesprice
        {
            get { return this.lblSalesPrice; }
        }
        public void Enablesignout()
        {
            this.lblSalesPrice.Enabled = true;
        }

        private void lblShippingCharges_Click(object sender, EventArgs e)
        {

        }
        public Label lblSippingharges
        {
            get { return this.lblShippingCharges; }
        }
        public void EnableshippingCharges()
        {
            this.lblShippingCharges.Enabled = true;
        }

        private void lblSubtotal_Click(object sender, EventArgs e)
        {

        }
        public Label lblSubTtl
        {
            get { return this.lblSubtotal; }
        }
        public void EnablelblSubttl()
        {
            this.lblSubtotal.Enabled = true;
        }

        private void lblWhtTax_Click(object sender, EventArgs e)
        {

        }
        public Label lblWhtTx
        {
            get { return this.lblWhtTax; }
        }
        public void EnableWhtTx()
        {
            this.lblWhtTax.Enabled = true;
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
        public Label lblTtl
        {
            get { return this.lblTotal; }
        }
        public void Enablettl()
        {
            this.lblTotal.Enabled = true;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbPaymentMethod.Text == "Pay With CreditCard")
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
            


            }
            else if (cmbPaymentMethod.Text == "Cash On Delivery")
            {
                Form1 ob2 = (Form1)Application.OpenForms["Form1"];
                ob2.LbltxtCardLimtit.Visible = true;
                double total = Convert.ToDouble(Math.Round(decimal.Parse(lblTotal.Text), 3));
                ob2.LbltxtCardLimtit.Text = ("Your order is will be dispatched soon Please Keep the exact " + total + " Ready");
                ob2.Btncontinue.Visible = false;
                ob2.BtnExit.Visible = true;
                Close();

            }
        }
        public Button BtnProceed
        {
            get { return this.btnProceed; }
        }
        public void EnablebtnProceed()
        {
            this.btnProceed.Enabled = true;
        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public ComboBox CmbpaymentMethod
        {
            get { return this.cmbPaymentMethod; }
        }
        public void EnablecmbPaymentMethod()
        {
            this.cmbPaymentMethod.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public PictureBox PicVisa
        {
            get { return this.pictureBox1; }
        }
        public void Enablepicturebox()
        {
            this.pictureBox1.Enabled = true;
        }

        private void lbltxtPayment_Click(object sender, EventArgs e)
        {

        }
        public Label Lbltxtpayment
        {
            get { return this.lbltxtPayment; }
        }
        public void EnableLbltxtpayment()
        {
            this.lbltxtPayment.Enabled = true;
        }

        private void lblCardasterisk_Click(object sender, EventArgs e)
        {

        }
        public Label lblcardAsterik
        {
            get { return this.lblCardasterisk; }
        }
        public void EnableCardAsterisk()
        {
            this.lblCardasterisk.Enabled = true;
        }

        private void btnPaynow_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout();
            Form1 form1 = new Form1();
            double total = Convert.ToDouble(Math.Round(decimal.Parse(lblTotal.Text), 3));
            //calling using facede class
            checkout.PaymentVerification(total);
            
        }
        public Button BtnPayNow
        {
            get { return this.btnPaynow; }
        }
        public void EnablePayNow()
        {
            this.btnPaynow.Enabled = true;
        }

        private void lblPaymentError_Click(object sender, EventArgs e)
        {

        }
        public Label LblpayError
        {
            get { return this.lblPaymentError; }
        }
        public void EnablelblPayError()
        {
            this.lblPaymentError.Enabled = true;
        }

        private void btnGoback_Click(object sender, EventArgs e)
        {
            Close();
        }
        public Button BtnGoBack
        {
            get { return this.btnGoback; }
        }
        public void EnablelbtnGoback()
        {
            this.btnGoback.Enabled = true;
        }
    }
}
