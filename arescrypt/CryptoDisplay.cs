﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arescrypt
{
    public partial class CryptoDisplay : Form
    {
        public CryptoDisplay()
        {
            InitializeComponent();


        }

        public void addLineToConsole(string newLine)
        { this.consoleWindow.AppendText("\r" + newLine + "\n"); }
    }
}
