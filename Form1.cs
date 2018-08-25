using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            InitializeComponent();
            string text="";
            for(int x=1;x<args.Length;++x)
            {
                text += args[x];
            }
            this.notifyIcon1.BalloonTipText = text;
            this.notifyIcon1.BalloonTipTitle = "SWELF Alert";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Text = text;
            this.notifyIcon1.ShowBalloonTip(60);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
