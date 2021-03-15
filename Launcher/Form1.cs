using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Launcher
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            string filePath = @"menu.version";
            if(File.Exists(filePath))
            {
                List<string> lines = File.ReadAllLines(filePath).ToList();
                verLbl.Text = "Tims Pro Menu v" + lines[0];
            }
            else
            {
                btnInject.Cursor = Cursors.No;
                btnInject.Click -= new EventHandler(btnInject_Click);
                btnInject.Click += new EventHandler(btnInject_Click_NoVer);
            }
        }

        private void btnInject_Click_NoVer(object sender, EventArgs e)
        {
            MessageBox.Show("No Version of the Tim Menu found!", "Error");
        }

        private void btnInject_Click(object sender, EventArgs e)
        {
            Process.Start("ij.exe");
        }

        int mouseX = (1920/2)-100, mouseY = (1080/2)-90;
        bool isDown;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(isDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 20;
            }
            this.SetDesktopLocation(mouseX, mouseY);
        }

        private void btnFrInject_Click(object sender, EventArgs e)
        {
            verLbl.Visible = true;
            btnInject.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
        }
    }
}
