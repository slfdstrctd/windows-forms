using System.Drawing;
using System.Windows.Forms;

namespace JeuDeTaquin
{
    internal class JeuDeTaquinTile : UserControl
    {
        private readonly int iNum;

        public JeuDeTaquinTile(int iNum)
        {
            this.iNum = iNum;
            Enabled = false;
        }

        protected override void OnPaint(PaintEventArgs pea)
        {
            var grfx = pea.Graphics;

            grfx.Clear(SystemColors.Control);

            var cx = Size.Width;
            var cy = Size.Height;
            var wx = SystemInformation.FrameBorderSize.Width;
            var wy = SystemInformation.FrameBorderSize.Height;

            grfx.FillPolygon(SystemBrushes.ControlLightLight,
                new[]
                {
                    new Point(0, cy), new Point(0, 0),
                    new Point(cx, 0), new Point(cx - wx, wy),
                    new Point(wx, wy), new Point(wx, cy - wy)
                });

            grfx.FillPolygon(SystemBrushes.ControlDark,
                new[]
                {
                    new Point(cx, 0), new Point(cx, cy),
                    new Point(0, cy), new Point(wx, cy - wy),
                    new Point(cx - wx, cy - wy),
                    new Point(cx - wx, wy)
                });

            var font = new Font("Arial", 24);
            var strfmt = new StringFormat();
            strfmt.Alignment = strfmt.LineAlignment = StringAlignment.Center;

            grfx.DrawString(iNum.ToString(), font, SystemBrushes.ControlText,
                ClientRectangle, strfmt);
        }
    }
}