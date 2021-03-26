using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace Launcher
{
    public partial class mainWindow : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );

        public mainWindow()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 15, 15));
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
            btnFrInject.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnFrInject.Width, btnFrInject.Height, 15, 15));
            btnInject.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnInject.Width, btnInject.Height, 15, 15));
            mainPnl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, mainPnl.Width, mainPnl.Height, 15, 15));         
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
            MessageBox.Show("The Injection is a type of 'installing' the Mod Menu inside your Game, clicking on the 'Inject into GTA V' button loads a .dll file, thats saved in the Folder where this Launcher is located. \n\n" +
                "Also the Injection provides a risk of getting your account banned in GTA V. The coder of the Menu, 'Tim' does not have any liability for your account getting banned. \n Copyright ©2021 by Tim \n\n | Have Fun using the Menu |", "Injection Info");
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
