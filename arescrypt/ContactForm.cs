using System;
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
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();

            this.webBrowser1.Navigate("http://localhost/arescrypt.php?contact&uniqueId=asdfasdf");
        }
    }
}
