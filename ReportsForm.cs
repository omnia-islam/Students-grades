using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace CS312.Proj
{
    public partial class ReportsForm : Form
    {
        private DataTable _grades;
        private DataTable _summary;
        private string _selectedCourse = null;
        private int[] _gradeCounts = new int[5];
        private bool _binding = false;

        private double PassMark
        {
            get { return (double)nudPassMark.Value; }
        }

        public ReportsForm()
        {
            InitializeComponent();

            // ضبط المقاس الافتراضي للشاشة الكبيرة وتفعيل التكبير والتصغير
            this.Width = 1633;
            this.Height = 1095;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // الأعمدة هتتولد تلقائيًا من الـ DataTable
            dgvCourses.AutoGenerateColumns = true;

            LoadIcons();
            MakeAdminIconCircular();

            this.Load += ReportsForm_Load;
            this.Resize += ReportsForm_Resize;

            btnRefresh.Click += BtnRefresh_Click;
            btnExport.Click += BtnExport_Click;

            txtSearchCourse.TextChanged += (s, e) => ApplyViewFilters();
            cmbSort.SelectedIndexChanged += (s, e) => ApplyViewFilters();
            nudPassMark.ValueChanged += (s, e) => RebuildFromGrades();

            dgvCourses.SelectionChanged += DgvCourses_SelectionChanged;
            dgvCourses.CellPainting += DgvCourses_CellPainting;
            dgvCourses.CellFormatting += DgvCourses_CellFormatting;

            pnlDonut.Paint += PnlDonut_Paint;
            pnlGradeDist.Paint += PnlGradeDist_Paint;

            btnMenu.Click += (s, e) =>
                pnlSidebar.Visible = !pnlSidebar.Visible;

            btnDashboard.Click += (s, e) => this.Close();

            cmbSort.SelectedIndex = 0;

            SetDoubleBuffered(pnlDonut);
            SetDoubleBuffered(pnlGradeDist);
            SetDoubleBuffered(dgvCourses);
        }

        // =========================================================
        // التحكم في إعادة تحجيم العناصر تلقائياً مع المقاسات الجديدة
        // =========================================================
        private void ReportsForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                return;

            // هنا نقدر نعمل أي تظبيط إضافي لو أخدت مقاسات مخصصة، 
            // ولكن مع استخدام الـ Anchors في الديزاين (Top, Bottom, Left, Right) 
            // العناصر هتتوزع لوحدها بكفاءة كاملة مع مقاس 1633x1095.
        }

        // =========================================================
        // الوصول للأعمدة بأسمائها بدل متغيرات Designer غير المهيأة
        // =========================================================
        private int GetColumnIndex(string columnName)
        {
            if (dgvCourses == null || dgvCourses.Columns.Count == 0)
                return -1;

            foreach (DataGridViewColumn column in dgvCourses.Columns)
            {
                if (string.Equals(column.Name, columnName,
                    StringComparison.OrdinalIgnoreCase)
                    ||
                    string.Equals(column.DataPropertyName, columnName,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return column.Index;
                }
            }

            return -1;
        }

        private static void SetDoubleBuffered(Control c)
        {
            PropertyInfo property = typeof(Control).GetProperty(
                "DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);

            property?.SetValue(c, true, null);
        }

        // =========================================================
        // فتح صفحة أخرى
        // =========================================================
        private void OpenPage(Form page)
        {
            page.StartPosition = FormStartPosition.CenterScreen;
            page.FormClosed += (s, e) => this.Show();

            this.Hide();
            page.Show();
        }

        // =========================================================
        // الأيقونات
        // =========================================================
        private void LoadIcons()
        {
            SetIcon(picLogo, "Logo");
            SetIcon(DashboardIcon, "Dashboard");

            SetIcon(CoursesIcon, "Courses");
            SetIcon(GradesIcon, "Grades");
            SetIcon(ReportsIcon, "Reports");

            SetIcon(LogoutIcon, "Logout");
            SetIcon(AdminIcon, "Admin", "User");
        }

        private static void SetIcon(PictureBox box, params string[] names)
        {
            if (box == null)
                return;

            try
            {
                var rm = Properties.Resources.ResourceManager;
                rm.IgnoreCase = true;

                foreach (string n in names)
                {
                    if (rm.GetObject(n) is Image img)
                    {
                        box.Image = img;
                        return;
                    }
                }
            }
            catch
            {
                // لو الصورة مش موجودة نكمل من غيرها
            }
        }

        private void MakeAdminIconCircular()
        {
            if (AdminIcon == null || AdminIcon.Image == null)
                return;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, AdminIcon.Width, AdminIcon.Height);
                AdminIcon.Region = new Region(path);
            }
        }

        // =========================================================
        // تحميل البيانات
        // =========================================================
        private async void ReportsForm_Load(object sender, EventArgs e)
        {
            await LoadReportAsync();
        }

        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            await LoadReportAsync();
        }

        private async System.Threading.Tasks.Task LoadReportAsync()
        {
            try
            {
                btnRefresh.Enabled = false;
                prgLoading.Visible = true;

                _grades = await System.Threading.Tasks.Task.Run(
                    () => ReportService.GetGrades());

                RebuildFromGrades();

                lblUpdated.Text =
                    "Updated " + DateTime.Now.ToString("HH:mm:ss");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load the report:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                prgLoading.Visible = false;
                btnRefresh.Enabled = true;
            }
        }

        // =========================================================
        // حساب ملخص كل مادة
        // =========================================================
        private DataTable BuildSummary(DataTable grades, double passMark)
        {
            DataTable t = new DataTable();

            t.Columns.Add("Course", typeof(string));
            t.Columns.Add("Students", typeof(int));
            t.Columns.Add("Passed", typeof(int));
            t.Columns.Add("Failed", typeof(int));
            t.Columns.Add("PassRate", typeof(double));
            t.Columns.Add("Average", typeof(double));
            t.Columns.Add("Highest", typeof(double));
            t.Columns.Add("Lowest", typeof(double));
            t.Columns.Add("Status", typeof(string));

            var groups = grades.AsEnumerable()
                .GroupBy(r => r["CourseName"].ToString());

            foreach (var g in groups)
            {
                var scores = g.Select(
                    r => Convert.ToDouble(r["Score"])).ToList();

                int total = scores.Count;
                int passed = scores.Count(s => s >= passMark);

                double rate = total == 0
                    ? 0
                    : passed * 100.0 / total;

                t.Rows.Add(
                    g.Key,
                    total,
                    passed,
                    total - passed,
                    rate,
                    scores.Average(),
                    scores.Max(),
                    scores.Min(),
                    StatusOf(rate));
            }

            return t;
        }

        private static string StatusOf(double rate)
        {
            if (rate >= 75) return "Excellent";
            if (rate >= 50) return "Average";

            return "At Risk";
        }

        private static Color RateColor(double rate)
        {
            if (rate >= 75)
                return Color.FromArgb(16, 185, 129);

            if (rate >= 50)
                return Color.FromArgb(245, 158, 11);

            return Color.FromArgb(239, 68, 68);
        }

        private static string LetterOf(double score)
        {
            if (score >= 90) return "A";
            if (score >= 80) return "B";
            if (score >= 70) return "C";
            if (score >= 60) return "D";

            return "F";
        }

        // =========================================================
        // إعادة الحساب
        // =========================================================
        private void RebuildFromGrades()
        {
            if (_grades == null)
                return;

            _summary = BuildSummary(_grades, PassMark);

            UpdateKpis();
            ApplyViewFilters();
        }

        // =========================================================
        // البحث والترتيب
        // =========================================================
        private void ApplyViewFilters()
        {
            if (_summary == null)
                return;

            _binding = true;

            try
            {
                string searchText = txtSearchCourse.Text.Trim()
                    .Replace("'", "''")
                    .Replace("[", "[[]")
                    .Replace("%", "[%]")
                    .Replace("*", "[*]");

                _summary.DefaultView.RowFilter =
                    searchText == ""
                    ? ""
                    : "Course LIKE '%" + searchText + "%'";

                switch (cmbSort.SelectedIndex)
                {
                    case 1:
                        _summary.DefaultView.Sort = "PassRate ASC";
                        break;

                    case 2:
                        _summary.DefaultView.Sort = "Average DESC";
                        break;

                    case 3:
                        _summary.DefaultView.Sort = "Course ASC";
                        break;

                    case 4:
                        _summary.DefaultView.Sort = "Students DESC";
                        break;

                    default:
                        _summary.DefaultView.Sort = "PassRate DESC";
                        break;
                }

                // إنشاء الأعمدة تلقائيًا من أسماء أعمدة الـ DataTable
                dgvCourses.AutoGenerateColumns = true;
                dgvCourses.DataSource = null;
                dgvCourses.DataSource = _summary.DefaultView;
            }
            finally
            {
                _binding = false;
            }

            lblFooter.Text =
                "Showing " + _summary.DefaultView.Count +
                " of " + _summary.Rows.Count +
                " courses  ·  Pass mark: " +
                PassMark.ToString("F0");

            SelectCourse(_selectedCourse);
        }

        // =========================================================
        // اختيار المادة في الجدول
        // =========================================================
        private void SelectCourse(string courseName)
        {
            if (dgvCourses.Rows.Count == 0)
            {
                ClearDetails();
                return;
            }

            int courseIndex = GetColumnIndex("Course");

            if (courseIndex < 0)
            {
                ClearDetails();
                return;
            }

            int selectedIndex = 0;

            if (courseName != null)
            {
                for (int i = 0; i < dgvCourses.Rows.Count; i++)
                {
                    string currentCourse = Convert.ToString(
                        dgvCourses.Rows[i].Cells[courseIndex].Value);

                    if (currentCourse == courseName)
                    {
                        selectedIndex = i;
                        break;
                    }
                }
            }

            dgvCourses.ClearSelection();

            dgvCourses.Rows[selectedIndex].Selected = true;

            dgvCourses.CurrentCell =
                dgvCourses.Rows[selectedIndex].Cells[courseIndex];

            ShowDetails();
        }

        private void DgvCourses_SelectionChanged(object sender, EventArgs e)
        {
            if (_binding)
                return;

            ShowDetails();
        }

        // =========================================================
        // إحصائيات أعلى الصفحة
        // =========================================================
        private void UpdateKpis()
        {
            if (_grades == null ||
                _summary == null ||
                _summary.Rows.Count == 0)
            {
                lblKpiValue1.Text = "0";
                lblKpiValue2.Text = "0";
                lblKpiValue3.Text = "0%";
                lblKpiValue4.Text = "-";
                lblKpiSub4.Text = "";

                return;
            }

            lblKpiValue1.Text = _summary.Rows.Count.ToString();

            lblKpiValue2.Text = _grades.AsEnumerable()
                .Select(r => r["StudentID"])
                .Distinct()
                .Count()
                .ToString();

            int totalRecords = _grades.Rows.Count;

            int passedRecords = _grades.AsEnumerable()
                .Count(r =>
                    Convert.ToDouble(r["Score"]) >= PassMark);

            lblKpiValue3.Text =
                (passedRecords * 100.0 / totalRecords)
                .ToString("F0") + "%";

            DataRow best = _summary.AsEnumerable()
                .OrderByDescending(r => (double)r["PassRate"])
                .First();

            lblKpiValue4.Text = best["Course"].ToString();

            lblKpiSub4.Text =
                ((double)best["PassRate"]).ToString("F0") +
                "% pass rate";
        }

        // =========================================================
        // تفاصيل المادة المختارة
        // =========================================================
        private DataRow SelectedSummaryRow()
        {
            if (_summary == null || dgvCourses.CurrentRow == null)
                return null;

            int courseIndex = GetColumnIndex("Course");

            if (courseIndex < 0)
                return null;

            string name = Convert.ToString(
                dgvCourses.CurrentRow.Cells[courseIndex].Value);

            return _summary.AsEnumerable()
                .FirstOrDefault(r =>
                    r["Course"].ToString() == name);
        }

        private void ShowDetails()
        {
            DataRow row = SelectedSummaryRow();

            if (row == null)
            {
                ClearDetails();
                return;
            }

            _selectedCourse = row["Course"].ToString();

            lblDetailCourse.Text = _selectedCourse;
            lblPassedInfo.Text = "Passed: " + row["Passed"];
            lblFailedInfo.Text = "Failed: " + row["Failed"];

            lblAvgInfo.Text =
                "Average: " +
                ((double)row["Average"]).ToString("F1");

            lblHighInfo.Text =
                "Highest: " +
                ((double)row["Highest"]).ToString("F0");

            lblLowInfo.Text =
                "Lowest: " +
                ((double)row["Lowest"]).ToString("F0");

            _gradeCounts = new int[5];

            string[] letters = { "A", "B", "C", "D", "F" };

            foreach (DataRow r in _grades.AsEnumerable()
                .Where(r =>
                    r["CourseName"].ToString() == _selectedCourse))
            {
                int index = Array.IndexOf(
                    letters,
                    LetterOf(Convert.ToDouble(r["Score"])));

                if (index >= 0)
                    _gradeCounts[index]++;
            }

            pnlDonut.Invalidate();
            pnlGradeDist.Invalidate();
        }

        private void ClearDetails()
        {
            _selectedCourse = null;
            _gradeCounts = new int[5];

            lblDetailCourse.Text = "No course";
            lblPassedInfo.Text = "Passed: -";
            lblFailedInfo.Text = "Failed: -";
            lblAvgInfo.Text = "Average: -";
            lblHighInfo.Text = "Highest: -";
            lblLowInfo.Text = "Lowest: -";

            pnlDonut.Invalidate();
            pnlGradeDist.Invalidate();
        }

        // =========================================================
        // رسم شريط نسبة النجاح
        // =========================================================
        private void DgvCourses_CellPainting(
            object sender,
            DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int rateIndex = GetColumnIndex("PassRate");

            if (rateIndex < 0 || e.ColumnIndex != rateIndex)
                return;

            e.Paint(
                e.CellBounds,
                DataGridViewPaintParts.Background |
                DataGridViewPaintParts.Border |
                DataGridViewPaintParts.SelectionBackground);

            double rate = 0;

            if (e.Value != null && e.Value != DBNull.Value)
                rate = Convert.ToDouble(e.Value);

            int barX = e.CellBounds.X + 10;
            int barW = e.CellBounds.Width - 70;
            int barH = 10;
            int barY = e.CellBounds.Y +
                (e.CellBounds.Height - barH) / 2;

            if (barW > 10)
            {
                using (var track = new SolidBrush(
                    Color.FromArgb(229, 231, 235)))
                using (var fill = new SolidBrush(RateColor(rate)))
                {
                    e.Graphics.FillRectangle(
                        track, barX, barY, barW, barH);

                    e.Graphics.FillRectangle(
                        fill,
                        barX,
                        barY,
                        (int)(barW *
                        Math.Max(0, Math.Min(100, rate)) / 100.0),
                        barH);
                }
            }

            Rectangle textRect = new Rectangle(
                barX + barW + 4,
                e.CellBounds.Y,
                52,
                e.CellBounds.Height);

            TextRenderer.DrawText(
                e.Graphics,
                rate.ToString("F0") + "%",
                e.CellStyle.Font,
                textRect,
                Color.FromArgb(31, 45, 75),
                TextFormatFlags.VerticalCenter |
                TextFormatFlags.Left);

            e.Handled = true;
        }

        // =========================================================
        // ألوان الحالة
        // =========================================================
        private void DgvCourses_CellFormatting(
            object sender,
            DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null)
                return;

            int statusIndex = GetColumnIndex("Status");

            if (statusIndex < 0 || e.ColumnIndex != statusIndex)
                return;

            switch (Convert.ToString(e.Value))
            {
                case "Excellent":
                    e.CellStyle.ForeColor =
                        Color.FromArgb(16, 185, 129);
                    break;

                case "Average":
                    e.CellStyle.ForeColor =
                        Color.FromArgb(217, 119, 6);
                    break;

                default:
                    e.CellStyle.ForeColor =
                        Color.FromArgb(239, 68, 68);
                    break;
            }

            e.CellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            e.CellStyle.SelectionForeColor =
                e.CellStyle.ForeColor;
        }

        // =========================================================
        // رسم الدونات
        // =========================================================
        private void PnlDonut_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            DataRow row = SelectedSummaryRow();

            double rate = row == null
                ? 0
                : (double)row["PassRate"];

            Rectangle r = new Rectangle(
                12,
                12,
                pnlDonut.Width - 24,
                pnlDonut.Height - 24);

            using (var back = new Pen(
                Color.FromArgb(254, 202, 202), 14))
            using (var front = new Pen(RateColor(rate), 14))
            {
                g.DrawEllipse(back, r);

                if (row != null && rate > 0)
                {
                    front.StartCap = LineCap.Flat;
                    front.EndCap = LineCap.Flat;

                    float sweep = (float)(
                        360.0 * Math.Min(rate, 99.99) / 100.0);

                    if (rate >= 100)
                        g.DrawEllipse(front, r);
                    else
                        g.DrawArc(front, r, -90, sweep);
                }
            }

            using (var big = new Font(
                "Segoe UI", 15F, FontStyle.Bold))
            using (var small = new Font("Segoe UI", 8F))
            using (var navy = new SolidBrush(
                Color.FromArgb(31, 45, 75)))
            using (var gray = new SolidBrush(
                Color.FromArgb(107, 114, 128)))
            using (var sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            })
            {
                g.DrawString(
                    row == null ? "-" : rate.ToString("F0") + "%",
                    big,
                    navy,
                    new RectangleF(
                        0,
                        pnlDonut.Height / 2f - 16,
                        pnlDonut.Width,
                        26),
                    sf);

                g.DrawString(
                    "pass rate",
                    small,
                    gray,
                    new RectangleF(
                        0,
                        pnlDonut.Height / 2f + 8,
                        pnlDonut.Width,
                        16),
                    sf);
            }
        }

        // =========================================================
        // توزيع الدرجات A إلى F
        // =========================================================
        private void PnlGradeDist_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            string[] letters = { "A", "B", "C", "D", "F" };

            Color[] colors =
            {
                Color.FromArgb(16, 185, 129),
                Color.FromArgb(59, 130, 246),
                Color.FromArgb(139, 92, 246),
                Color.FromArgb(245, 158, 11),
                Color.FromArgb(239, 68, 68)
            };

            int max = Math.Max(1, _gradeCounts.Max());

            int rowH = pnlGradeDist.Height / 5;
            int labelW = 22;
            int countW = 30;

            int barMax =
                pnlGradeDist.Width - labelW - countW - 10;

            using (var font = new Font(
                "Segoe UI", 9F, FontStyle.Bold))
            using (var navy = new SolidBrush(
                Color.FromArgb(31, 45, 75)))
            using (var track = new SolidBrush(
                Color.FromArgb(243, 244, 246)))
            {
                for (int i = 0; i < 5; i++)
                {
                    int y = i * rowH + 4;
                    int h = rowH - 10;

                    g.DrawString(letters[i], font, navy, 0, y - 1);

                    g.FillRectangle(
                        track, labelW, y + 2, barMax, h - 2);

                    int w = (int)(
                        barMax * (_gradeCounts[i] / (double)max));

                    if (w > 0)
                    {
                        using (var b = new SolidBrush(colors[i]))
                        {
                            g.FillRectangle(
                                b, labelW, y + 2, w, h - 2);
                        }
                    }

                    g.DrawString(
                        _gradeCounts[i].ToString(),
                        font,
                        navy,
                        labelW + barMax + 6,
                        y - 1);
                }
            }
        }

        // =========================================================
        // تصدير CSV
        // =========================================================
        private void BtnExport_Click(object sender, EventArgs e)
        {
            if (_summary == null ||
                _summary.DefaultView.Count == 0)
            {
                MessageBox.Show(
                    "There is no data to export.",
                    "Export",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            using (var sfd = new SaveFileDialog
            {
                Filter = "CSV file|*.csv",
                FileName = "CourseReport.csv"
            })
            {
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    DataTable view = _summary.DefaultView.ToTable(
                        false,
                        "Course",
                        "Students",
                        "Passed",
                        "Failed",
                        "PassRate",
                        "Average",
                        "Status");

                    var sb = new StringBuilder();

                    sb.AppendLine(string.Join(",",
                        view.Columns.Cast<DataColumn>()
                            .Select(c => c.ColumnName)));

                    foreach (DataRow r in view.Rows)
                    {
                        sb.AppendLine(string.Join(",",
                            r.ItemArray.Select(v =>
                                "\"" +
                                Convert.ToString(v)
                                    .Replace("\"", "\"\"") +
                                "\"")));
                    }

                    File.WriteAllText(
                        sfd.FileName,
                        sb.ToString(),
                        new UTF8Encoding(true));

                    MessageBox.Show(
                        "Exported successfully!",
                        "Export",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Export failed:\n" + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
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