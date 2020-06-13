using System;
using System.Windows.Forms;
using MouseKeyboardActivityMonitor;
using MouseKeyboardActivityMonitor.WinApi;

namespace CursorTracker
{
    public partial class CursorTracker : Form
    {
        private MouseHookListener m_mouseListener;
        public CursorTracker()
        {
            InitializeComponent();
            //this.MouseUp += new MouseButtonEventHandler(OnMouseup); 
            // Note: for an application hook, use the AppHooker class instead
            m_mouseListener = new MouseHookListener(new GlobalHooker());

            // The listener is not enabled by default
            m_mouseListener.Enabled = true;

            m_mouseListener.MouseMoveExt += MyMouseMoveExt;
        }

        

        private void MyMouseMoveExt(object sender, MouseEventExtArgs e)
        {
            lblx.Text = e.X.ToString();
            lbly.Text = e.Y.ToString();
        }

    }
}
