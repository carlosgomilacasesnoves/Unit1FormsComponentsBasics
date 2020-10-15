using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit1FormsComponentesBasicos4b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void operat_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected.Text = operat.Text;
        }

        private void calculate_Click(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rest_Click(object sender, EventArgs e)
        {
            result.Text = null;
            num1.Text = null;
            num2.Text = null;
            selected.Text = null;
            operat.Text = null;

        }

        private void selected_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
