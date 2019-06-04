using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3
{
    public partial class Lesson3 : Form
    {
        public Lesson3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // ボタンを押したときの処理
        private void button1_Click(object sender, EventArgs e)
        {


            //
            // 新しくForm型のfmという変数を使ってインスタンス化する
            Form fm = new Form();
            // フォームの見出しをサンプル１に設定する
            fm.Text = "サンプル1";

            // インスタンスpbを生成する
            PictureBox pb = new PictureBox();
            pb.Image = Image.FromFile("car.bmp");
            pb.Top = 100;

            // ピクチャーボックスpbをfmに設定する
            pb.Parent = fm;
            

           fm.ShowDialog();
          
        }
    }
}
