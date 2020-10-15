using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit1FormsComponentesBasicos6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            String color = "";

            if (red.Checked)
            {
                color = "Red ";
            }

            if (blue.Checked)
            {
                color = "Blue ";
            }

            if (white.Checked)
            {
                color = "White ";
            }

            result.Text = "Choosen Colour: " + color;
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
