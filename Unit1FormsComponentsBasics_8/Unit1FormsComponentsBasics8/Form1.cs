using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit1FormsComponentsBasics8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        private void listClassroom_SelectedIndexChanged(object sender, EventArgs e)
        {

            name.Text = listClassroom.Text;

        }

        private void room1_Click(object sender, EventArgs e)
        {
            listClassroom.Items.Clear();
            string[] classRoom1 = { "Paco", "Ana", "Lurdes", "Carlota" };

            listClassroom.Items.AddRange(classRoom1);
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void room2_Click(object sender, EventArgs e)
        {
            listClassroom.Items.Clear();
            string[] classRoom2 = { "Maria", "Toni", "Mireya" };

            listClassroom.Items.AddRange(classRoom2);
        }

        private void clean_Click(object sender, EventArgs e)
        {
            listClassroom.Items.Clear();
            name.Text = null;
        }
    }
}
