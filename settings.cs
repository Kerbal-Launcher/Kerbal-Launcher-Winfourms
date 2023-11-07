using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Kerbal_Launcher
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
            custominstall.Text = File.ReadAllText(".\\cfg\\custominstall.txt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(".\\cfg\\"))
            {
                Directory.CreateDirectory(".\\cfg\\");
            }
            if (!File.Exists(".\\cfg\\custominstall.txt"))
            {
                File.Create(".\\cfg\\custominstall.txt");
            }
            if (!File.Exists(".\\cfg\\ckaninstall.txt"))
            {
                File.Create(".\\cfg\\ckaninstall.txt");
            }
            File.WriteAllText(".\\cfg\\custominstall.txt", custominstall.Text);
            File.WriteAllText(".\\cfg\\ckaninstall.txt", custominstall.Text);

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Ctrl+C + Ctrl+V'd from https://stackoverflow.com/questions/13900441/c-sharp-read-txt-file-into-textbox lmao
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    custominstall.Text = File.ReadAllText(openFileDialog1.FileName);

                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            custominstall.Text = File.ReadAllText(openFileDialog1.FileName);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}

