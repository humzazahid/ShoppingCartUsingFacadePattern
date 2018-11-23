using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2FACADE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            

        }
    }
    public class AutoClosingMessageBox
    {
        System.Threading.Timer _timeoutTimer;
        string _caption;
        AutoClosingMessageBox(string text, string caption, int timeout)
        {
            _caption = caption;
            _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                null, timeout, System.Threading.Timeout.Infinite);
            using (_timeoutTimer)
                MessageBox.Show(text, caption);
        }
        public static void Show(string text, string caption, int timeout)
        {
            new AutoClosingMessageBox(text, caption, timeout);
        }
        void OnTimerElapsed(object state)
        {
            IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
            if (mbWnd != IntPtr.Zero)
                SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            _timeoutTimer.Dispose();
        }
        const int WM_CLOSE = 0x0010;
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
    }
    public class Checkout
    {
        private Username _username = new Username();
        private Creditcard _creditcard = new Creditcard();
        private Payamount _payamount = new Payamount();
        public void UsernameConfirmation(string UserName, string Password)

        {
            _username.ValidateUser(UserName, Password);

        }
        public void CreditcardConfirmation(string cardNum, string ccv, string datem,string datey)
        {
            _creditcard.ValidateCreditcard(cardNum, ccv, datem, datey);
        }
        public void PaymentVerification(double total)
        {
            _payamount.CreditLimit(total);
            
        }
    }
    
     class Username
    {
        public void ValidateUser(string userName, string password)
        {
            
            if (userName == "admin" && password == "12345")
            {
                AutoClosingMessageBox.Show("Login Success", "Redirecting....", 1000);
                Form1 ob8 = (Form1)Application.OpenForms["Form1"];
                ob8.LblName.Visible = true;
                ob8.LblName.Text = "HI " + userName;
                ob8.Btnbutton1.Visible = false;
                ob8.BtnLogin.Visible = false;
                ob8.Btncontinue.Visible = true;
                ob8.BtnSignout.Visible = true;
                Form2 ob7 = (Form2)Application.OpenForms["Form2"];
                ob7.Close();

            }
            else
            {
                MessageBox.Show("Enter wrong credentials");
            }
            

    }
      
    }
    
    class Creditcard
    {
        
        public void ValidateCreditcard(string cardNum,string ccv,string datem,string datey )
        {
            if (cardNum == "1234567891234567" && ccv == "123" && datem == "11" && datey== "22")
            {
                Form5 ob7 = (Form5)Application.OpenForms["Form5"];
                Form3 ob8 = (Form3)Application.OpenForms["Form3"];
                ob8.Close();
                AutoClosingMessageBox.Show("Card Verified", "Redirecting....", 1000);
                ob7.BtnPayNow.Visible = true;
                ob7.PicVisa.Visible = true;
                ob7.Lbltxtpayment.Visible = false;
                ob7.lblcardAsterik.Visible = true;
                string RepCardNo = cardNum.Remove(4);
                RepCardNo += "************"; 
                ob7.lblcardAsterik.Text = RepCardNo;
                ob7.CmbpaymentMethod.Visible = false;
                ob7.BtnProceed.Visible = false;
                
            }
            else
                MessageBox.Show("Invalid Credit Card");
                
        }
        
    }
    class Payamount
    {
        public void CreditLimit(double PayAmount)
        {
            

            if (PayAmount > 20001)
            {
                Form5 ob7 = (Form5)Application.OpenForms["Form5"];
                ob7.LblpayError.Visible = true;
                ob7.LblpayError.Text = "*Amount exceeding your Dialy Credit Limit";
                ob7.BtnPayNow.Visible = false;
                ob7.BtnGoBack.Visible = true;

            }
            else
            {
                AutoClosingMessageBox.Show("Payment Successfull", "Redirecting....", 1000);
                
                Form1 ob2 = (Form1)Application.OpenForms["Form1"];
                ob2.Btncontinue.Visible = false;
                ob2.BtnExit.Visible = true;
                ob2.LbltxtCardLimtit.Visible = true;
                ob2.LbltxtRemainbalance.Visible = true;
                ob2.LblShowRaimingBln.Visible = true;
                ob2.LblShowRaimingBln.Text = (200000 - PayAmount).ToString();
                ob2.LblShowRaiminglimit.Visible = true;
                ob2.LblShowRaiminglimit.Text = (20000 - PayAmount).ToString();
                Form5 ob7 = (Form5)Application.OpenForms["Form5"];
                ob7.Close();
            }
               


        }
        



    }
}
