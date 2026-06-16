namespace Login_Screen_Project
{
    partial class frmStudentCard
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
            pnlSidebar = new Panel();
            pbAvatar = new PictureBox();
            lblSideName = new Label();
            lblSideRole = new Label();
            lblQuote = new Label();
            lblMainTitle = new Label();
            pnlLine = new Panel();
            pnlGender = new Panel();
            lblGenTitle = new Label();
            lblGenVal = new Label();
            pnlLevel = new Panel();
            lblLevTitle = new Label();
            lblLevVal = new Label();
            pnlSkills = new Panel();
            lblSkVal = new TextBox();
            lblSkTitle = new Label();
            lblTitleName = new Label();
            lblValName = new Label();
            lblTitleEmail = new Label();
            lblValEmail = new Label();
            lblTitlePhone = new Label();
            lblValPhone = new Label();
            btnExitTop = new Button();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            pnlGender.SuspendLayout();
            pnlLevel.SuspendLayout();
            pnlSkills.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(34, 26, 115);
            pnlSidebar.Controls.Add(pbAvatar);
            pnlSidebar.Controls.Add(lblSideName);
            pnlSidebar.Controls.Add(lblSideRole);
            pnlSidebar.Controls.Add(lblQuote);
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(180, 430);
            pnlSidebar.TabIndex = 0;
            // 
            // pbAvatar
            // 
            pbAvatar.BackColor = Color.FromArgb(50, 40, 150);
            pbAvatar.Image = Properties.Resources.photo_2026_06_07_19_06_40;
            pbAvatar.Location = new Point(45, 40);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(90, 90);
            pbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pbAvatar.TabIndex = 0;
            pbAvatar.TabStop = false;
            // 
            // lblSideName
            // 
            lblSideName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSideName.ForeColor = Color.White;
            lblSideName.Location = new Point(10, 145);
            lblSideName.Name = "lblSideName";
            lblSideName.Size = new Size(160, 25);
            lblSideName.TabIndex = 1;
            lblSideName.TextAlign = ContentAlignment.MiddleCenter;
            lblSideName.Click += lblSideName_Click;
            // 
            // lblSideRole
            // 
            lblSideRole.Font = new Font("Segoe UI", 9.5F);
            lblSideRole.ForeColor = Color.FromArgb(168, 159, 204);
            lblSideRole.Location = new Point(10, 177);
            lblSideRole.Name = "lblSideRole";
            lblSideRole.Size = new Size(160, 20);
            lblSideRole.TabIndex = 2;
            lblSideRole.Text = "Student";
            lblSideRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQuote
            // 
            lblQuote.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblQuote.ForeColor = Color.FromArgb(120, 115, 150);
            lblQuote.Location = new Point(10, 310);
            lblQuote.Name = "lblQuote";
            lblQuote.Size = new Size(160, 60);
            lblQuote.TabIndex = 3;
            lblQuote.Text = "\"Education is the most powerful weapon you can use to change the world.\"";
            lblQuote.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMainTitle
            // 
            lblMainTitle.AutoSize = true;
            lblMainTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMainTitle.ForeColor = Color.White;
            lblMainTitle.Location = new Point(210, 28);
            lblMainTitle.Name = "lblMainTitle";
            lblMainTitle.Size = new Size(257, 32);
            lblMainTitle.TabIndex = 1;
            lblMainTitle.Text = "Personal Information";
            // 
            // pnlLine
            // 
            pnlLine.BackColor = Color.FromArgb(168, 159, 204);
            pnlLine.Location = new Point(220, 63);
            pnlLine.Name = "pnlLine";
            pnlLine.Size = new Size(243, 10);
            pnlLine.TabIndex = 0;
            // 
            // pnlGender
            // 
            pnlGender.BackColor = Color.FromArgb(5, 54, 31);
            pnlGender.Controls.Add(lblGenTitle);
            pnlGender.Controls.Add(lblGenVal);
            pnlGender.Location = new Point(539, 83);
            pnlGender.Name = "pnlGender";
            pnlGender.Size = new Size(185, 63);
            pnlGender.TabIndex = 8;
            // 
            // lblGenTitle
            // 
            lblGenTitle.AutoSize = true;
            lblGenTitle.Font = new Font("Segoe UI", 8F);
            lblGenTitle.ForeColor = Color.LightGreen;
            lblGenTitle.Location = new Point(8, 3);
            lblGenTitle.Name = "lblGenTitle";
            lblGenTitle.Size = new Size(61, 21);
            lblGenTitle.TabIndex = 0;
            lblGenTitle.Text = "Gender";
            // 
            // lblGenVal
            // 
            lblGenVal.AutoSize = true;
            lblGenVal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblGenVal.ForeColor = Color.White;
            lblGenVal.Location = new Point(8, 24);
            lblGenVal.Name = "lblGenVal";
            lblGenVal.Size = new Size(0, 30);
            lblGenVal.TabIndex = 1;
            lblGenVal.Click += lblGenVal_Click;
            // 
            // pnlLevel
            // 
            pnlLevel.BackColor = Color.FromArgb(74, 43, 2);
            pnlLevel.Controls.Add(lblLevTitle);
            pnlLevel.Controls.Add(lblLevVal);
            pnlLevel.Location = new Point(539, 167);
            pnlLevel.Name = "pnlLevel";
            pnlLevel.Size = new Size(185, 68);
            pnlLevel.TabIndex = 9;
            // 
            // lblLevTitle
            // 
            lblLevTitle.AutoSize = true;
            lblLevTitle.Font = new Font("Segoe UI", 8F);
            lblLevTitle.ForeColor = Color.Orange;
            lblLevTitle.Location = new Point(8, 6);
            lblLevTitle.Name = "lblLevTitle";
            lblLevTitle.Size = new Size(46, 21);
            lblLevTitle.TabIndex = 0;
            lblLevTitle.Text = "Level";
            // 
            // lblLevVal
            // 
            lblLevVal.AutoSize = true;
            lblLevVal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblLevVal.ForeColor = Color.White;
            lblLevVal.Location = new Point(8, 24);
            lblLevVal.Name = "lblLevVal";
            lblLevVal.Size = new Size(0, 30);
            lblLevVal.TabIndex = 1;
            lblLevVal.Click += lblLevVal_Click;
            // 
            // pnlSkills
            // 
            pnlSkills.BackColor = Color.FromArgb(12, 33, 61);
            pnlSkills.Controls.Add(lblSkVal);
            pnlSkills.Controls.Add(lblSkTitle);
            pnlSkills.Location = new Point(539, 253);
            pnlSkills.Name = "pnlSkills";
            pnlSkills.Size = new Size(401, 165);
            pnlSkills.TabIndex = 10;
            // 
            // lblSkVal
            // 
            lblSkVal.BackColor = Color.FromArgb(12, 33, 61);
            lblSkVal.BorderStyle = BorderStyle.None;
            lblSkVal.Font = new Font("Segoe UI", 11F);
            lblSkVal.ForeColor = Color.White;
            lblSkVal.Location = new Point(15, 42);
            lblSkVal.Multiline = true;
            lblSkVal.Name = "lblSkVal";
            lblSkVal.Size = new Size(373, 90);
            lblSkVal.TabIndex = 1;
            lblSkVal.TextChanged += lblSkVal_TextChanged;
            // 
            // lblSkTitle
            // 
            lblSkTitle.AutoSize = true;
            lblSkTitle.Font = new Font("Segoe UI", 8F);
            lblSkTitle.ForeColor = Color.DodgerBlue;
            lblSkTitle.Location = new Point(8, 6);
            lblSkTitle.Name = "lblSkTitle";
            lblSkTitle.Size = new Size(78, 21);
            lblSkTitle.TabIndex = 0;
            lblSkTitle.Text = "</> Skills";
            // 
            // lblTitleName
            // 
            lblTitleName.AutoSize = true;
            lblTitleName.Font = new Font("Segoe UI", 8.5F);
            lblTitleName.ForeColor = Color.FromArgb(168, 159, 204);
            lblTitleName.Location = new Point(215, 89);
            lblTitleName.Name = "lblTitleName";
            lblTitleName.Size = new Size(56, 23);
            lblTitleName.TabIndex = 2;
            lblTitleName.Text = "Name";
            lblTitleName.Click += lblTitleName_Click;
            // 
            // lblValName
            // 
            lblValName.AutoSize = true;
            lblValName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblValName.ForeColor = Color.White;
            lblValName.Location = new Point(222, 116);
            lblValName.Name = "lblValName";
            lblValName.Size = new Size(0, 30);
            lblValName.TabIndex = 3;
            lblValName.Click += lblValName_Click;
            // 
            // lblTitleEmail
            // 
            lblTitleEmail.AutoSize = true;
            lblTitleEmail.Font = new Font("Segoe UI", 8.5F);
            lblTitleEmail.ForeColor = Color.FromArgb(168, 159, 204);
            lblTitleEmail.Location = new Point(220, 167);
            lblTitleEmail.Name = "lblTitleEmail";
            lblTitleEmail.Size = new Size(51, 23);
            lblTitleEmail.TabIndex = 4;
            lblTitleEmail.Text = "Email";
            // 
            // lblValEmail
            // 
            lblValEmail.AutoSize = true;
            lblValEmail.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblValEmail.ForeColor = Color.White;
            lblValEmail.Location = new Point(232, 208);
            lblValEmail.Name = "lblValEmail";
            lblValEmail.Size = new Size(0, 30);
            lblValEmail.TabIndex = 5;
            lblValEmail.Click += lblValEmail_Click;
            // 
            // lblTitlePhone
            // 
            lblTitlePhone.AutoSize = true;
            lblTitlePhone.Font = new Font("Segoe UI", 8.5F);
            lblTitlePhone.ForeColor = Color.FromArgb(168, 159, 204);
            lblTitlePhone.Location = new Point(220, 259);
            lblTitlePhone.Name = "lblTitlePhone";
            lblTitlePhone.Size = new Size(59, 23);
            lblTitlePhone.TabIndex = 6;
            lblTitlePhone.Text = "Phone";
            // 
            // lblValPhone
            // 
            lblValPhone.AutoSize = true;
            lblValPhone.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblValPhone.ForeColor = Color.White;
            lblValPhone.Location = new Point(220, 290);
            lblValPhone.Name = "lblValPhone";
            lblValPhone.Size = new Size(0, 30);
            lblValPhone.TabIndex = 7;
            lblValPhone.Click += lblValPhone_Click;
            // 
            // btnExitTop
            // 
            btnExitTop.BackColor = Color.Maroon;
            btnExitTop.FlatAppearance.BorderSize = 0;
            btnExitTop.FlatStyle = FlatStyle.Flat;
            btnExitTop.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExitTop.ForeColor = Color.White;
            btnExitTop.Location = new Point(905, 10);
            btnExitTop.Name = "btnExitTop";
            btnExitTop.Size = new Size(35, 30);
            btnExitTop.TabIndex = 11;
            btnExitTop.Text = "X";
            btnExitTop.UseVisualStyleBackColor = false;
            btnExitTop.Click += btnExitTop_Click;
            // 
            // frmStudentCard
            // 
            BackColor = Color.FromArgb(16, 11, 41);
            ClientSize = new Size(954, 430);
            Controls.Add(btnExitTop);
            Controls.Add(pnlLine);
            Controls.Add(lblMainTitle);
            Controls.Add(lblTitleName);
            Controls.Add(lblValName);
            Controls.Add(lblTitleEmail);
            Controls.Add(lblValEmail);
            Controls.Add(lblTitlePhone);
            Controls.Add(lblValPhone);
            Controls.Add(pnlGender);
            Controls.Add(pnlLevel);
            Controls.Add(pnlSkills);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "frmStudentCard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Information Card";
            Load += frmStudentCard_Load;
            pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            pnlGender.ResumeLayout(false);
            pnlGender.PerformLayout();
            pnlLevel.ResumeLayout(false);
            pnlLevel.PerformLayout();
            pnlSkills.ResumeLayout(false);
            pnlSkills.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Label lblSideName;
        private System.Windows.Forms.Label lblSideRole;
        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Panel pnlGender;
        private System.Windows.Forms.Label lblGenTitle;
        private System.Windows.Forms.Label lblGenVal;
        private System.Windows.Forms.Panel pnlLevel;
        private System.Windows.Forms.Label lblLevTitle;
        private System.Windows.Forms.Label lblLevVal;
        private System.Windows.Forms.Panel pnlSkills;
        private System.Windows.Forms.Label lblSkTitle;

        private System.Windows.Forms.Label lblTitleName;
        private System.Windows.Forms.Label lblValName;
        private System.Windows.Forms.Label lblTitleEmail;
        private System.Windows.Forms.Label lblValEmail;
        private System.Windows.Forms.Label lblTitlePhone;
        private System.Windows.Forms.Label lblValPhone;
        private System.Windows.Forms.Button btnExitTop;
        private TextBox lblSkVal;
    }
}