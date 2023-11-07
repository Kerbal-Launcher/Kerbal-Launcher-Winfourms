using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Windows.Forms;

namespace Kerbal_Launcher
{
    public partial class LauncherSplash : Form
    {
        public LauncherSplash()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(10000);
            var main = new KSP1Mode();
            main.Show();
            this.Close();
            timer1.Stop();
        }
    }
}
