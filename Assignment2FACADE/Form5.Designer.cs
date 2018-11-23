namespace Assignment2FACADE
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.btnProceed = new System.Windows.Forms.Button();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.Tlabel = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWhtTax = new System.Windows.Forms.Label();
            this.lblShippingCharges = new System.Windows.Forms.Label();
            this.lblSalesPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltxtPayment = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPaynow = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCardasterisk = new System.Windows.Forms.Label();
            this.lblPaymentError = new System.Windows.Forms.Label();
            this.btnGoback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.White;
            this.btnProceed.Location = new System.Drawing.Point(33, 268);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(75, 23);
            this.btnProceed.TabIndex = 27;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Pay With CreditCard",
            "Cash On Delivery"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(31, 225);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(160, 21);
            this.cmbPaymentMethod.TabIndex = 26;
            this.cmbPaymentMethod.Text = "Select One";
            this.cmbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentMethod_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(142, 166);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(10, 13);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = " ";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // Tlabel
            // 
            this.Tlabel.AutoSize = true;
            this.Tlabel.Location = new System.Drawing.Point(28, 166);
            this.Tlabel.Name = "Tlabel";
            this.Tlabel.Size = new System.Drawing.Size(37, 13);
            this.Tlabel.TabIndex = 24;
            this.Tlabel.Text = "Total :";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(142, 100);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(10, 13);
            this.lblSubtotal.TabIndex = 23;
            this.lblSubtotal.Text = " ";
            this.lblSubtotal.Click += new System.EventHandler(this.lblSubtotal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Subtotal :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "----------------------------------------------------";
            // 
            // lblWhtTax
            // 
            this.lblWhtTax.AutoSize = true;
            this.lblWhtTax.Location = new System.Drawing.Point(142, 123);
            this.lblWhtTax.Name = "lblWhtTax";
            this.lblWhtTax.Size = new System.Drawing.Size(10, 13);
            this.lblWhtTax.TabIndex = 20;
            this.lblWhtTax.Text = " ";
            this.lblWhtTax.Click += new System.EventHandler(this.lblWhtTax_Click);
            // 
            // lblShippingCharges
            // 
            this.lblShippingCharges.AutoSize = true;
            this.lblShippingCharges.Location = new System.Drawing.Point(142, 60);
            this.lblShippingCharges.Name = "lblShippingCharges";
            this.lblShippingCharges.Size = new System.Drawing.Size(10, 13);
            this.lblShippingCharges.TabIndex = 19;
            this.lblShippingCharges.Text = " ";
            this.lblShippingCharges.Click += new System.EventHandler(this.lblShippingCharges_Click);
            // 
            // lblSalesPrice
            // 
            this.lblSalesPrice.AutoSize = true;
            this.lblSalesPrice.Location = new System.Drawing.Point(142, 35);
            this.lblSalesPrice.Name = "lblSalesPrice";
            this.lblSalesPrice.Size = new System.Drawing.Size(10, 13);
            this.lblSalesPrice.TabIndex = 18;
            this.lblSalesPrice.Text = " ";
            this.lblSalesPrice.Click += new System.EventHandler(this.lblSalesPrice_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "WHT TAX 7% :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "----------------------------------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Shipping Charges :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sales Price :";
            // 
            // lbltxtPayment
            // 
            this.lbltxtPayment.AutoSize = true;
            this.lbltxtPayment.Location = new System.Drawing.Point(30, 209);
            this.lbltxtPayment.Name = "lbltxtPayment";
            this.lbltxtPayment.Size = new System.Drawing.Size(87, 13);
            this.lbltxtPayment.TabIndex = 28;
            this.lbltxtPayment.Text = "Payment Method";
            this.lbltxtPayment.Click += new System.EventHandler(this.lbltxtPayment_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(126, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 18);
            this.label8.TabIndex = 29;
            this.label8.Text = "Receipt";
            // 
            // btnPaynow
            // 
            this.btnPaynow.BackColor = System.Drawing.Color.White;
            this.btnPaynow.Location = new System.Drawing.Point(77, 268);
            this.btnPaynow.Name = "btnPaynow";
            this.btnPaynow.Size = new System.Drawing.Size(75, 23);
            this.btnPaynow.TabIndex = 30;
            this.btnPaynow.Text = "Pay Now";
            this.btnPaynow.UseVisualStyleBackColor = false;
            this.btnPaynow.Visible = false;
            this.btnPaynow.Click += new System.EventHandler(this.btnPaynow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 37);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblCardasterisk
            // 
            this.lblCardasterisk.AutoSize = true;
            this.lblCardasterisk.Location = new System.Drawing.Point(100, 209);
            this.lblCardasterisk.Name = "lblCardasterisk";
            this.lblCardasterisk.Size = new System.Drawing.Size(10, 13);
            this.lblCardasterisk.TabIndex = 32;
            this.lblCardasterisk.Text = " ";
            this.lblCardasterisk.Visible = false;
            this.lblCardasterisk.Click += new System.EventHandler(this.lblCardasterisk_Click);
            // 
            // lblPaymentError
            // 
            this.lblPaymentError.AutoSize = true;
            this.lblPaymentError.ForeColor = System.Drawing.Color.Red;
            this.lblPaymentError.Location = new System.Drawing.Point(13, 243);
            this.lblPaymentError.Name = "lblPaymentError";
            this.lblPaymentError.Size = new System.Drawing.Size(10, 13);
            this.lblPaymentError.TabIndex = 33;
            this.lblPaymentError.Text = " ";
            this.lblPaymentError.Visible = false;
            this.lblPaymentError.Click += new System.EventHandler(this.lblPaymentError_Click);
            // 
            // btnGoback
            // 
            this.btnGoback.BackColor = System.Drawing.Color.White;
            this.btnGoback.Location = new System.Drawing.Point(77, 268);
            this.btnGoback.Name = "btnGoback";
            this.btnGoback.Size = new System.Drawing.Size(75, 23);
            this.btnGoback.TabIndex = 34;
            this.btnGoback.Text = "Go Back";
            this.btnGoback.UseVisualStyleBackColor = false;
            this.btnGoback.Visible = false;
            this.btnGoback.Click += new System.EventHandler(this.btnGoback_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(335, 450);
            this.Controls.Add(this.lblPaymentError);
            this.Controls.Add(this.lblCardasterisk);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPaynow);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbltxtPayment);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.Tlabel);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblWhtTax);
            this.Controls.Add(this.lblShippingCharges);
            this.Controls.Add(this.lblSalesPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGoback);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label Tlabel;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWhtTax;
        private System.Windows.Forms.Label lblShippingCharges;
        private System.Windows.Forms.Label lblSalesPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltxtPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPaynow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCardasterisk;
        private System.Windows.Forms.Label lblPaymentError;
        private System.Windows.Forms.Button btnGoback;
    }
}