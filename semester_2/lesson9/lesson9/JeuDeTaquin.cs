using System;
using System.Drawing;
using System.Windows.Forms;

namespace JeuDeTaquin
{
    internal class JeuDeTaquin : Form
    {
        private const int nRows = 4;
        private const int nCols = 4;
        private readonly JeuDeTaquinTile[,] atile = new JeuDeTaquinTile[nRows, nCols];
        private int iTimerCountdown;
        private Point ptBlank;
        private Random rand;
        private Size sizeTile;

        public JeuDeTaquin()
        {
            Text = "Jeu de Taquin";
            FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        public static void Main()
        {
            Application.Run(new JeuDeTaquin());
        }

        protected override void OnLoad(EventArgs ea)
        {
            var grfx = CreateGraphics();

            sizeTile = new Size((int) (2 * grfx.DpiX / 3),
                (int) (2 * grfx.DpiY / 3));
            ClientSize = new Size(nCols * sizeTile.Width,
                nRows * sizeTile.Height);
            grfx.Dispose();


            for (var iRow = 0; iRow < nRows; iRow++)
            for (var iCol = 0; iCol < nCols; iCol++)
            {
                var iNum = iRow * nCols + iCol + 1;

                if (iNum == nRows * nCols)
                    continue;

                var tile = new JeuDeTaquinTile(iNum);
                tile.Parent = this;
                tile.Location = new Point(iCol * sizeTile.Width,
                    iRow * sizeTile.Height);
                tile.Size = sizeTile;

                atile[iRow, iCol] = tile;
            }

            ptBlank = new Point(nCols - 1, nRows - 1);

            Randomize();
        }

        protected void Randomize()
        {
            rand = new Random();
            iTimerCountdown = 64 * nRows * nCols;

            var timer = new Timer();
            timer.Tick += TimerOnTick;
            timer.Interval = 1;
            timer.Enabled = true;
        }

        private void TimerOnTick(object obj, EventArgs ea)
        {
            var x = ptBlank.X;
            var y = ptBlank.Y;

            switch (rand.Next(4))
            {
                case 0:
                    x++;
                    break;
                case 1:
                    x--;
                    break;
                case 2:
                    y++;
                    break;
                case 3:
                    y--;
                    break;
            }

            if (x >= 0 && x < nCols && y >= 0 && y < nRows)
                MoveTile(x, y);

            if (--iTimerCountdown == 0)
            {
                ((Timer) obj).Stop();
                ((Timer) obj).Tick -= TimerOnTick;
            }
        }

        protected override void OnKeyDown(KeyEventArgs kea)
        {
            if (kea.KeyCode == Keys.Left && ptBlank.X < nCols - 1)
                MoveTile(ptBlank.X + 1, ptBlank.Y);

            else if (kea.KeyCode == Keys.Right && ptBlank.X > 0)
                MoveTile(ptBlank.X - 1, ptBlank.Y);

            else if (kea.KeyCode == Keys.Up && ptBlank.Y < nRows - 1)
                MoveTile(ptBlank.X, ptBlank.Y + 1);

            else if (kea.KeyCode == Keys.Down && ptBlank.Y > 0)
                MoveTile(ptBlank.X, ptBlank.Y - 1);

            kea.Handled = true;
        }

        protected override void OnMouseDown(MouseEventArgs mea)
        {
            var x = mea.X / sizeTile.Width;
            var y = mea.Y / sizeTile.Height;

            if (x == ptBlank.X)
            {
                if (y < ptBlank.Y)
                    for (var y2 = ptBlank.Y - 1; y2 >= y; y2--)
                        MoveTile(x, y2);

                else if (y > ptBlank.Y)
                    for (var y2 = ptBlank.Y + 1; y2 <= y; y2++)
                        MoveTile(x, y2);
            }
            else if (y == ptBlank.Y)
            {
                if (x < ptBlank.X)
                    for (var x2 = ptBlank.X - 1; x2 >= x; x2--)
                        MoveTile(x2, y);

                else if (x > ptBlank.X)
                    for (var x2 = ptBlank.X + 1; x2 <= x; x2++)
                        MoveTile(x2, y);
            }
        }

        private void MoveTile(int x, int y)
        {
            atile[y, x].Location = new Point(ptBlank.X * sizeTile.Width,
                ptBlank.Y * sizeTile.Height);

            atile[ptBlank.Y, ptBlank.X] = atile[y, x];
            atile[y, x] = null;
            ptBlank = new Point(x, y);
        }
    }
}