namespace Assignment2FACADE
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblCcnum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCCardNum = new System.Windows.Forms.TextBox();
            this.txtCcvNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblCardException = new System.Windows.Forms.Label();
            this.lblCardNoInvalid = new System.Windows.Forms.Label();
            this.lblCcvException = new System.Windows.Forms.Label();
            this.lblCcvError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCcnum
            // 
            this.lblCcnum.AutoSize = true;
            this.lblCcnum.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCcnum.Location = new System.Drawing.Point(31, 225);
            this.lblCcnum.Name = "lblCcnum";
            this.lblCcnum.Size = new System.Drawing.Size(141, 14);
            this.lblCcnum.TabIndex = 0;
            this.lblCcnum.Text = "Enter Credit Card Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ccv Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCCardNum
            // 
            this.txtCCardNum.Location = new System.Drawing.Point(34, 243);
            this.txtCCardNum.Name = "txtCCardNum";
            this.txtCCardNum.Size = new System.Drawing.Size(173, 20);
            this.txtCCardNum.TabIndex = 2;
            this.txtCCardNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCcvNum
            // 
            this.txtCcvNum.Location = new System.Drawing.Point(34, 301);
            this.txtCcvNum.Name = "txtCcvNum";
            this.txtCcvNum.Size = new System.Drawing.Size(69, 20);
            this.txtCcvNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Expiration Date";
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbMonth.Location = new System.Drawing.Point(174, 301);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(43, 21);
            this.cmbMonth.TabIndex = 7;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28"});
            this.cmbYear.Location = new System.Drawing.Point(224, 301);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(47, 21);
            this.cmbYear.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 177);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.White;
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(386, 315);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(94, 32);
            this.btnProcess.TabIndex = 10;
            this.btnProcess.Text = "Proceed";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblCardException
            // 
            this.lblCardException.AutoSize = true;
            this.lblCardException.BackColor = System.Drawing.Color.Transparent;
            this.lblCardException.ForeColor = System.Drawing.Color.Red;
            this.lblCardException.Location = new System.Drawing.Point(34, 268);
            this.lblCardException.Name = "lblCardException";
            this.lblCardException.Size = new System.Drawing.Size(10, 13);
            this.lblCardException.TabIndex = 11;
            this.lblCardException.Text = " ";
            this.lblCardException.Click += new System.EventHandler(this.lblCardException_Click);
            // 
            // lblCardNoInvalid
            // 
            this.lblCardNoInvalid.AutoSize = true;
            this.lblCardNoInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblCardNoInvalid.Location = new System.Drawing.Point(211, 250);
            this.lblCardNoInvalid.Name = "lblCardNoInvalid";
            this.lblCardNoInvalid.Size = new System.Drawing.Size(10, 13);
            this.lblCardNoInvalid.TabIndex = 12;
            this.lblCardNoInvalid.Text = " ";
            // 
            // lblCcvException
            // 
            this.lblCcvException.AutoSize = true;
            this.lblCcvException.ForeColor = System.Drawing.Color.Red;
            this.lblCcvException.Location = new System.Drawing.Point(37, 328);
            this.lblCcvException.Name = "lblCcvException";
            this.lblCcvException.Size = new System.Drawing.Size(10, 13);
            this.lblCcvException.TabIndex = 13;
            this.lblCcvException.Text = " ";
            // 
            // lblCcvError
            // 
            this.lblCcvError.AutoSize = true;
            this.lblCcvError.ForeColor = System.Drawing.Color.Red;
            this.lblCcvError.Location = new System.Drawing.Point(37, 342);
            this.lblCcvError.Name = "lblCcvError";
            this.lblCcvError.Size = new System.Drawing.Size(10, 13);
            this.lblCcvError.TabIndex = 14;
            this.lblCcvError.Text = " ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(492, 364);
            this.Controls.Add(this.lblCcvError);
            this.Controls.Add(this.lblCcvException);
            this.Controls.Add(this.lblCardNoInvalid);
            this.Controls.Add(this.lblCardException);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCcvNum);
            this.Controls.Add(this.txtCCardNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCcnum);
            this.Name = "Form3";
            this.Text = "label";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCcnum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCCardNum;
        private System.Windows.Forms.TextBox txtCcvNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblCardException;
        private System.Windows.Forms.Label lblCardNoInvalid;
        private System.Windows.Forms.Label lblCcvException;
        private System.Windows.Forms.Label lblCcvError;
    }
}