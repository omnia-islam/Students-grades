
using System;
using System.Drawing;
using System.Windows.Forms;

namespace student_managment_system
{
    public partial class frmLoginForm : Form
    {
        private const int TargetFormWidth = 1627;
        private const int TargetFormHeight = 1096;

        public frmLoginForm()
        {
            InitializeComponent();

            ApplyStandardFormSize();

        }

        private void ApplyStandardFormSize()
        {
            // Save the original design dimensions.
            Size originalClientSize = this.ClientSize;

            // Set the required OUTER Form size.
            this.Size = new Size(
                TargetFormWidth,
                TargetFormHeight
            );

            // Get the actual available content area.
            Size targetClientSize = this.ClientSize;

            float scaleX =
                (float)targetClientSize.Width / originalClientSize.Width;

            float scaleY =
                (float)targetClientSize.Height / originalClientSize.Height;

            // Scale all controls and their nested controls.
            ScaleAllControls(this, scaleX, scaleY);

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ScaleAllControls(
            Control parent,
            float scaleX,
            float scaleY)
        {
            float fontScale = (float)Math.Sqrt(scaleX * scaleY);

            foreach (Control control in parent.Controls)
            {
                Rectangle oldBounds = control.Bounds;

                control.SetBounds(
                    (int)Math.Round(oldBounds.X * scaleX),
                    (int)Math.Round(oldBounds.Y * scaleY),
                    (int)Math.Round(oldBounds.Width * scaleX),
                    (int)Math.Round(oldBounds.Height * scaleY)
                );

                // Scale the font while preserving its style.
                if (control.Font != null)
                {
                    Font oldFont = control.Font;

                    control.Font = new Font(
                        oldFont.FontFamily,
                        Math.Max(1f, oldFont.Size * fontScale),
                        oldFont.Style,
                        oldFont.Unit,
                        oldFont.GdiCharSet,
                        oldFont.GdiVerticalFont
                    );
                }

                // Apply the same scaling to nested controls.
                ScaleAllControls(control, scaleX, scaleY);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Grades.GradesForm mainForm = new Grades.GradesForm();

            mainForm.StartPosition = FormStartPosition.CenterScreen;

            mainForm.FormClosed += (s, args) =>
            {
                this.Close();
            };

            mainForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
