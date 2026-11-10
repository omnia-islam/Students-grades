
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.ComponentModel;

namespace Students__Grades
{
    // =========================================
    // Custom Rounded Button
    // =========================================
    public class RoundedButton : Button
    {
        private const int ButtonRadius = 12;
        private const int ScaleFactor = 4;

        private bool isHovered;
        private bool isPressed;

        [Browsable(false)]
        [DesignerSerializationVisibility(
            DesignerSerializationVisibility.Hidden)]
        public Color SurfaceColor { get; set; } = Color.White;

        public RoundedButton()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor,
                true);

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.Transparent;

            UseVisualStyleBackColor = false;
            TextAlign = ContentAlignment.MiddleCenter;
            Cursor = Cursors.Hand;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.Clear(SurfaceColor);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHovered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHovered = false;
            isPressed = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                isPressed = true;
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            isPressed = false;
            Invalidate();
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Width <= 0 || Height <= 0)
                return;

            Color buttonColor = BackColor;

            if (!Enabled)
                buttonColor = SystemColors.ControlDark;
            else if (isPressed)
                buttonColor = ControlPaint.Dark(BackColor, 0.12f);
            else if (isHovered)
                buttonColor = ControlPaint.Light(BackColor, 0.12f);

            int highWidth = Width * ScaleFactor;
            int highHeight = Height * ScaleFactor;

            using (Bitmap bitmap = new Bitmap(
                highWidth,
                highHeight,
                PixelFormat.Format32bppPArgb))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.Clear(SurfaceColor);

                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    g.CompositingQuality = CompositingQuality.HighQuality;

                    g.ScaleTransform(ScaleFactor, ScaleFactor);

                    RectangleF shadowRect = new RectangleF(
                        1.5f, 3f, Width - 3f, Height - 5f);

                    using (GraphicsPath shadowPath =
                        CreateButtonPath(shadowRect, ButtonRadius))
                    using (SolidBrush shadowBrush =
                        new SolidBrush(Color.FromArgb(55, 20, 35, 60)))
                    {
                        g.FillPath(shadowBrush, shadowPath);
                    }

                    RectangleF rect = new RectangleF(
                        1f, 0.5f, Width - 2f, Height - 4f);

                    using (GraphicsPath path =
                        CreateButtonPath(rect, ButtonRadius))
                    using (SolidBrush brush =
                        new SolidBrush(buttonColor))
                    {
                        g.FillPath(brush, path);
                    }
                }

                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.Graphics.InterpolationMode =
                    InterpolationMode.HighQualityBicubic;
                e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                e.Graphics.DrawImage(
                    bitmap,
                    new Rectangle(0, 0, Width, Height),
                    0, 0, highWidth, highHeight,
                    GraphicsUnit.Pixel);
            }

            TextRenderer.DrawText(
                e.Graphics,
                Text,
                Font,
                ClientRectangle,
                Enabled ? ForeColor : SystemColors.GrayText,
                TextFormatFlags.HorizontalCenter |
                TextFormatFlags.VerticalCenter |
                TextFormatFlags.SingleLine |
                TextFormatFlags.EndEllipsis);
        }

        private GraphicsPath CreateButtonPath(
            RectangleF rect,
            float radius)
        {
            GraphicsPath path = new GraphicsPath();

            float diameter = Math.Min(
                radius * 2,
                Math.Min(rect.Width, rect.Height));

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();
            return path;
        }
    }

    // =========================================
    // Custom Dropdown
    // =========================================
    public class CompactComboBox : ComboBox
    {
        public CompactComboBox()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            FlatStyle = FlatStyle.Flat;
        }
    }

    // =========================================
    // Grades Form Appearance
    // =========================================
    public partial class GradesForm
    {
        private readonly Color sectionTitleBackColor =
            Color.FromArgb(205, 220, 235);

        private readonly Color sectionTitleForeColor =
            Color.FromArgb(23, 59, 108);

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ApplyGradesListAppearance();
            ApplySearchButtonAppearance();

            dgvGrades.CellFormatting -= dgvGrades_CellFormatting;
            dgvGrades.CellFormatting += dgvGrades_CellFormatting;
        }

        // =====================================
        // Grades List Appearance
        // =====================================
        private void ApplyGradesListAppearance()
        {
            if (pnlGradeList != null)
            {
                pnlGradeList.BorderStyle = BorderStyle.None;
                pnlGradeList.BackColor = Color.White;

                pnlGradeList.Paint -= RoundedPanel_Paint;
                pnlGradeList.Paint += RoundedPanel_Paint;

                pnlGradeList.Resize -= RoundedPanel_Resize;
                pnlGradeList.Resize += RoundedPanel_Resize;

                UpdateRoundedPanelRegion();
            }

            if (lblGradesList != null)
            {
                lblGradesList.AutoSize = false;
                lblGradesList.BackColor = sectionTitleBackColor;
                lblGradesList.ForeColor = sectionTitleForeColor;

                lblGradesList.Font = new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

                lblGradesList.TextAlign =
                    ContentAlignment.MiddleCenter;

                lblGradesList.Paint -= SectionTitle_Paint;
                lblGradesList.Paint += SectionTitle_Paint;

                lblGradesList.Resize -= SectionTitle_Resize;
                lblGradesList.Resize += SectionTitle_Resize;

                UpdateSectionTitleRegion();
            }
        }

        // =====================================
        // Search Button
        // =====================================
        private void ApplySearchButtonAppearance()
        {
            if (btnSearchGrade == null)
                return;

            btnSearchGrade.SurfaceColor = Color.White;
            btnSearchGrade.BackColor =
                Color.FromArgb(228, 238, 252);

            btnSearchGrade.ForeColor =
                Color.FromArgb(23, 59, 108);

            btnSearchGrade.Font = new Font(
                "Segoe UI",
                8F,
                FontStyle.Bold);

            btnSearchGrade.FlatStyle = FlatStyle.Flat;
            btnSearchGrade.FlatAppearance.BorderSize = 0;
            btnSearchGrade.UseVisualStyleBackColor = false;
            btnSearchGrade.Cursor = Cursors.Hand;

            btnSearchGrade.Invalidate();
        }

        // =====================================
        // Grade Colors
        // =====================================
        private void dgvGrades_CellFormatting(
            object sender,
            DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvGrades.Columns[e.ColumnIndex].Name !=
                "colGradeLetter")
                return;

            if (e.Value == null || e.Value == DBNull.Value)
                return;

            string grade = e.Value.ToString().Trim().ToUpper();

            if (grade == "A" || grade == "B")
            {
                e.CellStyle.BackColor =
                    Color.FromArgb(212, 239, 223);

                e.CellStyle.ForeColor =
                    Color.FromArgb(20, 90, 50);

                e.CellStyle.SelectionBackColor =
                    Color.FromArgb(190, 225, 205);

                e.CellStyle.SelectionForeColor =
                    Color.FromArgb(20, 90, 50);
            }
            else if (grade == "F")
            {
                e.CellStyle.BackColor =
                    Color.FromArgb(250, 219, 216);

                e.CellStyle.ForeColor =
                    Color.FromArgb(146, 43, 33);

                e.CellStyle.SelectionBackColor =
                    Color.FromArgb(240, 195, 190);

                e.CellStyle.SelectionForeColor =
                    Color.FromArgb(146, 43, 33);
            }
        }

        // =====================================
        // Rounded Section Title
        // =====================================
        private void SectionTitle_Paint(
            object sender,
            PaintEventArgs e)
        {
            Label title = sender as Label;

            if (title == null ||
                title.Width <= 0 ||
                title.Height <= 0)
                return;

            e.Graphics.SmoothingMode =
                SmoothingMode.AntiAlias;

            RectangleF rect = new RectangleF(
                0.5f,
                0.5f,
                title.Width - 1f,
                title.Height - 1f);

            using (GraphicsPath path =
                CreateAppearancePath(rect, 9f))
            using (SolidBrush brush =
                new SolidBrush(sectionTitleBackColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            TextRenderer.DrawText(
                e.Graphics,
                title.Text,
                title.Font,
                Rectangle.Round(rect),
                sectionTitleForeColor,
                TextFormatFlags.HorizontalCenter |
                TextFormatFlags.VerticalCenter |
                TextFormatFlags.SingleLine |
                TextFormatFlags.EndEllipsis);
        }

        private void SectionTitle_Resize(
            object sender,
            EventArgs e)
        {
            UpdateSectionTitleRegion();
        }

        private void UpdateSectionTitleRegion()
        {
            if (lblGradesList == null ||
                lblGradesList.Width <= 0 ||
                lblGradesList.Height <= 0)
                return;

            using (GraphicsPath path = CreateAppearancePath(
                new RectangleF(
                    0,
                    0,
                    lblGradesList.Width,
                    lblGradesList.Height),
                9f))
            {
                Region oldRegion = lblGradesList.Region;
                lblGradesList.Region = new Region(path);

                if (oldRegion != null)
                    oldRegion.Dispose();
            }

            lblGradesList.Invalidate();
        }

        // =====================================
        // Rounded Grades List Panel
        // =====================================
        private void RoundedPanel_Resize(
            object sender,
            EventArgs e)
        {
            UpdateRoundedPanelRegion();
        }

        private void UpdateRoundedPanelRegion()
        {
            if (pnlGradeList == null ||
                pnlGradeList.Width <= 0 ||
                pnlGradeList.Height <= 0)
                return;

            using (GraphicsPath path = CreateAppearancePath(
                new RectangleF(
                    0,
                    0,
                    pnlGradeList.Width,
                    pnlGradeList.Height),
                18f))
            {
                Region oldRegion = pnlGradeList.Region;
                pnlGradeList.Region = new Region(path);

                if (oldRegion != null)
                    oldRegion.Dispose();
            }

            pnlGradeList.Invalidate();
        }

        private void RoundedPanel_Paint(
            object sender,
            PaintEventArgs e)
        {
            if (pnlGradeList == null ||
                pnlGradeList.Width <= 0 ||
                pnlGradeList.Height <= 0)
                return;

            e.Graphics.SmoothingMode =
                SmoothingMode.AntiAlias;

            RectangleF rect = new RectangleF(
                0.75f,
                0.75f,
                pnlGradeList.Width - 1.5f,
                pnlGradeList.Height - 1.5f);

            using (GraphicsPath path =
                CreateAppearancePath(rect, 18f))
            using (SolidBrush brush =
                new SolidBrush(Color.White))
            using (Pen borderPen =
                new Pen(Color.FromArgb(220, 230, 243), 1f))
            {
                e.Graphics.FillPath(brush, path);
                e.Graphics.DrawPath(borderPen, path);
            }
        }

        // =====================================
        // Rounded Path Helper
        // Unique name to avoid conflicts
        // =====================================
        private GraphicsPath CreateAppearancePath(
            RectangleF rect,
            float radius)
        {
            GraphicsPath path = new GraphicsPath();

            if (rect.Width <= 0 || rect.Height <= 0)
                return path;

            float diameter = Math.Min(
                radius * 2,
                Math.Min(rect.Width, rect.Height));

            path.AddArc(
                rect.X, rect.Y,
                diameter, diameter,
                180, 90);

            path.AddArc(
                rect.Right - diameter, rect.Y,
                diameter, diameter,
                270, 90);

            path.AddArc(
                rect.Right - diameter,
                rect.Bottom - diameter,
                diameter, diameter,
                0, 90);

            path.AddArc(
                rect.X,
                rect.Bottom - diameter,
                diameter, diameter,
                90, 90);

            path.CloseFigure();

            return path;
        }
    }
}
