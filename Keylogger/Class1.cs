using MouseKeyboardActivityMonitor;
using MouseKeyboardActivityMonitor.WinApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keylogger
{
    class Class1
    {
        private KeyboardHookListener keyboardListener;

        public void testFn()
        {
            keyboardListener = new KeyboardHookListener(new GlobalHooker())
            {
                Enabled = true
            };
            keyboardListener.KeyPress += DetectMinusAndPause;
        }

        private void DetectMinusAndPause(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar);
            Console.WriteLine(e.KeyChar.ToString());
        }
    }
}
