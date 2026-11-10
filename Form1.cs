
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Grades
{
    public partial class GradesForm : Form
    {
        public GradesForm()
        {
            InitializeComponent();

            // Menu button
            btnMenu.Click += btnMenu_Click;

            // Dashboard navigation
            btnDashboard.Click += btnDashboard_Click;
            DashboardIcon.Click += btnDashboard_Click;

            // Admin profile image
            MakeAdminIconCircular();

            // Form settings
            SetupForm();
        }

        private void SetupForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            // Enable resizing
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;

            // Enable scrolling when content exceeds visible area
            this.AutoScroll = true;
            this.AutoScrollMinSize = new Size(1627, 1096);

            // Keep a reasonable minimum window size
            this.MinimumSize = new Size(900, 600);
        }

        private void MakeAdminIconCircular()
        {
            if (AdminIcon.Image == null)
                return;

            GraphicsPath path = new GraphicsPath();

            path.AddEllipse(
                0,
                0,
                AdminIcon.Width,
                AdminIcon.Height
            );

            AdminIcon.Region?.Dispose();
            AdminIcon.Region = new Region(path);

            path.Dispose();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            pnlSidebar.Visible = !pnlSidebar.Visible;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        // Open Students Grades page
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Students__Grades.GradesForm gradesForm =
                new Students__Grades.GradesForm();

            gradesForm.StartPosition = FormStartPosition.CenterScreen;

            gradesForm.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();
            gradesForm.Show();
        }

        // Open Dashboard page
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            StudentGradeManagementSystem.DashboardForm dashboardForm =
                new StudentGradeManagementSystem.DashboardForm();

            dashboardForm.StartPosition = FormStartPosition.CenterScreen;

            dashboardForm.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();
            dashboardForm.Show();
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
