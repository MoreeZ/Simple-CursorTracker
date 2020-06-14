using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MouseKeyboardActivityMonitor;
using MouseKeyboardActivityMonitor.WinApi;
using System.Windows.Input;

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
            keyboardListener.KeyDown += AddSnapshotOnKeyPress;
        }


        private void MyMouseMoveExt(object sender, MouseEventExtArgs e)
        {
            lblx.Text = e.X.ToString();
            lbly.Text = e.Y.ToString();

            var c = GetColorAt(e.Location);
            colordisplay.BackColor = Color.FromArgb(c.R, c.G, c.B);
            redval.Text = c.R.ToString();
            greenval.Text = c.G.ToString();
            blueval.Text = c.B.ToString();

        }

        private void AddSnapshotOnKeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if(e.Control && e.KeyValue == 49)
            {
                snapshot1x.Text = lblx.Text;
                snapshot1y.Text = lbly.Text;
                snapshot1rgb.Text = $"({redval.Text}, {greenval.Text}, {blueval.Text})";
                snapshot1color.BackColor = Color.FromArgb(int.Parse(redval.Text), int.Parse(greenval.Text), int.Parse(blueval.Text));
            }
            if (e.Control && e.KeyValue == 50)
            {
                snapshot2x.Text = lblx.Text;
                snapshot2y.Text = lbly.Text;
                snapshot2rgb.Text = $"({redval.Text}, {greenval.Text}, {blueval.Text})";
                snapshot2color.BackColor = Color.FromArgb(int.Parse(redval.Text), int.Parse(greenval.Text), int.Parse(blueval.Text));
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
