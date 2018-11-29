using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinkApartments
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
            Thread t = new Thread(new ThreadStart(foo));
            t.Start();
            /*string empty = "";
            for(int i = 0; i < 100000; i++)
            {
                empty += i.ToString();
            }*/
            Thread.Sleep(10000);
            t.Abort();
            //Application.Run(new SplashScreen());
            Application.Run(new WelcomeForm());
        }

        static void foo()
        {
            Application.Run(new SplashScreen());
        }
    }
}
