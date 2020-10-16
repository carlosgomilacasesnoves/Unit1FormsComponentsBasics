using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit1FormsComponentsBasics10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void scroll_Scroll(object sender, ScrollEventArgs e)
        {





            percent.Text = "" + scroll.Value;
        }

        private void percent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
