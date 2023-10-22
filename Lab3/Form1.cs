using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private Form2 polarChart = new Form2();
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Value = 34;
            numericUpDown2.Value = 78;
            numericUpDown3.Value = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (polarChart.IsDisposed) polarChart = new Form2();
            polarChart.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (polarChart.IsDisposed) polarChart = new Form2();
            polarChart.PolarFunction((double)numericUpDown1.Value,(double)numericUpDown2.Value,(double)numericUpDown3.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            polarChart.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (polarChart.IsDisposed) polarChart = new Form2();
            for (int i = 10; i > 0; i--)
            {
                polarChart.PolarFunction((double)numericUpDown1.Value*i, (double)numericUpDown2.Value*i, (double)numericUpDown3.Value*i);
            }
        }
    }
}
