using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Screen_Project
{
    public partial class frmStudentRigistration : Form
    {


        public frmStudentRigistration()
        {

            InitializeComponent();
        }

        public static string Name = "";
        public static string Email = "";
        public static string Phone = "";
        public static string Gender = "";
        public static string Level = "";
        public static string Skills = "";

        void CardInfo()
        {
            Name = txtName.Text;
            Email = txtEmail.Text;
            Phone = txtPhone.Text;
            Gender = gender();
            Level = level();
            skills();
        }

        Form frmSC = new frmStudentCard();

        void BrogressBarFill()
        {
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;

            btnShowCard.Enabled = false;
            btnExit.Enabled = false;
            btnClear.Enabled = false;
            CardInfo();

            for (int i = 1; i <= 10; i++)
            {
                if (progressBar1.Value < progressBar1.Maximum)
                {
                    Thread.Sleep(500);
                    progressBar1.Value += 10;
                }
            }
            frmSC.ShowDialog();

            btnExit.Enabled = true;
            btnClear.Enabled = true;
            progressBar1.Value = 0;
            btnShowCard.Enabled = true;
        }
        void ClearMode()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            rbMale.Checked = true;
            rbBeginner.Checked = true;
            rbIntermediate.Checked = false;
            rbAdvanced.Checked = false;
            chkCSharp.Checked = false;
            chkCpp.Checked = false;
            chkJS.Checked = false;
            chkDT.Checked = false;
            chkN.Checked = false;
            chkWM.Checked = false;
            chkPS.Checked = false;
            chkSQL.Checked = false;

        }
        void CheckErrorValidate(object sender, CancelEventArgs e, string Message)
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
        string gender()
        {
            if (rbMale.Checked)
            {
                return "Male";
            }
            else if (rbFemale.Checked)
            {
                return "Female";
            }
            else
            {
                return "Other Type";
            }
        }
        string level()
        {
            if (rbBeginner.Checked)
            {
                return "Beginner";
            }
            else if (rbIntermediate.Checked)
            {
                return "Intermediate";
            }
            else
            {
                return "Advanced";
            }
        }
        void skills()
        {
            if (chkCSharp.Checked)
            {
                Skills += "  C#";
            }
            if (chkCpp.Checked)
            {
                Skills += "  C++";
            }
            if (chkDT.Checked)
            {
                Skills += "  Database";
            }
            if (chkJS.Checked)
            {
                Skills += "  html,css,JavaScript";
            }
            if (chkPS.Checked)
            {
                Skills += "  Problem Solving";
            }
            if (chkSQL.Checked)
            {
                Skills += "  SQL";
            }
            if (chkWM.Checked)
            {
                Skills += "  Web/Mobile";
            }
            if (chkN.Checked)
            {
                Skills += "  .Net";
            }
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            CheckErrorValidate(((TextBox)sender), e, "Enter your name");
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            CheckErrorValidate(((TextBox)sender), e, "Enter your Email");
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            CheckErrorValidate(((TextBox)sender), e, "Enter your Phone");
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnShowCard_Click(object sender, EventArgs e)
        {

        }

        private void rbIntermediate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnShowCard_Click_1(object sender, EventArgs e)
        {
            BrogressBarFill();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearMode();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 loginForm = new Form1();
            loginForm.Show();



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
