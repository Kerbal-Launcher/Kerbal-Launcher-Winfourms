using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kerbal_Launcher
{
    public partial class tinybswindow : Form
    {
        public tinybswindow()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var splash = new LauncherSplash();
            splash.Show();
            timer1.Stop();
        }
    }
}
