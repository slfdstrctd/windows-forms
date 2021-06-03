//-------------------------------------------
// ClockControl.cs (R) 2001 by Charles Petzold
//-------------------------------------------

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace bezierclock
{
    public class ClockControl : UserControl
    {
        DateTime dt;

        public ClockControl()
        {
            ResizeRedraw = true;
            Enabled = false;
        }

        public DateTime Time
        {
            get { return dt; }
            set
            {
                Graphics grfx = CreateGraphics();
                InitializeCoordinates(grfx);

                Pen pen = new Pen(BackColor);

                if (dt.Hour != value.Hour)
                {
                    DrawHourHand(grfx, pen);
                }

                if (dt.Minute != value.Minute)
                {
                    DrawHourHand(grfx, pen);
                    DrawMinuteHand(grfx, pen);
                }

                if (dt.Second != value.Second)
                {
                    DrawMinuteHand(grfx, pen);
                    DrawSecondHand(grfx, pen);
                }

                if (dt.Millisecond != value.Millisecond)
                {
                    DrawSecondHand(grfx, pen);
                }

                dt = value;
                pen = new Pen(ForeColor);

                DrawHourHand(grfx, pen);
                DrawMinuteHand(grfx, pen);
                DrawSecondHand(grfx, pen);

                grfx.Dispose();
            }
        }

        protected override void OnPaint(PaintEventArgs pea)
        {
            Graphics grfx = pea.Graphics;
            Pen pen = new Pen(ForeColor);
            Brush brush = new SolidBrush(ForeColor);

            InitializeCoordinates(grfx);
            DrawDots(grfx, brush);
            DrawHourHand(grfx, pen);
            DrawMinuteHand(grfx, pen);
            DrawSecondHand(grfx, pen);
        }

        void InitializeCoordinates(Graphics grfx)
        {
            if (Width == 0 || Height == 0)
                return;

            grfx.TranslateTransform(Width / 2, Height / 2);

            float fInches = Math.Min(Width / grfx.DpiX, Height / grfx.DpiY);

            grfx.ScaleTransform(fInches * grfx.DpiX / 2000,
                fInches * grfx.DpiY / 2000);
        }

        void DrawDots(Graphics grfx, Brush brush)
        {
            for (int i = 0; i < 60; i++)
            {
                int iSize = i % 5 == 0 ? 100 : 30;
                grfx.FillRectangle(brush, 0 - iSize / 2, -900 - iSize / 2,
                    iSize, iSize);
                //grfx.FillEllipse(brush, 0 - iSize / 2, -900 - iSize / 2,
                //   iSize, iSize);
                grfx.RotateTransform(6);
            }
        }

        protected virtual void DrawHourHand(Graphics grfx, Pen pen)
        {
            GraphicsState gs = grfx.Save();
            grfx.RotateTransform(360f * Time.Hour / 12 +
                                 30f * Time.Minute / 60);

            grfx.DrawPolygon(pen, new Point[]
            {
                new Point(0, 150), new Point(100, 0),
                new Point(0, -600), new Point(-100, 0)
            });
            grfx.Restore(gs);
        }

        protected virtual void DrawMinuteHand(Graphics grfx, Pen pen)
        {
            GraphicsState gs = grfx.Save();
            grfx.RotateTransform(360f * Time.Minute / 60 +
                                 6f * Time.Second / 60);

            grfx.DrawPolygon(pen, new Point[]
            {
                new Point(0, 200), new Point(50, 0),
                new Point(0, -800), new Point(-50, 0)
            });
            grfx.Restore(gs);
        }

        protected virtual void DrawSecondHand(Graphics grfx, Pen pen)
        {
            GraphicsState gs = grfx.Save();
            grfx.RotateTransform(360f * Time.Second / 60 +
                                 6f * Time.Millisecond / 1000);

            grfx.DrawLine(pen, 0, 0, 0, -800);
            grfx.Restore(gs);
            
        }
    }
}