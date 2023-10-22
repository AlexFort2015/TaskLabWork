using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Ваш выбор:"+"\r\n";
            textBox1.Text += groupBox1.Text + "\r\n";
            if (radioButton1.Checked) textBox1.Text+=radioButton1.Text+"\r\n";
            if (radioButton2.Checked) textBox1.Text += radioButton2.Text + "\r\n";
            if (radioButton3.Checked) textBox1.Text += radioButton3.Text + "\r\n";
            if (radioButton4.Checked) textBox1.Text += radioButton4.Text + "\r\n";
            if (radioButton5.Checked) textBox1.Text += radioButton5.Text + "\r\n";
            if (radioButton6.Checked) textBox1.Text += radioButton6.Text + "\r\n";
            if (radioButton7.Checked) textBox1.Text += radioButton7.Text + "\r\n";
            if (radioButton8.Checked) textBox1.Text += radioButton8.Text + "\r\n";
            if (radioButton9.Checked) textBox1.Text += radioButton9.Text + "\r\n";
            if (radioButton10.Checked) textBox1.Text += radioButton10.Text + "\r\n";
            if (radioButton11.Checked) textBox1.Text += radioButton11.Text + "\r\n";
            if (radioButton12.Checked) textBox1.Text += radioButton12.Text + "\r\n";
            if (radioButton13.Checked) textBox1.Text += radioButton13.Text + "\r\n";
            if (radioButton14.Checked) textBox1.Text += radioButton14.Text + "\r\n";
            if (radioButton15.Checked) textBox1.Text += radioButton15.Text + "\r\n";
            if (radioButton16.Checked) textBox1.Text += radioButton16.Text + "\r\n";

            textBox1.Text += groupBox2.Text + "\r\n";
            if (radioButton17.Checked) textBox1.Text += radioButton17.Text + "\r\n";
            if (radioButton18.Checked) textBox1.Text += radioButton18.Text + "\r\n";
            if (radioButton19.Checked) textBox1.Text += radioButton19.Text + "\r\n";
            if (radioButton20.Checked) textBox1.Text += radioButton20.Text + "\r\n";
            if (radioButton21.Checked) textBox1.Text += radioButton21.Text + "\r\n";
            if (radioButton22.Checked) textBox1.Text += radioButton22.Text + "\r\n";
            if (radioButton23.Checked) textBox1.Text += radioButton23.Text + "\r\n";
            if (radioButton24.Checked) textBox1.Text += radioButton24.Text + "\r\n";
            if (radioButton25.Checked) textBox1.Text += radioButton25.Text + "\r\n";
            if (radioButton26.Checked) textBox1.Text += radioButton26.Text + "\r\n";
            if (radioButton27.Checked) textBox1.Text += radioButton27.Text + "\r\n";
            if (radioButton28.Checked) textBox1.Text += radioButton28.Text + "\r\n";
            if (radioButton29.Checked) textBox1.Text += radioButton29.Text + "\r\n";
            if (radioButton30.Checked) textBox1.Text += radioButton30.Text + "\r\n";
            if (radioButton31.Checked) textBox1.Text += radioButton31.Text + "\r\n";
            if (radioButton32.Checked) textBox1.Text += radioButton32.Text + "\r\n";

            textBox1.Text += groupBox3.Text + "\r\n";
            if (checkBox1.Checked) textBox1.Text += checkBox1.Text + "\r\n";
            if (checkBox2.Checked) textBox1.Text += checkBox2.Text + "\r\n";
            if (checkBox3.Checked) textBox1.Text += checkBox3.Text + "\r\n";

        }
    }
}
