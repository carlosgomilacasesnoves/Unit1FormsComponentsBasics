using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit1FormsComponentesBasicos5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            string animals = "Choosen animals: ";
            string animal = "";

            if (mouse.Checked)
            {
               animal += "Mouse ";
            }

            if (cat.Checked)
            {
                animal += "Cat ";
            }

            if (dog.Checked)
            {
                animal +=  "Dog ";
            }

            result.Text = animals + animal;

        }

        private void result_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
