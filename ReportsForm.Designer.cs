using System;
using System.Drawing;
using System.Windows.Forms;

namespace CS312.Proj
{
    partial class ReportsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlSidebar = new Panel();
            LogoutIcon = new PictureBox();
            ReportsIcon = new PictureBox();
            GradesIcon = new PictureBox();
            CoursesIcon = new PictureBox();
            DashboardIcon = new PictureBox();
            btnLogout = new Button();
            btnReports = new Button();
            btnGrades = new Button();
            btnCourses = new Button();
            btnDashboard = new Button();
            picLogo = new PictureBox();
            lblSystemName = new Label();
            pnlHeader = new Panel();
            lblDatabaseStatus = new Label();
            prgLoading = new ProgressBar();
            AdminIcon = new PictureBox();
            lblWelcomeBack = new Label();
            lblAdminName = new Label();
            lblPageTitle = new Label();
            btnMenu = new Button();
            pnlMain = new Panel();
            pnlDetails = new Panel();
            lblDetailsTitle = new Label();
            lblDetailCourse = new Label();
            pnlDonut = new Panel();
            lblPassedInfo = new Label();
            lblFailedInfo = new Label();
            lblAvgInfo = new Label();
            lblHighInfo = new Label();
            lblLowInfo = new Label();
            lblGradeTitle = new Label();
            pnlGradeDist = new Panel();
            pnlCourseReport = new Panel();
            lblReportTitle = new Label();
            lblUpdated = new Label();
            dgvCourses = new DataGridView();
            lblFooter = new Label();
            pnlKpi4 = new Panel();
            pnlAccent4 = new Panel();
            lblKpiTitle4 = new Label();
            lblKpiValue4 = new Label();
            lblKpiSub4 = new Label();
            pnlKpi3 = new Panel();
            pnlAccent3 = new Panel();
            lblKpiTitle3 = new Label();
            lblKpiValue3 = new Label();
            lblKpiSub3 = new Label();
            pnlKpi2 = new Panel();
            pnlAccent2 = new Panel();
            lblKpiTitle2 = new Label();
            lblKpiValue2 = new Label();
            lblKpiSub2 = new Label();
            pnlKpi1 = new Panel();
            pnlAccent1 = new Panel();
            lblKpiTitle1 = new Label();
            lblKpiValue1 = new Label();
            lblKpiSub1 = new Label();
            pnlFilters = new Panel();
            lblSearch = new Label();
            txtSearchCourse = new TextBox();
            lblSort = new Label();
            cmbSort = new ComboBox();
            lblPassMark = new Label();
            nudPassMark = new NumericUpDown();
            btnRefresh = new Button();
            btnExport = new Button();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoutIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ReportsIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GradesIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CoursesIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DashboardIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdminIcon).BeginInit();
            pnlMain.SuspendLayout();
            pnlDetails.SuspendLayout();
            pnlCourseReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            pnlKpi4.SuspendLayout();
            pnlKpi3.SuspendLayout();
            pnlKpi2.SuspendLayout();
            pnlKpi1.SuspendLayout();
            pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPassMark).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(31, 45, 75);
            pnlSidebar.Controls.Add(LogoutIcon);
            pnlSidebar.Controls.Add(ReportsIcon);
            pnlSidebar.Controls.Add(GradesIcon);
            pnlSidebar.Controls.Add(CoursesIcon);
            pnlSidebar.Controls.Add(DashboardIcon);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnReports);
            pnlSidebar.Controls.Add(btnGrades);
            pnlSidebar.Controls.Add(btnCourses);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(picLogo);
            pnlSidebar.Controls.Add(lblSystemName);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(4, 5, 4, 5);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(258, 1039);
            pnlSidebar.TabIndex = 0;
            // 
            // LogoutIcon
            // 
            LogoutIcon.BackColor = Color.FromArgb(31, 45, 75);
            LogoutIcon.Image = Properties.Resources.logout;
            LogoutIcon.Location = new Point(2, 904);
            LogoutIcon.Margin = new Padding(4, 5, 4, 5);
            LogoutIcon.Name = "LogoutIcon";
            LogoutIcon.Size = new Size(37, 43);
            LogoutIcon.SizeMode = PictureBoxSizeMode.Zoom;
            LogoutIcon.TabIndex = 0;
            LogoutIcon.TabStop = false;
            // 
            // ReportsIcon
            // 
            ReportsIcon.BackColor = Color.FromArgb(41, 98, 180);
            ReportsIcon.Image = Properties.Resources.reports__1_;
            ReportsIcon.Location = new Point(4, 545);
            ReportsIcon.Margin = new Padding(4, 5, 4, 5);
            ReportsIcon.Name = "ReportsIcon";
            ReportsIcon.Size = new Size(37, 43);
            ReportsIcon.SizeMode = PictureBoxSizeMode.Zoom;
            ReportsIcon.TabIndex = 2;
            ReportsIcon.TabStop = false;
            // 
            // GradesIcon
            // 
            GradesIcon.BackColor = Color.FromArgb(31, 45, 75);
            GradesIcon.Image = Properties.Resources.grades;
            GradesIcon.Location = new Point(4, 458);
            GradesIcon.Margin = new Padding(4, 5, 4, 5);
            GradesIcon.Name = "GradesIcon";
            GradesIcon.Size = new Size(40, 37);
            GradesIcon.SizeMode = PictureBoxSizeMode.Zoom;
            GradesIcon.TabIndex = 3;
            GradesIcon.TabStop = false;
            // 
            // CoursesIcon
            // 
            CoursesIcon.BackColor = Color.FromArgb(31, 45, 75);
            CoursesIcon.Image = Properties.Resources.courses1;
            CoursesIcon.Location = new Point(2, 378);
            CoursesIcon.Margin = new Padding(4, 5, 4, 5);
            CoursesIcon.Name = "CoursesIcon";
            CoursesIcon.Size = new Size(37, 43);
            CoursesIcon.SizeMode = PictureBoxSizeMode.Zoom;
            CoursesIcon.TabIndex = 4;
            CoursesIcon.TabStop = false;
            // 
            // DashboardIcon
            // 
            DashboardIcon.BackColor = Color.FromArgb(31, 45, 75);
            DashboardIcon.Image = Properties.Resources.dashboard;
            DashboardIcon.Location = new Point(0, 293);
            DashboardIcon.Margin = new Padding(4, 5, 4, 5);
            DashboardIcon.Name = "DashboardIcon";
            DashboardIcon.Size = new Size(37, 43);
            DashboardIcon.SizeMode = PictureBoxSizeMode.Zoom;
            DashboardIcon.TabIndex = 6;
            DashboardIcon.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(31, 45, 75);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 891);
            btnLogout.Margin = new Padding(4, 5, 4, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(258, 67);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(41, 98, 180);
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 10F);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(0, 528);
            btnReports.Margin = new Padding(4, 5, 4, 5);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(258, 70);
            btnReports.TabIndex = 9;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnGrades
            // 
            btnGrades.BackColor = Color.FromArgb(31, 45, 75);
            btnGrades.FlatAppearance.BorderSize = 0;
            btnGrades.FlatStyle = FlatStyle.Flat;
            btnGrades.Font = new Font("Segoe UI", 10F);
            btnGrades.ForeColor = Color.White;
            btnGrades.Location = new Point(0, 444);
            btnGrades.Margin = new Padding(4, 5, 4, 5);
            btnGrades.Name = "btnGrades";
            btnGrades.Size = new Size(258, 70);
            btnGrades.TabIndex = 10;
            btnGrades.Text = "Grades";
            btnGrades.UseVisualStyleBackColor = false;
            // 
            // btnCourses
            // 
            btnCourses.BackColor = Color.FromArgb(31, 45, 75);
            btnCourses.FlatAppearance.BorderSize = 0;
            btnCourses.FlatStyle = FlatStyle.Flat;
            btnCourses.Font = new Font("Segoe UI", 10F);
            btnCourses.ForeColor = Color.White;
            btnCourses.Location = new Point(0, 361);
            btnCourses.Margin = new Padding(4, 5, 4, 5);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(258, 70);
            btnCourses.TabIndex = 11;
            btnCourses.Text = "Courses";
            btnCourses.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(31, 45, 75);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 278);
            btnDashboard.Margin = new Padding(4, 5, 4, 5);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(258, 70);
            btnDashboard.TabIndex = 13;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.FromArgb(31, 45, 75);
            picLogo.Image = Properties.Resources.logo__1_;
            picLogo.Location = new Point(21, 13);
            picLogo.Margin = new Padding(4, 5, 4, 5);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(214, 111);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 14;
            picLogo.TabStop = false;
            // 
            // lblSystemName
            // 
            lblSystemName.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblSystemName.ForeColor = Color.White;
            lblSystemName.Location = new Point(0, 128);
            lblSystemName.Margin = new Padding(4, 0, 4, 0);
            lblSystemName.Name = "lblSystemName";
            lblSystemName.Size = new Size(258, 83);
            lblSystemName.TabIndex = 15;
            lblSystemName.Text = "Student Grade Management System";
            lblSystemName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.WhiteSmoke;
            pnlHeader.Controls.Add(lblDatabaseStatus);
            pnlHeader.Controls.Add(prgLoading);
            pnlHeader.Controls.Add(AdminIcon);
            pnlHeader.Controls.Add(lblWelcomeBack);
            pnlHeader.Controls.Add(lblAdminName);
            pnlHeader.Controls.Add(lblPageTitle);
            pnlHeader.Controls.Add(btnMenu);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(258, 0);
            pnlHeader.Margin = new Padding(4, 5, 4, 5);
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
            lblDatabaseStatus.TabIndex = 16;
            lblDatabaseStatus.Text = "Database: Connected";
            lblDatabaseStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // prgLoading
            // 
            prgLoading.Location = new Point(0, 114);
            prgLoading.Margin = new Padding(4, 5, 4, 5);
            prgLoading.MarqueeAnimationSpeed = 30;
            prgLoading.Name = "prgLoading";
            prgLoading.Size = new Size(1354, 11);
            prgLoading.Style = ProgressBarStyle.Marquee;
            prgLoading.TabIndex = 0;
            prgLoading.Visible = false;
            // 
            // AdminIcon
            // 
            AdminIcon.BackColor = Color.White;
            AdminIcon.Image = Properties.Resources.Gemini_Generated_Image_ysh2i4ysh2i4ysh2;
            AdminIcon.Location = new Point(1098, 20);
            AdminIcon.Margin = new Padding(4, 5, 4, 5);
            AdminIcon.Name = "AdminIcon";
            AdminIcon.Size = new Size(60, 70);
            AdminIcon.SizeMode = PictureBoxSizeMode.Zoom;
            AdminIcon.TabIndex = 1;
            AdminIcon.TabStop = false;
            // 
            // lblWelcomeBack
            // 
            lblWelcomeBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblWelcomeBack.Font = new Font("Segoe UI", 7F);
            lblWelcomeBack.ForeColor = Color.FromArgb(31, 45, 75);
            lblWelcomeBack.Location = new Point(1166, 64);
            lblWelcomeBack.Margin = new Padding(4, 0, 4, 0);
            lblWelcomeBack.Name = "lblWelcomeBack";
            lblWelcomeBack.Size = new Size(132, 28);
            lblWelcomeBack.TabIndex = 2;
            lblWelcomeBack.Text = "\tWelcome back!";
            lblWelcomeBack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAdminName
            // 
            lblAdminName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAdminName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAdminName.ForeColor = Color.FromArgb(31, 45, 75);
            lblAdminName.Location = new Point(1190, 14);
            lblAdminName.Margin = new Padding(4, 0, 4, 0);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(109, 42);
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
            lblPageTitle.Margin = new Padding(4, 0, 4, 0);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(789, 58);
            lblPageTitle.TabIndex = 4;
            lblPageTitle.Text = "\tReports";
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Transparent;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnMenu.Location = new Point(9, 14);
            btnMenu.Margin = new Padding(4, 5, 4, 5);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(74, 78);
            btnMenu.TabIndex = 5;
            btnMenu.Text = "\t☰";
            btnMenu.UseVisualStyleBackColor = false;
            // 
            // pnlMain
            // 
            pnlMain.AutoScroll = true;
            pnlMain.BackColor = Color.WhiteSmoke;
            pnlMain.Controls.Add(pnlDetails);
            pnlMain.Controls.Add(pnlCourseReport);
            pnlMain.Controls.Add(pnlKpi4);
            pnlMain.Controls.Add(pnlKpi3);
            pnlMain.Controls.Add(pnlKpi2);
            pnlMain.Controls.Add(pnlKpi1);
            pnlMain.Controls.Add(pnlFilters);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(258, 125);
            pnlMain.Margin = new Padding(4, 5, 4, 5);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(18, 20, 18, 20);
            pnlMain.Size = new Size(1353, 914);
            pnlMain.TabIndex = 2;
            // 
            // pnlDetails
            // 
            pnlDetails.BackColor = Color.White;
            pnlDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlDetails.Controls.Add(lblDetailsTitle);
            pnlDetails.Controls.Add(lblDetailCourse);
            pnlDetails.Controls.Add(pnlDonut);
            pnlDetails.Controls.Add(lblPassedInfo);
            pnlDetails.Controls.Add(lblFailedInfo);
            pnlDetails.Controls.Add(lblAvgInfo);
            pnlDetails.Controls.Add(lblHighInfo);
            pnlDetails.Controls.Add(lblLowInfo);
            pnlDetails.Controls.Add(lblGradeTitle);
            pnlDetails.Controls.Add(pnlGradeDist);
            pnlDetails.Location = new Point(896, 267);
            pnlDetails.Margin = new Padding(4, 5, 4, 5);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(441, 622);
            pnlDetails.TabIndex = 0;
            // 
            // lblDetailsTitle
            // 
            lblDetailsTitle.AutoSize = true;
            lblDetailsTitle.BackColor = Color.SteelBlue;
            lblDetailsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDetailsTitle.ForeColor = Color.White;
            lblDetailsTitle.Location = new Point(21, 17);
            lblDetailsTitle.Margin = new Padding(4, 0, 4, 0);
            lblDetailsTitle.Name = "lblDetailsTitle";
            lblDetailsTitle.Size = new Size(178, 32);
            lblDetailsTitle.TabIndex = 0;
            lblDetailsTitle.Text = "Course Details";
            // 
            // lblDetailCourse
            // 
            lblDetailCourse.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDetailCourse.ForeColor = Color.FromArgb(31, 45, 75);
            lblDetailCourse.Location = new Point(21, 78);
            lblDetailCourse.Margin = new Padding(4, 0, 4, 0);
            lblDetailCourse.Name = "lblDetailCourse";
            lblDetailCourse.Size = new Size(399, 47);
            lblDetailCourse.TabIndex = 1;
            lblDetailCourse.Text = "Select a course";
            lblDetailCourse.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlDonut
            // 
            pnlDonut.BackColor = Color.White;
            pnlDonut.Location = new Point(21, 137);
            pnlDonut.Margin = new Padding(4, 5, 4, 5);
            pnlDonut.Name = "pnlDonut";
            pnlDonut.Size = new Size(171, 200);
            pnlDonut.TabIndex = 2;
            // 
            // lblPassedInfo
            // 
            lblPassedInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPassedInfo.ForeColor = Color.FromArgb(16, 185, 129);
            lblPassedInfo.Location = new Point(208, 147);
            lblPassedInfo.Margin = new Padding(4, 0, 4, 0);
            lblPassedInfo.Name = "lblPassedInfo";
            lblPassedInfo.Size = new Size(221, 37);
            lblPassedInfo.TabIndex = 3;
            lblPassedInfo.Text = "Passed: -";
            lblPassedInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFailedInfo
            // 
            lblFailedInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFailedInfo.ForeColor = Color.FromArgb(239, 68, 68);
            lblFailedInfo.Location = new Point(208, 187);
            lblFailedInfo.Margin = new Padding(4, 0, 4, 0);
            lblFailedInfo.Name = "lblFailedInfo";
            lblFailedInfo.Size = new Size(221, 37);
            lblFailedInfo.TabIndex = 4;
            lblFailedInfo.Text = "Failed: -";
            lblFailedInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAvgInfo
            // 
            lblAvgInfo.Font = new Font("Segoe UI", 9F);
            lblAvgInfo.ForeColor = Color.FromArgb(38, 58, 86);
            lblAvgInfo.Location = new Point(208, 228);
            lblAvgInfo.Margin = new Padding(4, 0, 4, 0);
            lblAvgInfo.Name = "lblAvgInfo";
            lblAvgInfo.Size = new Size(221, 37);
            lblAvgInfo.TabIndex = 5;
            lblAvgInfo.Text = "Average: -";
            lblAvgInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHighInfo
            // 
            lblHighInfo.Font = new Font("Segoe UI", 9F);
            lblHighInfo.ForeColor = Color.FromArgb(38, 58, 86);
            lblHighInfo.Location = new Point(208, 267);
            lblHighInfo.Margin = new Padding(4, 0, 4, 0);
            lblHighInfo.Name = "lblHighInfo";
            lblHighInfo.Size = new Size(221, 37);
            lblHighInfo.TabIndex = 6;
            lblHighInfo.Text = "Highest: -";
            lblHighInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLowInfo
            // 
            lblLowInfo.Font = new Font("Segoe UI", 9F);
            lblLowInfo.ForeColor = Color.FromArgb(38, 58, 86);
            lblLowInfo.Location = new Point(208, 307);
            lblLowInfo.Margin = new Padding(4, 0, 4, 0);
            lblLowInfo.Name = "lblLowInfo";
            lblLowInfo.Size = new Size(221, 37);
            lblLowInfo.TabIndex = 7;
            lblLowInfo.Text = "Lowest: -";
            lblLowInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGradeTitle
            // 
            lblGradeTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGradeTitle.ForeColor = Color.FromArgb(31, 45, 75);
            lblGradeTitle.Location = new Point(21, 363);
            lblGradeTitle.Margin = new Padding(4, 0, 4, 0);
            lblGradeTitle.Name = "lblGradeTitle";
            lblGradeTitle.Size = new Size(399, 33);
            lblGradeTitle.TabIndex = 8;
            lblGradeTitle.Text = "Grade Distribution";
            // 
            // pnlGradeDist
            // 
            pnlGradeDist.BackColor = Color.White;
            pnlGradeDist.Location = new Point(21, 400);
            pnlGradeDist.Margin = new Padding(4, 5, 4, 5);
            pnlGradeDist.Name = "pnlGradeDist";
            pnlGradeDist.Size = new Size(399, 200);
            pnlGradeDist.TabIndex = 9;
            // 
            // pnlCourseReport
            // 
            pnlCourseReport.BackColor = Color.White;
            pnlCourseReport.BorderStyle = BorderStyle.FixedSingle;
            pnlCourseReport.Controls.Add(lblReportTitle);
            pnlCourseReport.Controls.Add(lblUpdated);
            pnlCourseReport.Controls.Add(dgvCourses);
            pnlCourseReport.Controls.Add(lblFooter);
            pnlCourseReport.Location = new Point(21, 267);
            pnlCourseReport.Margin = new Padding(4, 5, 4, 5);
            pnlCourseReport.Name = "pnlCourseReport";
            pnlCourseReport.Size = new Size(856, 622);
            pnlCourseReport.TabIndex = 1;
            // 
            // lblReportTitle
            // 
            lblReportTitle.AutoSize = true;
            lblReportTitle.BackColor = Color.SteelBlue;
            lblReportTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblReportTitle.ForeColor = Color.White;
            lblReportTitle.Location = new Point(21, 17);
            lblReportTitle.Margin = new Padding(4, 0, 4, 0);
            lblReportTitle.Name = "lblReportTitle";
            lblReportTitle.Size = new Size(178, 32);
            lblReportTitle.TabIndex = 0;
            lblReportTitle.Text = "Course Report";
            // 
            // lblUpdated
            // 
            lblUpdated.Font = new Font("Segoe UI", 8F);
            lblUpdated.ForeColor = Color.FromArgb(107, 114, 128);
            lblUpdated.Location = new Point(558, 22);
            lblUpdated.Margin = new Padding(4, 0, 4, 0);
            lblUpdated.Name = "lblUpdated";
            lblUpdated.Size = new Size(279, 30);
            lblUpdated.TabIndex = 1;
            lblUpdated.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgvCourses
            // 
            dgvCourses.AllowUserToAddRows = false;
            dgvCourses.AllowUserToDeleteRows = false;
            dgvCourses.AllowUserToResizeColumns = false;
            dgvCourses.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvCourses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourses.BackgroundColor = Color.White;
            dgvCourses.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(205, 220, 235);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(23, 59, 108);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(205, 220, 235);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(23, 59, 108);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCourses.ColumnHeadersHeight = 38;
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(38, 58, 86);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(214, 229, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(23, 59, 108);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCourses.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCourses.EnableHeadersVisualStyles = false;
            dgvCourses.Location = new Point(16, 80);
            dgvCourses.Margin = new Padding(4, 5, 4, 5);
            dgvCourses.MultiSelect = false;
            dgvCourses.Name = "dgvCourses";
            dgvCourses.ReadOnly = true;
            dgvCourses.RowHeadersVisible = false;
            dgvCourses.RowHeadersWidth = 62;
            dgvCourses.RowTemplate.Height = 36;
            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourses.Size = new Size(822, 483);
            dgvCourses.TabIndex = 0;
            // 
            // lblFooter
            // 
            lblFooter.Font = new Font("Segoe UI", 8F);
            lblFooter.ForeColor = Color.FromArgb(107, 114, 128);
            lblFooter.Location = new Point(21, 578);
            lblFooter.Margin = new Padding(4, 0, 4, 0);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(814, 30);
            lblFooter.TabIndex = 2;
            lblFooter.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlKpi4
            // 
            pnlKpi4.BackColor = Color.White;
            pnlKpi4.BorderStyle = BorderStyle.FixedSingle;
            pnlKpi4.Controls.Add(pnlAccent4);
            pnlKpi4.Controls.Add(lblKpiTitle4);
            pnlKpi4.Controls.Add(lblKpiValue4);
            pnlKpi4.Controls.Add(lblKpiSub4);
            pnlKpi4.Location = new Point(1020, 122);
            pnlKpi4.Margin = new Padding(4, 5, 4, 5);
            pnlKpi4.Name = "pnlKpi4";
            pnlKpi4.Size = new Size(316, 124);
            pnlKpi4.TabIndex = 2;
            // 
            // pnlAccent4
            // 
            pnlAccent4.BackColor = Color.FromArgb(245, 158, 11);
            pnlAccent4.Location = new Point(0, 0);
            pnlAccent4.Margin = new Padding(4, 5, 4, 5);
            pnlAccent4.Name = "pnlAccent4";
            pnlAccent4.Size = new Size(9, 122);
            pnlAccent4.TabIndex = 0;
            // 
            // lblKpiTitle4
            // 
            lblKpiTitle4.Font = new Font("Segoe UI", 9F);
            lblKpiTitle4.ForeColor = Color.FromArgb(107, 114, 128);
            lblKpiTitle4.Location = new Point(26, 13);
            lblKpiTitle4.Margin = new Padding(4, 0, 4, 0);
            lblKpiTitle4.Name = "lblKpiTitle4";
            lblKpiTitle4.Size = new Size(279, 30);
            lblKpiTitle4.TabIndex = 1;
            lblKpiTitle4.Text = "Best Course";
            // 
            // lblKpiValue4
            // 
            lblKpiValue4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblKpiValue4.ForeColor = Color.FromArgb(31, 45, 75);
            lblKpiValue4.Location = new Point(26, 43);
            lblKpiValue4.Margin = new Padding(4, 0, 4, 0);
            lblKpiValue4.Name = "lblKpiValue4";
            lblKpiValue4.Size = new Size(279, 57);
            lblKpiValue4.TabIndex = 2;
            lblKpiValue4.Text = "-";
            lblKpiValue4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblKpiSub4
            // 
            lblKpiSub4.Font = new Font("Segoe UI", 8F);
            lblKpiSub4.ForeColor = Color.FromArgb(107, 114, 128);
            lblKpiSub4.Location = new Point(26, 97);
            lblKpiSub4.Margin = new Padding(4, 0, 4, 0);
            lblKpiSub4.Name = "lblKpiSub4";
            lblKpiSub4.Size = new Size(279, 22);
            lblKpiSub4.TabIndex = 3;
            // 
            // pnlKpi3
            // 
            pnlKpi3.BackColor = Color.White;
            pnlKpi3.BorderStyle = BorderStyle.FixedSingle;
            pnlKpi3.Controls.Add(pnlAccent3);
            pnlKpi3.Controls.Add(lblKpiTitle3);
            pnlKpi3.Controls.Add(lblKpiValue3);
            pnlKpi3.Controls.Add(lblKpiSub3);
            pnlKpi3.Location = new Point(688, 122);
            pnlKpi3.Margin = new Padding(4, 5, 4, 5);
            pnlKpi3.Name = "pnlKpi3";
            pnlKpi3.Size = new Size(316, 124);
            pnlKpi3.TabIndex = 3;
            // 
            // pnlAccent3
            // 
            pnlAccent3.BackColor = Color.FromArgb(16, 185, 129);
            pnlAccent3.Location = new Point(0, 0);
            pnlAccent3.Margin = new Padding(4, 5, 4, 5);
            pnlAccent3.Name = "pnlAccent3";
            pnlAccent3.Size = new Size(9, 122);
            pnlAccent3.TabIndex = 0;
            // 
            // lblKpiTitle3
            // 
            lblKpiTitle3.Font = new Font("Segoe UI", 9F);
            lblKpiTitle3.ForeColor = Color.FromArgb(107, 114, 128);
            lblKpiTitle3.Location = new Point(26, 13);
            lblKpiTitle3.Margin = new Padding(4, 0, 4, 0);
            lblKpiTitle3.Name = "lblKpiTitle3";
            lblKpiTitle3.Size = new Size(279, 30);
            lblKpiTitle3.TabIndex = 1;
            lblKpiTitle3.Text = "Overall Pass Rate";
            // 
            // lblKpiValue3
            // 
            lblKpiValue3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblKpiValue3.ForeColor = Color.FromArgb(31, 45, 75);
            lblKpiValue3.Location = new Point(26, 43);
            lblKpiValue3.Margin = new Padding(4, 0, 4, 0);
            lblKpiValue3.Name = "lblKpiValue3";
            lblKpiValue3.Size = new Size(279, 57);
            lblKpiValue3.TabIndex = 2;
            lblKpiValue3.Text = "0%";
            lblKpiValue3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblKpiSub3
            // 
            lblKpiSub3.Font = new Font("Segoe UI", 8F);
            lblKpiSub3.ForeColor = Color.FromArgb(107, 114, 128);
            lblKpiSub3.Location = new Point(26, 97);
            lblKpiSub3.Margin = new Padding(4, 0, 4, 0);
            lblKpiSub3.Name = "lblKpiSub3";
            lblKpiSub3.Size = new Size(279, 22);
            lblKpiSub3.TabIndex = 3;
            lblKpiSub3.Text = "of all grade records";
            // 
            // pnlKpi2
            // 
            pnlKpi2.BackColor = Color.White;
            pnlKpi2.BorderStyle = BorderStyle.FixedSingle;
            pnlKpi2.Controls.Add(pnlAccent2);
            pnlKpi2.Controls.Add(lblKpiTitle2);
            pnlKpi2.Controls.Add(lblKpiValue2);
            pnlKpi2.Controls.Add(lblKpiSub2);
            pnlKpi2.Location = new Point(354, 122);
            pnlKpi2.Margin = new Padding(4, 5, 4, 5);
            pnlKpi2.Name = "pnlKpi2";
            pnlKpi2.Size = new Size(316, 124);
            pnlKpi2.TabIndex = 4;
            // 
            // pnlAccent2
            // 
            pnlAccent2.BackColor = Color.FromArgb(139, 92, 246);
            pnlAccent2.Location = new Point(0, 0);
            pnlAccent2.Margin = new Padding(4, 5, 4, 5);
            pnlAccent2.Name = "pnlAccent2";
            pnlAccent2.Size = new Size(9, 122);
            pnlAccent2.TabIndex = 0;
            // 
            // lblKpiTitle2
            // 
            lblKpiTitle2.Font = new Font("Segoe UI", 9F);
            lblKpiTitle2.ForeColor = Color.FromArgb(107, 114, 128);
            lblKpiTitle2.Location = new Point(26, 13);
            lblKpiTitle2.Margin = new Padding(4, 0, 4, 0);
            lblKpiTitle2.Name = "lblKpiTitle2";
            lblKpiTitle2.Size = new Size(279, 30);
            lblKpiTitle2.TabIndex = 1;
            lblKpiTitle2.Text = "Total Students";
            // 
            // lblKpiValue2
            // 
            lblKpiValue2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblKpiValue2.ForeColor = Color.FromArgb(31, 45, 75);
            lblKpiValue2.Location = new Point(26, 43);
            lblKpiValue2.Margin = new Padding(4, 0, 4, 0);
            lblKpiValue2.Name = "lblKpiValue2";
            lblKpiValue2.Size = new Size(279, 57);
            lblKpiValue2.TabIndex = 2;
            lblKpiValue2.Text = "0";
            lblKpiValue2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblKpiSub2
            // 
            lblKpiSub2.Font = new Font("Segoe UI", 8F);
            lblKpiSub2.ForeColor = Color.FromArgb(107, 114, 128);
            lblKpiSub2.Location = new Point(26, 97);
            lblKpiSub2.Margin = new Padding(4, 0, 4, 0);
            lblKpiSub2.Name = "lblKpiSub2";
            lblKpiSub2.Size = new Size(279, 22);
            lblKpiSub2.TabIndex = 3;
            lblKpiSub2.Text = "distinct students";
            // 
            // pnlKpi1
            // 
            pnlKpi1.BackColor = Color.White;
            pnlKpi1.BorderStyle = BorderStyle.FixedSingle;
            pnlKpi1.Controls.Add(pnlAccent1);
            pnlKpi1.Controls.Add(lblKpiTitle1);
            pnlKpi1.Controls.Add(lblKpiValue1);
            pnlKpi1.Controls.Add(lblKpiSub1);
            pnlKpi1.Location = new Point(21, 122);
            pnlKpi1.Margin = new Padding(4, 5, 4, 5);
            pnlKpi1.Name = "pnlKpi1";
            pnlKpi1.Size = new Size(316, 124);
            pnlKpi1.TabIndex = 5;
            // 
            // pnlAccent1
            // 
            pnlAccent1.BackColor = Color.FromArgb(59, 130, 246);
            pnlAccent1.Location = new Point(0, 0);
            pnlAccent1.Margin = new Padding(4, 5, 4, 5);
            pnlAccent1.Name = "pnlAccent1";
            pnlAccent1.Size = new Size(9, 122);
            pnlAccent1.TabIndex = 0;
            // 
            // lblKpiTitle1
            // 
            lblKpiTitle1.Font = new Font("Segoe UI", 9F);
            lblKpiTitle1.ForeColor = Color.FromArgb(107, 114, 128);
            lblKpiTitle1.Location = new Point(26, 13);
            lblKpiTitle1.Margin = new Padding(4, 0, 4, 0);
            lblKpiTitle1.Name = "lblKpiTitle1";
            lblKpiTitle1.Size = new Size(279, 30);
            lblKpiTitle1.TabIndex = 1;
            lblKpiTitle1.Text = "Total Courses";
            // 
            // lblKpiValue1
            // 
            lblKpiValue1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblKpiValue1.ForeColor = Color.FromArgb(31, 45, 75);
            lblKpiValue1.Location = new Point(26, 43);
            lblKpiValue1.Margin = new Padding(4, 0, 4, 0);
            lblKpiValue1.Name = "lblKpiValue1";
            lblKpiValue1.Size = new Size(279, 57);
            lblKpiValue1.TabIndex = 2;
            lblKpiValue1.Text = "0";
            lblKpiValue1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblKpiSub1
            // 
            lblKpiSub1.Font = new Font("Segoe UI", 8F);
            lblKpiSub1.ForeColor = Color.FromArgb(107, 114, 128);
            lblKpiSub1.Location = new Point(26, 97);
            lblKpiSub1.Margin = new Padding(4, 0, 4, 0);
            lblKpiSub1.Name = "lblKpiSub1";
            lblKpiSub1.Size = new Size(279, 22);
            lblKpiSub1.TabIndex = 3;
            lblKpiSub1.Text = "with recorded grades";
            // 
            // pnlFilters
            // 
            pnlFilters.BackColor = Color.White;
            pnlFilters.BorderStyle = BorderStyle.FixedSingle;
            pnlFilters.Controls.Add(lblSearch);
            pnlFilters.Controls.Add(txtSearchCourse);
            pnlFilters.Controls.Add(lblSort);
            pnlFilters.Controls.Add(cmbSort);
            pnlFilters.Controls.Add(lblPassMark);
            pnlFilters.Controls.Add(nudPassMark);
            pnlFilters.Controls.Add(btnRefresh);
            pnlFilters.Controls.Add(btnExport);
            pnlFilters.Location = new Point(21, 11);
            pnlFilters.Margin = new Padding(4, 5, 4, 5);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Size = new Size(1314, 99);
            pnlFilters.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(38, 58, 86);
            lblSearch.Location = new Point(21, 8);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(214, 33);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search Course";
            // 
            // txtSearchCourse
            // 
            txtSearchCourse.BorderStyle = BorderStyle.FixedSingle;
            txtSearchCourse.Font = new Font("Segoe UI", 9F);
            txtSearchCourse.ForeColor = Color.FromArgb(38, 58, 86);
            txtSearchCourse.Location = new Point(21, 45);
            txtSearchCourse.Margin = new Padding(4, 5, 4, 5);
            txtSearchCourse.Name = "txtSearchCourse";
            txtSearchCourse.Size = new Size(328, 31);
            txtSearchCourse.TabIndex = 1;
            // 
            // lblSort
            // 
            lblSort.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSort.ForeColor = Color.FromArgb(38, 58, 86);
            lblSort.Location = new Point(379, 8);
            lblSort.Margin = new Padding(4, 0, 4, 0);
            lblSort.Name = "lblSort";
            lblSort.Size = new Size(214, 33);
            lblSort.TabIndex = 2;
            lblSort.Text = "Sort By";
            // 
            // cmbSort
            // 
            cmbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSort.Font = new Font("Segoe UI", 9F);
            cmbSort.ForeColor = Color.FromArgb(38, 58, 86);
            cmbSort.FormattingEnabled = true;
            cmbSort.Items.AddRange(new object[] { "Pass Rate (High to Low)", "Pass Rate (Low to High)", "Average (High to Low)", "Course Name (A-Z)", "Students (High to Low)" });
            cmbSort.Location = new Point(379, 45);
            cmbSort.Margin = new Padding(4, 5, 4, 5);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(284, 33);
            cmbSort.TabIndex = 2;
            // 
            // lblPassMark
            // 
            lblPassMark.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPassMark.ForeColor = Color.FromArgb(38, 58, 86);
            lblPassMark.Location = new Point(692, 8);
            lblPassMark.Margin = new Padding(4, 0, 4, 0);
            lblPassMark.Name = "lblPassMark";
            lblPassMark.Size = new Size(142, 33);
            lblPassMark.TabIndex = 3;
            lblPassMark.Text = "Pass Mark";
            // 
            // nudPassMark
            // 
            nudPassMark.Font = new Font("Segoe UI", 9F);
            nudPassMark.ForeColor = Color.FromArgb(38, 58, 86);
            nudPassMark.Location = new Point(693, 45);
            nudPassMark.Margin = new Padding(4, 5, 4, 5);
            nudPassMark.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPassMark.Name = "nudPassMark";
            nudPassMark.Size = new Size(129, 31);
            nudPassMark.TabIndex = 3;
            nudPassMark.TextAlign = HorizontalAlignment.Center;
            nudPassMark.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(59, 130, 246);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(858, 20);
            btnRefresh.Margin = new Padding(4, 5, 4, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(171, 61);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(16, 185, 129);
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(1042, 20);
            btnExport.Margin = new Padding(4, 5, 4, 5);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(186, 61);
            btnExport.TabIndex = 5;
            btnExport.Text = "Export CSV";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1611, 1039);
            Controls.Add(pnlMain);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "ReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Grade Management System";
            pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LogoutIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)ReportsIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)GradesIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)CoursesIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)DashboardIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AdminIcon).EndInit();
            pnlMain.ResumeLayout(false);
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            pnlCourseReport.ResumeLayout(false);
            pnlCourseReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            pnlKpi4.ResumeLayout(false);
            pnlKpi3.ResumeLayout(false);
            pnlKpi2.ResumeLayout(false);
            pnlKpi1.ResumeLayout(false);
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPassMark).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // Sidebar
        private Panel pnlSidebar;
        private PictureBox picLogo;
        private Label lblSystemName;
        private Button btnDashboard;
        
        private Button btnCourses;
        private Button btnGrades;
        private Button btnReports;
        
        private Button btnLogout;
        private PictureBox DashboardIcon;
        
        private PictureBox CoursesIcon;
        private PictureBox GradesIcon;
        private PictureBox ReportsIcon;
        
        private PictureBox LogoutIcon;

        // Header
        private Panel pnlHeader;
        private Button btnMenu;
        private Label lblPageTitle;
        private Label lblAdminName;
        private Label lblWelcomeBack;
        private PictureBox AdminIcon;
        private ProgressBar prgLoading;

        // Main
        private Panel pnlMain;
        private Panel pnlFilters;
        private Label lblSearch;
        private TextBox txtSearchCourse;
        private Label lblSort;
        private ComboBox cmbSort;
        private Label lblPassMark;
        private NumericUpDown nudPassMark;
        private Button btnRefresh;
        private Button btnExport;

        private Panel pnlKpi1;
        private Panel pnlAccent1;
        private Label lblKpiTitle1;
        private Label lblKpiValue1;
        private Label lblKpiSub1;
        private Panel pnlKpi2;
        private Panel pnlAccent2;
        private Label lblKpiTitle2;
        private Label lblKpiValue2;
        private Label lblKpiSub2;
        private Panel pnlKpi3;
        private Panel pnlAccent3;
        private Label lblKpiTitle3;
        private Label lblKpiValue3;
        private Label lblKpiSub3;
        private Panel pnlKpi4;
        private Panel pnlAccent4;
        private Label lblKpiTitle4;
        private Label lblKpiValue4;
        private Label lblKpiSub4;

        private Panel pnlCourseReport;
        private Label lblReportTitle;
        private Label lblUpdated;
        private DataGridView dgvCourses;
        private DataGridViewTextBoxColumn colCourse;
        private DataGridViewTextBoxColumn colStudents;
        private DataGridViewTextBoxColumn colPassed;
        private DataGridViewTextBoxColumn colFailed;
        private DataGridViewTextBoxColumn colRate;
        private DataGridViewTextBoxColumn colAverage;
        private DataGridViewTextBoxColumn colStatus;
        private Label lblFooter;

        private Panel pnlDetails;
        private Label lblDetailsTitle;
        private Label lblDetailCourse;
        private Panel pnlDonut;
        private Label lblPassedInfo;
        private Label lblFailedInfo;
        private Label lblAvgInfo;
        private Label lblHighInfo;
        private Label lblLowInfo;
        private Label lblGradeTitle;
        private Panel pnlGradeDist;
        private Label lblDatabaseStatus;
    }
}