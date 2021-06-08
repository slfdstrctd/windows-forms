using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class Picture
    {
        public Bitmap _btm;
        public Rectangle _rect;

        public Picture(Bitmap btm, Rectangle rect)
        {
            _btm = btm;
            _rect = rect;
        }
    }

    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}