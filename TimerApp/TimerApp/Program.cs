using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//Name: Cinnamaroll Timer App
//Author: Gwen Kalasky
//Synopsis: This application can be used as a stopwatch. Click start to begin the timer and stop to pause.
//Date: 9/2/20
namespace TimerApp
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
            Application.Run(new Form1());
        }
    }
}
