using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double SR1 = double.Parse(textBox1.Text);
                double SR2 = double.Parse(textBox2.Text);

                double TR = SR1 + SR2;
                MessageBox.Show("total resistance = " + TR.ToString("0.00") + "cm");

            }
            catch
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double PR1 = double.Parse(textBox3.Text);
                double PR2 = double.Parse(textBox4.Text);

                double TR = 1/PR1 + 1/PR2;
                MessageBox.Show("total resistance = " + TR.ToString("0.00") + "cm");

            }
            catch
            {
                MessageBox.Show("Invalid Input");
            }
        }
    }
}
