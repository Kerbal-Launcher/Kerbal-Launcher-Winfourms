using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Kerbal_Launcher
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
            //if (!File.Exists(".\\cfg\\newlaunch"))
            //{
                //Application.Run(new tinybswindow());
            //} else
            //{
                Application.Run(new KSP1Mode());
            //}
        }
    }
}
