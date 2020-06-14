using MouseKeyboardActivityMonitor;
using MouseKeyboardActivityMonitor.WinApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keylogger
{
    class Program
    {
        static void Main()
        {
            Class1 test = new Class1();
            test.testFn();

            Console.WriteLine("Press Any Key to close the App...");
            Console.ReadKey();
        }
    }
}