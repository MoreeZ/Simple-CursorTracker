using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MouseKeyboardActivityMonitor;
using MouseKeyboardActivityMonitor.WinApi;

namespace CursorTracker
{
    public partial class CursorTracker : Form
    {
        private readonly MouseHookListener m_mouseListener;
        private readonly KeyboardHookListener keyboardListener;


        public CursorTracker()
        {
            InitializeComponent();

            //this.MouseUp += new MouseButtonEventHandler(OnMouseup); 
            // Note: for an application hook, use the AppHooker class instead
            m_mouseListener = new MouseHookListener(new GlobalHooker())
            {
                // The listener is not enabled by default
                Enabled = true
            };
            m_mouseListener.MouseMoveExt += MyMouseMoveExt;

            keyboardListener = new KeyboardHookListener(new GlobalHooker())
            {
                Enabled = true
            };
            keyboardListener.KeyPress += DetectMinusAndPause;
        }



        private void MyMouseMoveExt(object sender, MouseEventExtArgs e)
        {
            lblx.Text = e.X.ToString();
            lbly.Text = e.Y.ToString();

            //Point cursor = new Point();
            var c = GetColorAt(e.Location);
            colordisplay.BackColor = Color.FromArgb(c.R, c.G, c.B);
            redval.Text = c.R.ToString();
            greenval.Text = c.G.ToString();
            blueval.Text = c.B.ToString();
            //Console.WriteLine($"RED: {c.R}, GREEN: {c.G}, BLUE: {c.B}");

        }

        private void DetectMinusAndPause(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                if (m_mouseListener.Enabled)
                {
                    m_mouseListener.Enabled = false;
                }else
                {
                    m_mouseListener.Enabled = true;
                }
            }
        }

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        readonly Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);

        public Color GetColorAt(Point location)
        {
            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }

            return screenPixel.GetPixel(0, 0);
        }
    }
}
