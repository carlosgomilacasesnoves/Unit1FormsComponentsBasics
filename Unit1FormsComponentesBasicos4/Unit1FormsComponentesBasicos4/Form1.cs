using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit1FormsComponentesBasicos4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  

        private void Sum_Click(object sender, EventArgs e)
        {
            operat.Text = "+";
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {

        }

        private void num2_TextChanged(object sender, EventArgs e)
        {

        }

        private void operat_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void Substract_Click(object sender, EventArgs e)
        {
            operat.Text = "-";
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double d, f, resultado;
            d = double.Parse(num1.Text);
            f = double.Parse(num2.Text);

            if (operat.Text == "-")
            {
                resultado = d - f;
            }
            else
            {
                resultado = d + f;
            }



            

            result.Text = resultado.ToString();
        }

        private void Rest_Click(object sender, EventArgs e)
        {
            result.Text = null;
            num1.Text = null;
            num2.Text = null;
            operat.Text = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
