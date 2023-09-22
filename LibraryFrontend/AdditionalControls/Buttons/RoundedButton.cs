using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace LibraryUI.AdditionalControls.Buttons
{
    public class RoundedButton : Button
    {
        private int borderRadius = 50;

        [Category("Appearance")]
        public int BorderRadius { get => borderRadius; set => borderRadius = value; }

        static GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float m = 2.75F;
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new();

            GraphPath.AddArc(Rect.X + m, Rect.Y + m, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2 + m, Rect.Y + m, Rect.Width - r2 - m, Rect.Y + m);
            GraphPath.AddArc(Rect.X + Rect.Width - radius - m, Rect.Y + m, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width - m, Rect.Y + r2, Rect.Width - m, Rect.Height - r2 - m);
            GraphPath.AddArc(Rect.X + Rect.Width - radius - m,
                           Rect.Y + Rect.Height - radius - m, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2 - m, Rect.Height - m, Rect.X + r2 - m, Rect.Height - m);
            GraphPath.AddArc(Rect.X + m, Rect.Y + Rect.Height - radius - m, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X + m, Rect.Height - r2 - m, Rect.X + m, Rect.Y + r2 + m);

            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            
            float borderThickness = 1.75f;
            base.OnPaint(e);
            RectangleF Rect = new(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = GetRoundPath(Rect, borderRadius);

            this.Region = new Region(GraphPath);
            using Pen pen = new(this.Parent.BackColor, borderThickness);
            pen.Alignment = PenAlignment.Inset;
            e.Graphics.DrawPath(pen, GraphPath);
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            this.Invalidate(true);
            base.OnSizeChanged(e);
        }
    }
}
