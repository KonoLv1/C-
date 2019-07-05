using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String mes;
            int left;
            int right;
            int safemode;
            safemode = 0;
            if(int.TryParse(textBox1.Text,out left)== true)
            {
                left = int.Parse(textBox1.Text);
            }
            else
            {
                safemode = 1;
            }
            if (int.TryParse(textBox2.Text, out right) == true)
            {
                right = int.Parse(textBox2.Text);
            }
            else
            {
                safemode = 1;
            }
            if (safemode == 0)
            {
                mes = textBox1.Text + "+" + textBox2.Text + "=" + (left + right);
                MessageBox.Show(mes, "答えは", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("数値が入力されていません", "警告", MessageBoxButtons.OK);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String mes;
            int left;
            int right;
            int safemode;
            safemode = 0;
            if (int.TryParse(textBox1.Text, out left) == true)
            {
                left = int.Parse(textBox1.Text);
            }
            else
            {
                safemode = 1;
            }
            if (int.TryParse(textBox2.Text, out right) == true)
            {
                right = int.Parse(textBox2.Text);
            }
            else
            {
                safemode = 1;
            }
            if (safemode == 0)
            {
                mes = textBox1.Text + "-" + textBox2.Text + "=" + (left - right);
                MessageBox.Show(mes, "答えは", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("数値が入力されていません", "警告", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String mes;
            int left;
            int right;
            int safemode;
            safemode = 0;
            if (int.TryParse(textBox1.Text, out left) == true)
            {
                left = int.Parse(textBox1.Text);
            }
            else
            {
                safemode = 1;
            }
            if (int.TryParse(textBox2.Text, out right) == true)
            {
                right = int.Parse(textBox2.Text);
            }
            else
            {
                safemode = 1;
            }
            if (safemode == 0)
            {
                mes = textBox1.Text + "×" + textBox2.Text + "=" + (left * right);
                MessageBox.Show(mes, "答えは", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("数値が入力されていません", "警告", MessageBoxButtons.OK);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String mes;
            int left;
            int right;
            int safemode;
            safemode = 0;
            if (int.TryParse(textBox1.Text, out left) == true)
            {
                left = int.Parse(textBox1.Text);
            }
            else
            {
                safemode = 1;
            }
            if (int.TryParse(textBox2.Text, out right) == true)
            {
                right = int.Parse(textBox2.Text);
            }
            else
            {
                safemode = 1;
            }
            if (safemode == 0)
            {
                mes = textBox1.Text + "÷" + textBox2.Text + "=" + (left / right);
                MessageBox.Show(mes, "答えは", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("数値が入力されていません", "警告", MessageBoxButtons.OK);
            }
        }
    }
}
