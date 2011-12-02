using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form foo = new Form1();
            //Application.Run(foo);
            Thread newThread;
            //Process P1 = Process.Start(form());
            //P1.WaitForExit(5000);
            //System.Threading.Thread.Sleep(500);
            //foo.Close();
            //Application.Exit();
            //foo.Close();
            //Environment.Exit(0);

            newThread = new System.Threading.Thread(() => Application.Run(new Form1()));
            newThread.Start();
            System.Threading.Thread.Sleep(2000);
            newThread.Abort();
            newThread = new System.Threading.Thread(() => Application.Run(new Form3()));
            newThread.Start();
            System.Threading.Thread.Sleep(2000);
            newThread.Abort();
            
        }
        /*private static Form form()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            return new Form1();
            
        }*/
    }
}
