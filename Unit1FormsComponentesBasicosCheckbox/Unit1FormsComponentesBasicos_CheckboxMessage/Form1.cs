using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit1FormsComponentesBasicos_CheckboxMessage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                System.Windows.Forms.MessageBox.Show("“Checkbox Checked");

                //checkBox1.Text = "Checked";
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Checkbox Unchecked");
                //  checkBox1.Text = "Unchecked";
            }
        }
    }
}
