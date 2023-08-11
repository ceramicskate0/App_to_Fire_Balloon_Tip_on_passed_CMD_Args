using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallonAlert
{
    public partial class Form1 : Form
    {
        public Form1(string[] args)
        {
            try
            {
                InitializeComponent();
                string text = "";
                for (int x = 1; x < args.Length; ++x)
                {
                    text += " " + args[x];
                }
                this.notifyIcon1.BalloonTipText = text;
                this.notifyIcon1.BalloonTipTitle = "Alert";
                this.notifyIcon1.Visible = true;
                this.notifyIcon1.Text = text;
                this.notifyIcon1.ShowBalloonTip(60);
            }
            catch
            {
                Environment.Exit(1);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Process.Start("cmd","%windir%\\system32\\eventvwr.msc /s");
            Environment.Exit(0);
        }

        private void notifyIcon1_BalloonTipClicked_1(object sender, EventArgs e)
        {
            Process.Start("cmd", "%windir%\\system32\\eventvwr.msc /s");
            Environment.Exit(0);
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "%windir%\\system32\\eventvwr.msc /s");
            Environment.Exit(0);
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            Process.Start("%windir%\\system32\\eventvwr.msc /s");
            Environment.Exit(0);
        }
    }
}
