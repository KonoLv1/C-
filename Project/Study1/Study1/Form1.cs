using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study1
{
    public partial class Form1 : Form
    {
 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //button1をクリックしたときの処理
        {
            String mes;
            mes = textBox1.Text;
            MessageBox.Show(mes,"メッセージ",MessageBoxButtons.OK);

            /*
            Form fm = new Form();   //フォーム"fm"の生成
            fm.Text = "メッセージ"; //フォーム"fm"のタイトル
            Label lb = new Label(); //ラベル"lb"の生成
            lb.Width = fm.Width; lb.Height = fm.Height;
            lb.Text = "あいうえお";
            lb.Parent = fm; //fmに出力
            fm.ShowDialog();    //フォーム"fm"を出力
            */
            /*
            fm.Text = "サンプル";
            fm.Width = 300; fm.Height = 150;

            Label lb = new Label();
            lb.Width = fm.Width; lb.Height = fm.Height;

            for (int i = 0; i < 5; i++)
            {
                lb.Text += i + "号車を表示します。\n";
            }

           lb.Parent = fm;

            fm.ShowDialog();
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Blue;
            button3.ForeColor = Color.Pink;
        }
    }
}
