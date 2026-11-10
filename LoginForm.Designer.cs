namespace student_managment_system
{
    partial class frmLoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginForm));
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            pnlLeft = new Panel();
            picLogo = new PictureBox();
            lblDescription = new Label();
            lblManagmentSystem = new Label();
            lblStudent = new Label();
            lblWelcome = new Label();
            lblSubtitle = new Label();
            chkRemember = new CheckBox();
            btnExit = new Button();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(771, 264);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(375, 31);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(771, 371);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(375, 31);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(771, 302);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(436, 37);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(771, 408);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(436, 37);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(31, 45, 75);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(771, 527);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(438, 56);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(31, 45, 75);
            pnlLeft.Controls.Add(picLogo);
            pnlLeft.Controls.Add(lblDescription);
            pnlLeft.Controls.Add(lblManagmentSystem);
            pnlLeft.Controls.Add(lblStudent);
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Margin = new Padding(4);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(400, 1042);
            pnlLeft.TabIndex = 5;
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.Top;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(144, 116);
            picLogo.Margin = new Padding(4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(125, 125);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 3;
            picLogo.TabStop = false;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.ForeColor = Color.Gainsboro;
            lblDescription.Location = new Point(70, 434);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(260, 25);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Manage your academic journey";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblManagmentSystem
            // 
            lblManagmentSystem.Anchor = AnchorStyles.Top;
            lblManagmentSystem.AutoSize = true;
            lblManagmentSystem.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblManagmentSystem.ForeColor = Color.White;
            lblManagmentSystem.Location = new Point(26, 370);
            lblManagmentSystem.Margin = new Padding(4, 0, 4, 0);
            lblManagmentSystem.Name = "lblManagmentSystem";
            lblManagmentSystem.Size = new Size(321, 38);
            lblManagmentSystem.TabIndex = 1;
            lblManagmentSystem.Text = "MANAGMENT SYSTEM";
            lblManagmentSystem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStudent
            // 
            lblStudent.Anchor = AnchorStyles.Top;
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblStudent.ForeColor = Color.White;
            lblStudent.Location = new Point(13, 302);
            lblStudent.Margin = new Padding(4, 0, 4, 0);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(369, 54);
            lblStudent.TabIndex = 0;
            lblStudent.Text = "STUDENT GRADES";
            lblStudent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(31, 45, 75);
            lblWelcome.Location = new Point(771, 127);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(438, 62);
            lblWelcome.TabIndex = 6;
            lblWelcome.Text = "Welcome Back!";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(771, 189);
            lblSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(375, 31);
            lblSubtitle.TabIndex = 7;
            lblSubtitle.Text = "Please login to your account";
            // 
            // chkRemember
            // 
            chkRemember.Location = new Point(771, 471);
            chkRemember.Margin = new Padding(4);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(188, 31);
            chkRemember.TabIndex = 8;
            chkRemember.Text = "Remember me";
            chkRemember.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.DarkRed;
            btnExit.Location = new Point(771, 589);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(438, 38);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmLoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1611, 1040);
            Controls.Add(btnExit);
            Controls.Add(chkRemember);
            Controls.Add(lblSubtitle);
            Controls.Add(lblWelcome);
            Controls.Add(lblUsername);
            Controls.Add(pnlLeft);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmLoginForm";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Panel pnlLeft;
        private Label lblDescription;
        private Label lblManagmentSystem;
        private Label lblStudent;
        private Label lblWelcome;
        private Label lblSubtitle;
        private CheckBox chkRemember;
        private Button btnExit;
        private PictureBox picLogo;
    }
}
