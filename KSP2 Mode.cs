using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kerbal_Launcher
{
    public partial class KSP2_Mode : Form
    {
        public KSP2_Mode()
        {
            InitializeComponent();
            string curDir = Directory.GetCurrentDirectory();
            this.webBrowser1.Url = new Uri(String.Format("file:///{0}/KSP2changelog.html", curDir));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", "steam://rungameid/954850");
        }
    }
}
