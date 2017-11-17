namespace arescrypt
{
    partial class CryptoDisplay
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
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CryptoDisplay));
            this.consoleWindow = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // consoleWindow
            // 
            this.consoleWindow.BackColor = System.Drawing.SystemColors.WindowText;
            this.consoleWindow.ForeColor = System.Drawing.Color.Chartreuse;
            this.consoleWindow.Location = new System.Drawing.Point(-2, -5);
            this.consoleWindow.Margin = new System.Windows.Forms.Padding(0);
            this.consoleWindow.Multiline = true;
            this.consoleWindow.Name = "consoleWindow";
            this.consoleWindow.ReadOnly = true;
            this.consoleWindow.Size = new System.Drawing.Size(289, 274);
            this.consoleWindow.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(181, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 20);
            this.textBox1.TabIndex = 0;
            // 
            // CryptoDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.consoleWindow);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CryptoDisplay";
            this.Text = "Decrypting files...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox consoleWindow;
        private System.Windows.Forms.TextBox textBox1;
    }
}