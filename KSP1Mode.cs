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
//using DiscordRPC;
//using DiscordRPC.Logging;

namespace Kerbal_Launcher
{
    public partial class KSP1Mode : Form
    {
        //public DiscordRpcClient client;
        public KSP1Mode()
        {
            InitializeComponent();
            //client = new DiscordRpcClient("1171455711524425810");
            //InitializeRPC();
            string curDir = Directory.GetCurrentDirectory();
            this.webBrowser1.Url = new Uri(String.Format("file:///{0}/changelog.html", curDir));
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var about = new AboutBox();
            about.Show();
        }

        private void modsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(".\\cfg\\ckaninstall.txt"))
            {
                MessageBox.Show("Can't Find CKAN install", "Kerbal Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(File.ReadAllText(@".\cfg\ckaninstall.txt"));
            }
            //var mods = new ModLoader();
            //mods.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settings = new settings();
            settings.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're about to run a custom install for all we know it could be a virus!\nContinue With Caution", "Kerbal Launcher", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if (!File.Exists(".\\cfg\\custominstall.txt"))
            {

            }
            else
            {
                Process.Start(File.ReadAllText(@".\cfg\custominstall.txt"));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", "steam://rungameid/220200");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            this.ShowInTaskbar = false;
            var ksp2mode = new KSP2_Mode();
            ksp2mode.Show();
        }

        /*public void InitializeRPC()
        {
         client = new DiscordRpcClient("1171455711524425810");
         client.Initialize();
        }*/

        public void ksp1modeshow()
        {
            this.Opacity = 100;
            this.ShowInTaskbar = true;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}