using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit1FormsComponentesBasicos_input
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d, f, resultado;
            d = double.Parse(num1.Text);
            f = double.Parse(num2.Text);
        
            resultado = d + f;

            result.Text = resultado.ToString();
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void num1_TextChanged(object sender, EventArgs e)
        {

        }

        private void num2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clean_Click(object sender, EventArgs e)
        {
            result.Text = "";
            num1.Text = "";
            num2.Text = "";
        }
    }
}
