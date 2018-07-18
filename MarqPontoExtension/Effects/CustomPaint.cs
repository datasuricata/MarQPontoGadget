using MarqPontoExtension.Utils;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MarqPontoExtension.Effects
{
    public static class CustomPaint
    {
        public static void DefaultBorder(object sender, PaintEventArgs e, Form form)
        {
            StoreEffect(sender, e, form, new Pen(Color.SteelBlue, 1));
        }

        public static void StoreEffect(object sender, PaintEventArgs e, Form form, Pen pen)
        {
            Graphics draw = e.Graphics;
            draw.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle area = form.ClientRectangle;
            area.Width -= 1;
            area.Height -= 1;

            Pen outline = pen;
            draw.FillRectangle(Brushes.Transparent, form.ClientRectangle);
            draw.DrawRectangle(outline, area);

            outline.Dispose();
        }
    }
}
