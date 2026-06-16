namespace Login_Screen_Project
{
    partial class frmStudentRigistration
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlMain = new Panel();
            pnlTopBar = new Panel();
            pictureBox1 = new PictureBox();
            lblAppTitle = new Label();
            lblAppSubtitle = new Label();
            pnlLeft = new Panel();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            rbMale = new RadioButton();
            lblGenderSec = new Label();
            rbFemale = new RadioButton();
            lblInfoGroup = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            btnShowCard = new Button();
            btnClear = new Button();
            btnExit = new Button();
            pnlRight = new Panel();
            progressBar1 = new ProgressBar();
            panel4 = new Panel();
            chkWM = new CheckBox();
            panel5 = new Panel();
            chkN = new CheckBox();
            lblLevelSec = new Label();
            panel6 = new Panel();
            chkDT = new CheckBox();
            panel2 = new Panel();
            chkSQL = new CheckBox();
            panel1 = new Panel();
            chkPS = new CheckBox();
            lblSkillsSec = new Label();
            pnlCSharp = new Panel();
            chkCSharp = new CheckBox();
            pnlCpp = new Panel();
            chkCpp = new CheckBox();
            pnlJS = new Panel();
            chkJS = new CheckBox();
            groupBox2 = new GroupBox();
            rbAdvanced = new RadioButton();
            rbIntermediate = new RadioButton();
            rbBeginner = new RadioButton();
            errorProvider1 = new ErrorProvider(components);
            pnlMain.SuspendLayout();
            pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlLeft.SuspendLayout();
            groupBox1.SuspendLayout();
            pnlRight.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            pnlCSharp.SuspendLayout();
            pnlCpp.SuspendLayout();
            pnlJS.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(10, 10, 26);
            pnlMain.Controls.Add(pnlTopBar);
            pnlMain.Controls.Add(pnlLeft);
            pnlMain.Controls.Add(pnlRight);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(4);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1450, 850);
            pnlMain.TabIndex = 0;
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.FromArgb(15, 14, 38);
            pnlTopBar.Controls.Add(pictureBox1);
            pnlTopBar.Controls.Add(lblAppTitle);
            pnlTopBar.Controls.Add(lblAppSubtitle);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(0, 0);
            pnlTopBar.Margin = new Padding(4);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1450, 115);
            pnlTopBar.TabIndex = 0;
            pnlTopBar.Paint += CustomPanel_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.photo_2026_06_07_19_06_40;
            pictureBox1.Location = new Point(14, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location = new Point(115, 24);
            lblAppTitle.Margin = new Padding(4, 0, 4, 0);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(442, 45);
            lblAppTitle.TabIndex = 1;
            lblAppTitle.Text = "Student Registration System";
            // 
            // lblAppSubtitle
            // 
            lblAppSubtitle.AutoSize = true;
            lblAppSubtitle.Font = new Font("Segoe UI", 10F);
            lblAppSubtitle.ForeColor = Color.FromArgb(140, 136, 185);
            lblAppSubtitle.Location = new Point(117, 69);
            lblAppSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblAppSubtitle.Name = "lblAppSubtitle";
            lblAppSubtitle.Size = new Size(396, 28);
            lblAppSubtitle.TabIndex = 2;
            lblAppSubtitle.Text = "Fill the form below to register a new student";
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(13, 12, 34);
            pnlLeft.Controls.Add(groupBox1);
            pnlLeft.Controls.Add(lblInfoGroup);
            pnlLeft.Controls.Add(lblName);
            pnlLeft.Controls.Add(txtName);
            pnlLeft.Controls.Add(lblEmail);
            pnlLeft.Controls.Add(txtEmail);
            pnlLeft.Controls.Add(lblPhone);
            pnlLeft.Controls.Add(txtPhone);
            pnlLeft.Controls.Add(btnShowCard);
            pnlLeft.Controls.Add(btnClear);
            pnlLeft.Controls.Add(btnExit);
            pnlLeft.Location = new Point(0, 115);
            pnlLeft.Margin = new Padding(4);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(680, 735);
            pnlLeft.TabIndex = 1;
            pnlLeft.Paint += pnlLeft_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Controls.Add(lblGenderSec);
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Location = new Point(35, 448);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(576, 108);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 11F);
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(394, 45);
            radioButton1.Margin = new Padding(4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(139, 34);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "other type";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Checked = true;
            rbMale.Font = new Font("Segoe UI", 11F);
            rbMale.ForeColor = Color.White;
            rbMale.Location = new Point(34, 42);
            rbMale.Margin = new Padding(4);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(86, 34);
            rbMale.TabIndex = 0;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // lblGenderSec
            // 
            lblGenderSec.AutoSize = true;
            lblGenderSec.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblGenderSec.ForeColor = Color.FromArgb(120, 115, 200);
            lblGenderSec.Location = new Point(21, 0);
            lblGenderSec.Margin = new Padding(4, 0, 4, 0);
            lblGenderSec.Name = "lblGenderSec";
            lblGenderSec.Size = new Size(87, 25);
            lblGenderSec.TabIndex = 7;
            lblGenderSec.Text = "GENDER";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Segoe UI", 11F);
            rbFemale.ForeColor = Color.White;
            rbFemale.Location = new Point(203, 45);
            rbFemale.Margin = new Padding(4);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(108, 34);
            rbFemale.TabIndex = 0;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // lblInfoGroup
            // 
            lblInfoGroup.AutoSize = true;
            lblInfoGroup.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblInfoGroup.ForeColor = Color.FromArgb(120, 115, 200);
            lblInfoGroup.Location = new Point(35, 35);
            lblInfoGroup.Margin = new Padding(4, 0, 4, 0);
            lblInfoGroup.Name = "lblInfoGroup";
            lblInfoGroup.Size = new Size(236, 25);
            lblInfoGroup.TabIndex = 0;
            lblInfoGroup.Text = "STUDENT INFORMATION";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.ForeColor = Color.FromArgb(150, 145, 190);
            lblName.Location = new Point(35, 90);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 28);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(22, 20, 54);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(35, 128);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(600, 39);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            txtName.Validating += txtName_Validating;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.ForeColor = Color.FromArgb(150, 145, 190);
            lblEmail.Location = new Point(35, 205);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 28);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(22, 20, 54);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(35, 243);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(600, 39);
            txtEmail.TabIndex = 4;
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10F);
            lblPhone.ForeColor = Color.FromArgb(150, 145, 190);
            lblPhone.Location = new Point(35, 320);
            lblPhone.Margin = new Padding(4, 0, 4, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(67, 28);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(22, 20, 54);
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 12F);
            txtPhone.ForeColor = Color.White;
            txtPhone.Location = new Point(35, 358);
            txtPhone.Margin = new Padding(4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(600, 39);
            txtPhone.TabIndex = 6;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // btnShowCard
            // 
            btnShowCard.BackColor = Color.FromArgb(110, 68, 255);
            btnShowCard.FlatAppearance.BorderSize = 0;
            btnShowCard.FlatStyle = FlatStyle.Flat;
            btnShowCard.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnShowCard.ForeColor = Color.White;
            btnShowCard.Location = new Point(35, 608);
            btnShowCard.Margin = new Padding(4);
            btnShowCard.Name = "btnShowCard";
            btnShowCard.Size = new Size(390, 62);
            btnShowCard.TabIndex = 10;
            btnShowCard.Text = "Show Card →";
            btnShowCard.UseVisualStyleBackColor = false;
            btnShowCard.Click += btnShowCard_Click_1;
            btnShowCard.Paint += CustomButton_Paint;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(32, 28, 68);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 11F);
            btnClear.ForeColor = Color.FromArgb(160, 155, 210);
            btnClear.Location = new Point(450, 608);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(95, 62);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            btnClear.Paint += CustomButton_Paint;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(150, 45, 45);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 11F);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(570, 608);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(80, 62);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            btnExit.Paint += CustomButton_Paint;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.FromArgb(10, 10, 26);
            pnlRight.Controls.Add(progressBar1);
            pnlRight.Controls.Add(panel4);
            pnlRight.Controls.Add(panel5);
            pnlRight.Controls.Add(lblLevelSec);
            pnlRight.Controls.Add(panel6);
            pnlRight.Controls.Add(panel2);
            pnlRight.Controls.Add(panel1);
            pnlRight.Controls.Add(lblSkillsSec);
            pnlRight.Controls.Add(pnlCSharp);
            pnlRight.Controls.Add(pnlCpp);
            pnlRight.Controls.Add(pnlJS);
            pnlRight.Controls.Add(groupBox2);
            pnlRight.Location = new Point(680, 115);
            pnlRight.Margin = new Padding(4);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(770, 735);
            pnlRight.TabIndex = 2;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Navy;
            progressBar1.Location = new Point(36, 674);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(703, 34);
            progressBar1.TabIndex = 1;
            progressBar1.Click += progressBar1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(30, 26, 76);
            panel4.Controls.Add(chkWM);
            panel4.Location = new Point(30, 568);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(335, 55);
            panel4.TabIndex = 9;
            // 
            // chkWM
            // 
            chkWM.AutoSize = true;
            chkWM.Font = new Font("Segoe UI", 11F);
            chkWM.ForeColor = Color.White;
            chkWM.Location = new Point(22, 10);
            chkWM.Margin = new Padding(4);
            chkWM.Name = "chkWM";
            chkWM.Size = new Size(161, 34);
            chkWM.TabIndex = 0;
            chkWM.Text = "Web/Mobile";
            chkWM.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 26, 76);
            panel5.Controls.Add(chkN);
            panel5.Location = new Point(397, 568);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(335, 55);
            panel5.TabIndex = 9;
            // 
            // chkN
            // 
            chkN.AutoSize = true;
            chkN.Font = new Font("Segoe UI", 11F);
            chkN.ForeColor = Color.White;
            chkN.Location = new Point(22, 10);
            chkN.Margin = new Padding(4);
            chkN.Name = "chkN";
            chkN.Size = new Size(83, 34);
            chkN.TabIndex = 0;
            chkN.Text = ".NET";
            chkN.UseVisualStyleBackColor = true;
            // 
            // lblLevelSec
            // 
            lblLevelSec.AutoSize = true;
            lblLevelSec.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblLevelSec.ForeColor = Color.FromArgb(120, 115, 200);
            lblLevelSec.Location = new Point(52, 30);
            lblLevelSec.Margin = new Padding(4, 0, 4, 0);
            lblLevelSec.Name = "lblLevelSec";
            lblLevelSec.Size = new Size(74, 30);
            lblLevelSec.TabIndex = 0;
            lblLevelSec.Text = "LEVEL";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(30, 26, 76);
            panel6.Controls.Add(chkDT);
            panel6.Location = new Point(397, 487);
            panel6.Margin = new Padding(4);
            panel6.Name = "panel6";
            panel6.Size = new Size(335, 55);
            panel6.TabIndex = 9;
            // 
            // chkDT
            // 
            chkDT.AutoSize = true;
            chkDT.Font = new Font("Segoe UI", 11F);
            chkDT.ForeColor = Color.White;
            chkDT.Location = new Point(22, 10);
            chkDT.Margin = new Padding(4);
            chkDT.Name = "chkDT";
            chkDT.Size = new Size(128, 34);
            chkDT.TabIndex = 0;
            chkDT.Text = "Database";
            chkDT.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 26, 76);
            panel2.Controls.Add(chkSQL);
            panel2.Location = new Point(395, 410);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(335, 55);
            panel2.TabIndex = 8;
            // 
            // chkSQL
            // 
            chkSQL.AutoSize = true;
            chkSQL.Font = new Font("Segoe UI", 11F);
            chkSQL.ForeColor = Color.White;
            chkSQL.Location = new Point(22, 10);
            chkSQL.Margin = new Padding(4);
            chkSQL.Name = "chkSQL";
            chkSQL.Size = new Size(78, 34);
            chkSQL.TabIndex = 0;
            chkSQL.Text = "SQL";
            chkSQL.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 26, 76);
            panel1.Controls.Add(chkPS);
            panel1.Location = new Point(30, 490);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 55);
            panel1.TabIndex = 8;
            // 
            // chkPS
            // 
            chkPS.AutoSize = true;
            chkPS.Font = new Font("Segoe UI", 11F);
            chkPS.ForeColor = Color.White;
            chkPS.Location = new Point(22, 10);
            chkPS.Margin = new Padding(4);
            chkPS.Name = "chkPS";
            chkPS.Size = new Size(198, 34);
            chkPS.TabIndex = 0;
            chkPS.Text = "Problem Solving";
            chkPS.UseVisualStyleBackColor = true;
            // 
            // lblSkillsSec
            // 
            lblSkillsSec.AutoSize = true;
            lblSkillsSec.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSkillsSec.ForeColor = Color.FromArgb(120, 115, 200);
            lblSkillsSec.Location = new Point(30, 295);
            lblSkillsSec.Margin = new Padding(4, 0, 4, 0);
            lblSkillsSec.Name = "lblSkillsSec";
            lblSkillsSec.Size = new Size(72, 25);
            lblSkillsSec.TabIndex = 4;
            lblSkillsSec.Text = "SKILLS";
            // 
            // pnlCSharp
            // 
            pnlCSharp.BackColor = Color.FromArgb(30, 26, 76);
            pnlCSharp.Controls.Add(chkCSharp);
            pnlCSharp.Location = new Point(30, 335);
            pnlCSharp.Margin = new Padding(4);
            pnlCSharp.Name = "pnlCSharp";
            pnlCSharp.Size = new Size(335, 55);
            pnlCSharp.TabIndex = 5;
            pnlCSharp.Paint += ContainerPanel_Paint;
            // 
            // chkCSharp
            // 
            chkCSharp.AutoSize = true;
            chkCSharp.Font = new Font("Segoe UI", 11F);
            chkCSharp.ForeColor = Color.White;
            chkCSharp.Location = new Point(22, 10);
            chkCSharp.Margin = new Padding(4);
            chkCSharp.Name = "chkCSharp";
            chkCSharp.Size = new Size(66, 34);
            chkCSharp.TabIndex = 0;
            chkCSharp.Text = "C#";
            chkCSharp.UseVisualStyleBackColor = true;
            // 
            // pnlCpp
            // 
            pnlCpp.BackColor = Color.FromArgb(30, 26, 76);
            pnlCpp.Controls.Add(chkCpp);
            pnlCpp.Location = new Point(395, 335);
            pnlCpp.Margin = new Padding(4);
            pnlCpp.Name = "pnlCpp";
            pnlCpp.Size = new Size(335, 55);
            pnlCpp.TabIndex = 6;
            pnlCpp.Paint += ContainerPanel_Paint;
            // 
            // chkCpp
            // 
            chkCpp.AutoSize = true;
            chkCpp.Font = new Font("Segoe UI", 11F);
            chkCpp.ForeColor = Color.White;
            chkCpp.Location = new Point(22, 10);
            chkCpp.Margin = new Padding(4);
            chkCpp.Name = "chkCpp";
            chkCpp.Size = new Size(83, 34);
            chkCpp.TabIndex = 0;
            chkCpp.Text = "C++";
            chkCpp.UseVisualStyleBackColor = true;
            // 
            // pnlJS
            // 
            pnlJS.BackColor = Color.FromArgb(30, 26, 76);
            pnlJS.Controls.Add(chkJS);
            pnlJS.Location = new Point(30, 410);
            pnlJS.Margin = new Padding(4);
            pnlJS.Name = "pnlJS";
            pnlJS.Size = new Size(335, 55);
            pnlJS.TabIndex = 7;
            pnlJS.Paint += ContainerPanel_Paint;
            // 
            // chkJS
            // 
            chkJS.AutoSize = true;
            chkJS.Font = new Font("Segoe UI", 11F);
            chkJS.ForeColor = Color.White;
            chkJS.Location = new Point(22, 10);
            chkJS.Margin = new Padding(4);
            chkJS.Name = "chkJS";
            chkJS.Size = new Size(216, 34);
            chkJS.TabIndex = 0;
            chkJS.Text = "html,css,JavaScript";
            chkJS.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbAdvanced);
            groupBox2.Controls.Add(rbIntermediate);
            groupBox2.Controls.Add(rbBeginner);
            groupBox2.Location = new Point(30, 35);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(709, 232);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            // 
            // rbAdvanced
            // 
            rbAdvanced.AutoSize = true;
            rbAdvanced.Font = new Font("Segoe UI", 11F);
            rbAdvanced.ForeColor = Color.White;
            rbAdvanced.Location = new Point(34, 164);
            rbAdvanced.Margin = new Padding(4);
            rbAdvanced.Name = "rbAdvanced";
            rbAdvanced.Size = new Size(134, 34);
            rbAdvanced.TabIndex = 0;
            rbAdvanced.Text = "Advanced";
            rbAdvanced.UseVisualStyleBackColor = true;
            // 
            // rbIntermediate
            // 
            rbIntermediate.AutoSize = true;
            rbIntermediate.Font = new Font("Segoe UI", 11F);
            rbIntermediate.ForeColor = Color.White;
            rbIntermediate.Location = new Point(34, 110);
            rbIntermediate.Margin = new Padding(4);
            rbIntermediate.Name = "rbIntermediate";
            rbIntermediate.Size = new Size(162, 34);
            rbIntermediate.TabIndex = 0;
            rbIntermediate.Text = "Intermediate";
            rbIntermediate.UseVisualStyleBackColor = true;
            rbIntermediate.CheckedChanged += rbIntermediate_CheckedChanged;
            // 
            // rbBeginner
            // 
            rbBeginner.AutoSize = true;
            rbBeginner.Checked = true;
            rbBeginner.Font = new Font("Segoe UI", 11F);
            rbBeginner.ForeColor = Color.White;
            rbBeginner.Location = new Point(34, 55);
            rbBeginner.Margin = new Padding(4);
            rbBeginner.Name = "rbBeginner";
            rbBeginner.Size = new Size(125, 34);
            rbBeginner.TabIndex = 0;
            rbBeginner.TabStop = true;
            rbBeginner.Text = "Beginner";
            rbBeginner.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmStudentRigistration
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 850);
            Controls.Add(pnlMain);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmStudentRigistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Registration System";
            pnlMain.ResumeLayout(false);
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlCSharp.ResumeLayout(false);
            pnlCSharp.PerformLayout();
            pnlCpp.ResumeLayout(false);
            pnlCpp.PerformLayout();
            pnlJS.ResumeLayout(false);
            pnlJS.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // (بقيت الدوال الرسومية المخصصة في مكانها بالأسفل بدون تعديل لتعمل تلقائياً)
        private System.Drawing.Drawing2D.GraphicsPath GetRoundRectPath(int x, int y, int width, int height, int radius)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(x, y, radius, radius, 180, 90);
            path.AddArc(x + width - radius, y, radius, radius, 270, 90);
            path.AddArc(x + width - radius, y + height - radius, radius, radius, 0, 90);
            path.AddArc(x, y + height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            return path;
        }

        private void ContainerPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (var path = GetRoundRectPath(0, 0, panel.Width - 1, panel.Height - 1, 10))
            {
                using (var brush = new SolidBrush(panel.BackColor))
                    e.Graphics.FillPath(brush, path);
                using (var pen = new Pen(Color.FromArgb(45, 40, 90), 1))
                    e.Graphics.DrawPath(pen, path);
            }
        }

        private void ContainerPanel_ActivePaint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (var path = GetRoundRectPath(0, 0, panel.Width - 1, panel.Height - 1, 10))
            {
                using (var brush = new SolidBrush(panel.BackColor))
                    e.Graphics.FillPath(brush, path);
                using (var pen = new Pen(Color.FromArgb(110, 68, 255), 1.5f)) // لون حواف مضيئة يطابق الصورة الأولى تماماً
                    e.Graphics.DrawPath(pen, path);
            }
        }

        private void CustomButton_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (var path = GetRoundRectPath(0, 0, btn.Width - 1, btn.Height - 1, 12))
            {
                using (var brush = new SolidBrush(btn.BackColor))
                    e.Graphics.FillPath(brush, path);

                TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font,
                    new Rectangle(0, 0, btn.Width, btn.Height), btn.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }

        private void CustomPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel pnl = (Panel)sender;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (var pen = new Pen(Color.FromArgb(35, 30, 75), 1))
                e.Graphics.DrawLine(pen, 0, pnl.Height - 1, pnl.Width, pnl.Height - 1);
        }

        private void RoundIcon_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (var path = GetRoundRectPath(0, 0, pic.Width - 1, pic.Height - 1, 14))
            {
                using (var brush = new SolidBrush(pic.BackColor))
                    e.Graphics.FillPath(brush, path);
            }
        }

        private Panel pnlMain;
        private Panel pnlTopBar;
        private Label lblAppTitle;
        private Label lblAppSubtitle;
        private Panel pnlLeft;
        private Label lblInfoGroup;
        private Label lblName;
        private TextBox txtName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblGenderSec;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private Button btnShowCard;
        private Button btnClear;
        private Button btnExit;
        private RadioButton radioButton1;
        private PictureBox pictureBox1;
        private ErrorProvider errorProvider1;
        private GroupBox groupBox1;
        private Panel pnlRight;
        private ProgressBar progressBar1;
        private Panel panel4;
        private CheckBox chkWM;
        private Panel panel5;
        private CheckBox chkN;
        private Label lblLevelSec;
        private Panel panel6;
        private CheckBox chkDT;
        private Panel panel2;
        private CheckBox chkSQL;
        private Panel panel1;
        private CheckBox chkPS;
        private Label lblSkillsSec;
        private Panel pnlCSharp;
        private CheckBox chkCSharp;
        private Panel pnlCpp;
        private CheckBox chkCpp;
        private Panel pnlJS;
        private CheckBox chkJS;
        private GroupBox groupBox2;
        private RadioButton rbAdvanced;
        private RadioButton rbIntermediate;
        private RadioButton rbBeginner;
    }
}