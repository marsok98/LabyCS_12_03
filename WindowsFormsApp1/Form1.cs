using LabyCS_12_03;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int seed = int.Parse(textBoxSeed.Text);
            int cap = int.Parse(textBoxCapacity.Text);
            ListOfItem list = new ListOfItem(seed, seed+69, cap*3/15);
            BackPack backPack = new BackPack(cap);
            backPack.robTheHouse(list);

            textBoxOutput.Text = backPack.getStringFromBackPack();
            textBox4.Text = list.getStringFromList();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
