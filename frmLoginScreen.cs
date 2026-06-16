using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Login_Screen_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        short SignCounter = 0;
        short Counter = 30;

        void TimeWaiting()
        {

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            btnLogin.Enabled = false;
            timer1.Enabled = true;
            Counter--;
          
            lbTimeWaitnig.Text = Counter.ToString();

            if (Counter == 0)
            {
                timer1.Enabled = false;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                btnLogin.Enabled = true;
                lbTimeWaitnig.Text = "";
            }

           

        }
        void SignCounterCheck()
        {
            if (SignCounter == 3)
            {
                TimeWaiting();
                
            }
            
        }
        Form frmSR = new frmStudentRigistration();
        
        void InfoValidate()
        {
            if (textBox1.Text == textBox1.Tag.ToString() && textBox2.Text == textBox2.Tag.ToString())
            {

                frmSR.ShowDialog();
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                SignCounter++;
                MessageBox.Show("Login Fields,Try again");
                SignCounterCheck();
            }
        }

        void CheckErrorValidate(object sender, CancelEventArgs e,string Message)
        {
            if (string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                e.Cancel = true;
                ((TextBox)sender).Focus();
                errorProvider1.SetError(((TextBox)sender), Message);
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(((TextBox)sender), "");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            InfoValidate();
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void textBox1_Validated(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            CheckErrorValidate(sender, e, "Your Email is Wrong");
        }
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            CheckErrorValidate(sender, e, "Your Password is Wrong");
        }
        private void label3_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0'; // إظهار الكلمة
            }
            else
            {
                textBox2.PasswordChar = '*'; // إخفاء الكلمة
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            SignCounterCheck();
        }
    }
}