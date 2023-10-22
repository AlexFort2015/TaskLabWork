using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (radioButton3.Checked) pictureBox1.Visible = true;
        }


        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random val = new Random();
            button1.Left = val.Next(tabControl1.ClientSize.Width - button1.Right);
            button1.Top = val.Next(tabControl1.ClientSize.Height - button1.Top);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = radioButton3.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = radioButton2.Checked;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button2.Visible = radioButton1.Checked;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)

        {

            tabPage3.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            tabPage3.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            tabPage3.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                trackBar1.Value = colorDialog1.Color.R;
                trackBar2.Value = colorDialog1.Color.G;
                trackBar3.Value = colorDialog1.Color.B;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            new_color = (int)numericUpDown1.Value;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(new_color, new_color, new_color);
            panel1.Invalidate();
        }

        private int new_color;

    }
}