using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit1FormsComponentsBasics9
{
    public partial class Form1 : Form
    {
        int numControlPar = 0;
        int numControlImpar = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void par_Click(object sender, EventArgs e)
        {

            numbers.Items.Add("Nº" + numControlPar);
            numControlPar = numControlPar + 2;

        }

        private void numbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected.Text = numbers.Text;
        }

        private void impar_Click(object sender, EventArgs e)
        {
            numbers.Items.Add("Nº" + numControlImpar);
            numControlImpar = numControlImpar + 2;
        }

        private void selected_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
