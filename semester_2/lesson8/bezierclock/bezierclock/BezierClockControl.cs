using System.Drawing;
using System.Drawing.Drawing2D;


namespace bezierclock
{
    public class BezierClockControl : ClockControl
    {
        protected override void DrawHourHand(Graphics grfx, Pen pen)
        {
            GraphicsState gs = grfx.Save();
            grfx.RotateTransform(360f * Time.Hour / 12 +
                                 30f * Time.Minute / 60);

            grfx.DrawBeziers(pen, new Point[]
            {
                new Point(0, -650), //start 
                new Point(0, -300),
                new Point(-100, -300),
                new Point(50, 0), //end - start
                new Point(50, 0),
                new Point(50, 0),
                new Point(50, 0), //end - start
                new Point(50, 75),
                new Point(-50, 75),
                new Point(-50, 0), //end - start
                new Point(-50, 0),
                new Point(-50, 0),
                new Point(-50, 0), //end - start
                new Point(100, -300),
                new Point(0, -300),
                new Point(0, -650), //end
            });
            grfx.Restore(gs);
        }

        protected override void DrawMinuteHand(Graphics grfx, Pen pen)
        {
            GraphicsState gs = grfx.Save();
            grfx.RotateTransform(360f * Time.Minute / 60 +
                                 6f * Time.Second / 60);

            grfx.DrawBeziers(pen, new Point[]
            {
                new Point(00, -750), //start 
                new Point(0, -300),
                new Point(-50, -300),
                new Point(50, 0), //end - start
                new Point(50, 0),
                new Point(50, 0),
                new Point(50, 0), //end - start
                new Point(50, 75),
                new Point(-50, 75),
                new Point(-50, 0), //end - start
                new Point(-50, 0),
                new Point(-50, 0),
                new Point(-50, 0), //end - start
                new Point(50, -300),
                new Point(0, -300),
                new Point(0, -750), //end
            });
            grfx.Restore(gs);
        }
    }
}