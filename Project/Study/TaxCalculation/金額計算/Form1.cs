using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 金額計算
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kosuu;
            int tanka;
            int totalx;

            if (int.TryParse(textBox1.Text, out kosuu) == true)
            {
                kosuu = int.Parse(textBox1.Text);


                if (int.TryParse(textBox2.Text, out tanka) == true)
                {
                    tanka = int.Parse(textBox2.Text);
                    totalx = kosuu * tanka;
                    total.Text = totalx.ToString();
                    tax.Text = (totalx * 0.08).ToString();
                    max.Text = (totalx + totalx * 0.08).ToString();
                }
                else
                {
                    max.Text = "データを入力してください";
                }





            }
            else
            {
                max.Text = "データを入力してください";
            }

          

           


        }
    }
}
