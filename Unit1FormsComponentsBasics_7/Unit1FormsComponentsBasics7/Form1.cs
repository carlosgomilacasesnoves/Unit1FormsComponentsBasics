using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit1FormsComponentsBasics7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void comboColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            showsel.Text = "The choosen colour is: " +  comboColors.Text;
        }

        private void showsel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
