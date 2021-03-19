using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabyCS_12_03;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int seed = int.Parse(textBoxSeed.Text);
            RandomNumberGenerator rng = new RandomNumberGenerator(seed);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
