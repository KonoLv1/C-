using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ルーレット
{
    public partial class Form1 : Form
    {
        int no1,no2,no3; //ルーレットの数字
        int count_max = 9; // ルーレットの最大値
        int no1_mode, no2_mode, no3_mode; //ルーレット動作確認

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            no1_mode = 1;
            All_check();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            no2_mode = 1;
            All_check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            no3_mode = 1;
            All_check();
        }

        void All_check()
        {
            if (no1_mode == 1 && no2_mode == 1 && no3_mode == 1)
            {
                button4.Enabled = true;
                if (no1 == no2 && no2 == no3)
                {
                    label4.Text = "おめでとう";
                }
                else
                {
                    label4.Text = "残念";
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            no1++;
            if (no1 > count_max)
            {
                no1 = 0;
            }
            label1.Text = no1.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            no2++;
            if (no2 > count_max)
            {
                no2 = 0;
            }
            label2.Text = no2.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            no3++;
            if (no3 > count_max)
            {
                no3 = 0;
            }
            label3.Text = no3.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Timer_Start();
            button4.Enabled = false;
            no1_mode = no2_mode = no3_mode = 0;
            label4.Text = "";
        }

        void Timer_Start()
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }
    }
}
