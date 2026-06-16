namespace Login_Screen_Project
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelLeft = new Panel();
            lblAppName = new Label();
            lblTagline = new Label();
            feat1 = new Label();
            feat2 = new Label();
            feat3 = new Label();
            panelRight = new Panel();
            lbTimeWaitnig = new Label();
            label3 = new Label();
            btnClose = new Button();
            lblWelcome = new Label();
            lblSubtitle = new Label();
            lblUserTag = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            lblPassTag = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            btnLogin = new Button();
            lblStatus = new Label();
            errorProvider1 = new ErrorProvider(components);
            timer1 = new System.Windows.Forms.Timer(components);
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(15, 23, 42);
            panelLeft.BackgroundImage = Properties.Resources.photo_2026_06_05_17_44_31;
            panelLeft.BackgroundImageLayout = ImageLayout.Stretch;
            panelLeft.Controls.Add(lblAppName);
            panelLeft.Controls.Add(lblTagline);
            panelLeft.Controls.Add(feat1);
            panelLeft.Controls.Add(feat2);
            panelLeft.Controls.Add(feat3);
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(300, 500);
            panelLeft.TabIndex = 0;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.BackColor = Color.Transparent;
            lblAppName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(40, 19);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(222, 48);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "SecurePanel";
            // 
            // lblTagline
            // 
            lblTagline.BackColor = Color.Transparent;
            lblTagline.Font = new Font("Segoe UI", 9.5F);
            lblTagline.ForeColor = Color.FromArgb(148, 163, 184);
            lblTagline.Location = new Point(40, 83);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(220, 50);
            lblTagline.TabIndex = 1;
            lblTagline.Text = "Your all-in-one admin workspace.\nSign in to continue.";
            // 
            // feat1
            // 
            feat1.BackColor = Color.Transparent;
            feat1.Font = new Font("Segoe UI", 9.5F);
            feat1.ForeColor = Color.FromArgb(192, 132, 252);
            feat1.Location = new Point(40, 370);
            feat1.Name = "feat1";
            feat1.Size = new Size(220, 30);
            feat1.TabIndex = 2;
            feat1.Text = "⚡  Fast & secure access";
            // 
            // feat2
            // 
            feat2.BackColor = Color.Transparent;
            feat2.Font = new Font("Segoe UI", 9.5F);
            feat2.ForeColor = Color.FromArgb(192, 132, 252);
            feat2.Location = new Point(40, 400);
            feat2.Name = "feat2";
            feat2.Size = new Size(220, 30);
            feat2.TabIndex = 3;
            feat2.Text = "🖥   Multi-device support";
            // 
            // feat3
            // 
            feat3.BackColor = Color.Transparent;
            feat3.Font = new Font("Segoe UI", 9.5F);
            feat3.ForeColor = Color.FromArgb(192, 132, 252);
            feat3.Location = new Point(42, 430);
            feat3.Name = "feat3";
            feat3.Size = new Size(220, 30);
            feat3.TabIndex = 4;
            feat3.Text = "🔒  End-to-end encrypted";
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.FromArgb(248, 250, 252);
            panelRight.BackgroundImageLayout = ImageLayout.Zoom;
            panelRight.Controls.Add(lbTimeWaitnig);
            panelRight.Controls.Add(label3);
            panelRight.Controls.Add(btnClose);
            panelRight.Controls.Add(lblWelcome);
            panelRight.Controls.Add(lblSubtitle);
            panelRight.Controls.Add(lblUserTag);
            panelRight.Controls.Add(label1);
            panelRight.Controls.Add(textBox1);
            panelRight.Controls.Add(lblPassTag);
            panelRight.Controls.Add(label2);
            panelRight.Controls.Add(textBox2);
            panelRight.Controls.Add(btnLogin);
            panelRight.Controls.Add(lblStatus);
            panelRight.Location = new Point(300, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(520, 500);
            panelRight.TabIndex = 1;
            panelRight.Paint += panelRight_Paint;
            // 
            // lbTimeWaitnig
            // 
            lbTimeWaitnig.AutoSize = true;
            lbTimeWaitnig.BackColor = Color.Transparent;
            lbTimeWaitnig.Font = new Font("Segoe UI", 10F);
            lbTimeWaitnig.ForeColor = Color.Black;
            lbTimeWaitnig.Location = new Point(389, 254);
            lbTimeWaitnig.Name = "lbTimeWaitnig";
            lbTimeWaitnig.Size = new Size(0, 28);
            lbTimeWaitnig.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.FromArgb(148, 163, 184);
            label3.Location = new Point(465, 254);
            label3.Name = "label3";
            label3.Size = new Size(43, 30);
            label3.TabIndex = 9;
            label3.Text = "👁";
            label3.Click += label3_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F);
            btnClose.ForeColor = Color.FromArgb(100, 116, 139);
            btnClose.Location = new Point(487, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 0;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(15, 23, 42);
            lblWelcome.Location = new Point(60, 67);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(237, 45);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome back";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtitle.Location = new Point(60, 112);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(207, 25);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Sign in to your account";
            // 
            // lblUserTag
            // 
            lblUserTag.AutoSize = true;
            lblUserTag.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblUserTag.ForeColor = Color.FromArgb(124, 58, 237);
            lblUserTag.Location = new Point(60, 163);
            lblUserTag.Name = "lblUserTag";
            lblUserTag.Size = new Size(53, 21);
            lblUserTag.TabIndex = 3;
            lblUserTag.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(148, 163, 184);
            label1.Location = new Point(11, 178);
            label1.Name = "label1";
            label1.Size = new Size(47, 32);
            label1.TabIndex = 4;
            label1.Text = "✉";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 10.5F);
            textBox1.ForeColor = Color.FromArgb(15, 23, 42);
            textBox1.Location = new Point(60, 178);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter your email";
            textBox1.Size = new Size(380, 35);
            textBox1.TabIndex = 0;
            textBox1.Tag = "MyEmail@gmail.com";
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.MouseLeave += textBox1_MouseLeave;
            textBox1.Validating += textBox1_Validating;
            textBox1.Validated += textBox1_Validated;
            // 
            // lblPassTag
            // 
            lblPassTag.AutoSize = true;
            lblPassTag.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPassTag.ForeColor = Color.FromArgb(124, 58, 237);
            lblPassTag.Location = new Point(60, 233);
            lblPassTag.Name = "lblPassTag";
            lblPassTag.Size = new Size(98, 21);
            lblPassTag.TabIndex = 5;
            lblPassTag.Text = "PASSWORD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.FromArgb(148, 163, 184);
            label2.Location = new Point(15, 254);
            label2.Name = "label2";
            label2.Size = new Size(43, 30);
            label2.TabIndex = 6;
            label2.Text = "🔒";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 10.5F);
            textBox2.ForeColor = Color.FromArgb(15, 23, 42);
            textBox2.Location = new Point(60, 252);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Enter your password";
            textBox2.Size = new Size(380, 35);
            textBox2.TabIndex = 1;
            textBox2.Tag = "AissamDji";
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Validating += textBox2_Validating;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(124, 58, 237);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 40, 217);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(60, 339);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(380, 42);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Sign In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 9.5F);
            lblStatus.ForeColor = Color.FromArgb(225, 29, 72);
            lblStatus.Location = new Point(60, 384);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(380, 24);
            lblStatus.TabIndex = 8;
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(820, 500);
            Controls.Add(panelLeft);
            Controls.Add(panelRight);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // ── Field declarations ────────────────────────────────────
        private Panel panelLeft;
        private Panel panelRight;
        private Label lblAppName;
        private Label lblTagline;
        private Label feat1;
        private Label feat2;
        private Label feat3;
        private Label lblWelcome;
        private Label lblSubtitle;
        private Label lblUserTag;
        private Label lblPassTag;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private Label lblStatus;
        private Button btnClose;
        private Label label3;
        private ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
        private Label lbTimeWaitnig;
    }
}