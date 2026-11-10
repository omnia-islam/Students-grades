namespace Grades
{
    partial class GradesForm
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
            pnlSidebar = new Panel();
            LogoutIcon = new PictureBox();
            btnLogout = new Button();
            GradesIcon = new PictureBox();
            ReportsIcon = new PictureBox();
            CoursesIcon = new PictureBox();
            DashboardIcon = new PictureBox();
            LogoIcon = new PictureBox();
            btnDashboard = new Button();
            btnReports = new Button();
            btnGrades = new Button();
            btnCourses = new Button();
            lblSystemName = new Label();
            pnlHeader = new Panel();
            lblDatabaseStatus = new Label();
            AdminIcon = new PictureBox();
            lblWelcomeBack = new Label();
            lblAdminName = new Label();
            lblPageTitle = new Label();
            btnMenu = new Button();
            pictureBox1 = new PictureBox();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoutIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GradesIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ReportsIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CoursesIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DashboardIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoIcon).BeginInit();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdminIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(31, 45, 75);
            pnlSidebar.Controls.Add(LogoutIcon);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(GradesIcon);
            pnlSidebar.Controls.Add(ReportsIcon);
            pnlSidebar.Controls.Add(CoursesIcon);
            pnlSidebar.Controls.Add(DashboardIcon);
            pnlSidebar.Controls.Add(LogoIcon);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(btnReports);
            pnlSidebar.Controls.Add(btnGrades);
            pnlSidebar.Controls.Add(btnCourses);
            pnlSidebar.Controls.Add(lblSystemName);
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(258, 1039);
            pnlSidebar.TabIndex = 0;
            pnlSidebar.Paint += pnlSidebar_Paint;
            // 
            // LogoutIcon
            // 
            LogoutIcon.Image = AppImages.logout__1_;
            LogoutIcon.Location = new Point(2, 904);
            LogoutIcon.Name = "LogoutIcon";
            LogoutIcon.Size = new Size(37, 43);
            LogoutIcon.SizeMode = PictureBoxSizeMode.Zoom;
            LogoutIcon.TabIndex = 8;
            LogoutIcon.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 891);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(258, 67);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // GradesIcon
            // 
            GradesIcon.Image = AppImages.grades__1_;
            GradesIcon.Location = new Point(2, 453);
            GradesIcon.Name = "GradesIcon";
            GradesIcon.Size = new Size(37, 43);
            GradesIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            GradesIcon.TabIndex = 13;
            GradesIcon.TabStop = false;
            GradesIcon.Click += pictureBox5_Click;
            // 
            // ReportsIcon
            // 
            ReportsIcon.Image = AppImages.reports__1_;
            ReportsIcon.Location = new Point(4, 545);
            ReportsIcon.Name = "ReportsIcon";
            ReportsIcon.Size = new Size(37, 43);
            ReportsIcon.SizeMode = PictureBoxSizeMode.Zoom;
            ReportsIcon.TabIndex = 14;
            ReportsIcon.TabStop = false;
            // 
            // CoursesIcon
            // 
            CoursesIcon.Image = AppImages.Coursess;
            CoursesIcon.Location = new Point(2, 378);
            CoursesIcon.Name = "CoursesIcon";
            CoursesIcon.Size = new Size(37, 43);
            CoursesIcon.SizeMode = PictureBoxSizeMode.Zoom;
            CoursesIcon.TabIndex = 12;
            CoursesIcon.TabStop = false;
            // 
            // DashboardIcon
            // 
            DashboardIcon.Image = AppImages.dashboard__1_;
            DashboardIcon.Location = new Point(0, 293);
            DashboardIcon.Name = "DashboardIcon";
            DashboardIcon.Size = new Size(37, 43);
            DashboardIcon.SizeMode = PictureBoxSizeMode.Zoom;
            DashboardIcon.TabIndex = 10;
            DashboardIcon.TabStop = false;
            // 
            // LogoIcon
            // 
            LogoIcon.Image = AppImages.logo__1_;
            LogoIcon.Location = new Point(21, 13);
            LogoIcon.Name = "LogoIcon";
            LogoIcon.Size = new Size(214, 111);
            LogoIcon.SizeMode = PictureBoxSizeMode.Zoom;
            LogoIcon.TabIndex = 8;
            LogoIcon.TabStop = false;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 278);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(258, 70);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 10F);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(0, 528);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(258, 70);
            btnReports.TabIndex = 5;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnGrades
            // 
            btnGrades.BackColor = Color.FromArgb(31, 45, 75);
            btnGrades.FlatAppearance.BorderSize = 0;
            btnGrades.FlatStyle = FlatStyle.Flat;
            btnGrades.Font = new Font("Segoe UI", 10F);
            btnGrades.ForeColor = Color.White;
            btnGrades.Location = new Point(0, 444);
            btnGrades.Name = "btnGrades";
            btnGrades.Size = new Size(258, 70);
            btnGrades.TabIndex = 4;
            btnGrades.Text = "Grades";
            btnGrades.UseVisualStyleBackColor = false;
            // 
            // btnCourses
            // 
            btnCourses.FlatAppearance.BorderSize = 0;
            btnCourses.FlatStyle = FlatStyle.Flat;
            btnCourses.Font = new Font("Segoe UI", 10F);
            btnCourses.ForeColor = Color.White;
            btnCourses.Location = new Point(0, 361);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(258, 70);
            btnCourses.TabIndex = 3;
            btnCourses.Text = "Courses";
            btnCourses.UseVisualStyleBackColor = true;
            // 
            // lblSystemName
            // 
            lblSystemName.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblSystemName.ForeColor = Color.White;
            lblSystemName.Location = new Point(0, 128);
            lblSystemName.Name = "lblSystemName";
            lblSystemName.Size = new Size(258, 83);
            lblSystemName.TabIndex = 1;
            lblSystemName.Text = "Student Grade Management System";
            lblSystemName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblDatabaseStatus);
            pnlHeader.Controls.Add(AdminIcon);
            pnlHeader.Controls.Add(lblWelcomeBack);
            pnlHeader.Controls.Add(lblAdminName);
            pnlHeader.Controls.Add(lblPageTitle);
            pnlHeader.Controls.Add(btnMenu);
            pnlHeader.Location = new Point(258, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1353, 125);
            pnlHeader.TabIndex = 1;
            // 
            // lblDatabaseStatus
            // 
            lblDatabaseStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDatabaseStatus.Font = new Font("Segoe UI", 6F, FontStyle.Bold);
            lblDatabaseStatus.ForeColor = Color.SeaGreen;
            lblDatabaseStatus.Location = new Point(72, 76);
            lblDatabaseStatus.Margin = new Padding(4, 0, 4, 0);
            lblDatabaseStatus.Name = "lblDatabaseStatus";
            lblDatabaseStatus.Size = new Size(134, 33);
            lblDatabaseStatus.TabIndex = 15;
            lblDatabaseStatus.Text = "Database: Connected";
            lblDatabaseStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AdminIcon
            // 
            AdminIcon.BackColor = Color.White;
            AdminIcon.Image = AppImages.Gemini_Generated_Image_ysh2i4ysh2i4ysh21;
            AdminIcon.Location = new Point(1098, 20);
            AdminIcon.Name = "AdminIcon";
            AdminIcon.Size = new Size(60, 70);
            AdminIcon.SizeMode = PictureBoxSizeMode.Zoom;
            AdminIcon.TabIndex = 0;
            AdminIcon.TabStop = false;
            // 
            // lblWelcomeBack
            // 
            lblWelcomeBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblWelcomeBack.Font = new Font("Segoe UI", 7F);
            lblWelcomeBack.ForeColor = Color.FromArgb(83, 100, 122);
            lblWelcomeBack.Location = new Point(1164, 54);
            lblWelcomeBack.Name = "lblWelcomeBack";
            lblWelcomeBack.Size = new Size(116, 27);
            lblWelcomeBack.TabIndex = 6;
            lblWelcomeBack.Text = "\tWelcome back!";
            lblWelcomeBack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAdminName
            // 
            lblAdminName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAdminName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAdminName.ForeColor = Color.FromArgb(31, 45, 75);
            lblAdminName.Location = new Point(1181, 29);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(76, 25);
            lblAdminName.TabIndex = 3;
            lblAdminName.Text = "Admin";
            lblAdminName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPageTitle
            // 
            lblPageTitle.BackColor = Color.Transparent;
            lblPageTitle.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(31, 45, 75);
            lblPageTitle.Location = new Point(72, 29);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(488, 58);
            lblPageTitle.TabIndex = 5;
            lblPageTitle.Text = "Student Management System";
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Transparent;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnMenu.Location = new Point(9, 14);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(74, 78);
            btnMenu.TabIndex = 4;
            btnMenu.Text = "\t☰";
            btnMenu.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = AppImages.First_page;
            pictureBox1.Location = new Point(473, 208);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(996, 617);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // GradesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1611, 1040);
            Controls.Add(pictureBox1);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            Name = "GradesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Grade Management System";
            pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LogoutIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)GradesIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)ReportsIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)CoursesIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)DashboardIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoIcon).EndInit();
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AdminIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Button btnDashboard;
        private Label lblSystemName;
        private Button btnCourses;
        private Button btnReports;
        private Button btnGrades;
        private Button btnLogout;
       
        private PictureBox LogoIcon;
        private PictureBox DashboardIcon;
        private PictureBox GradesIcon;
        private PictureBox CoursesIcon;
       
        private PictureBox ReportsIcon;
        private PictureBox LogoutIcon;
        private Panel pnlHeader;
        private Button btnMenu;
        private PictureBox AdminIcon;
        private Label lblAdminName;
        private Label lblWelcomeBack;
        private PictureBox pictureBox1;
        private Label lblPageTitle;
        private Label lblDatabaseStatus;
    }
}
