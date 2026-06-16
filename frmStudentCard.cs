using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Screen_Project
{
    public partial class frmStudentCard : Form
    {
        public frmStudentCard()
        {
            InitializeComponent();
        }

        void PrintStudentCard()
        {







        }

        private void lblGenVal_Click(object sender, EventArgs e)
        {

        }

        private void lblSideName_Click(object sender, EventArgs e)
        {
        }

        private void lblValName_Click(object sender, EventArgs e)
        {

        }

        private void lblValEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblValPhone_Click(object sender, EventArgs e)
        {

        }

        private void lblLevVal_Click(object sender, EventArgs e)
        {

        }

        private void lblSkVal_Click(object sender, EventArgs e)
        {
        }

        private void btnExitTop_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void lblTitleName_Click(object sender, EventArgs e)
        {

        }

        private void frmStudentCard_Load(object sender, EventArgs e)
        {
            lblValName.Text = frmStudentRigistration.Name;
            lblSideName.Text = frmStudentRigistration.Name;
            lblValEmail.Text = frmStudentRigistration.Email;
            lblValPhone.Text = frmStudentRigistration.Phone;
            lblLevVal.Text = frmStudentRigistration.Level;
            lblGenVal.Text = frmStudentRigistration.Gender;
            lblSkVal.Text = frmStudentRigistration.Skills;
        }

        private void lblSkVal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
