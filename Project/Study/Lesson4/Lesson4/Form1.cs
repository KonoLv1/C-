using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fm = new Form();
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
        }

        private void Sample2_Click(object sender, EventArgs e)
        {
            Form fm = new Form();
            fm.Text = "サンプル";
            fm.Width = 300; fm.Height = 200;

            PictureBox pb = new PictureBox();
            pb.Image = Image.FromFile("car.bmp");
            pb.Left = 100;

            Label lb = new Label();
            lb.Top = pb.Bottom;
            lb.Text = "車です。";

            if (pb.Left >= 150)
            {
                lb.Text = "車は東にあります。";
            }
            else if (pb.Left <= 20)
            {
                lb.Text = "車は西にあります。";
            }
            else
            {
                lb.Text = "車は中部にあります。";
            }

            pb.Parent = fm;
            lb.Parent = fm;
            
            fm.ShowDialog();
        }

        private void Sample6_Click(object sender, EventArgs e)
        {
            Form fm = new Form();
            fm.Text = "サンプル";

            PictureBox[] pb = new PictureBox[5];

            for (int i = 0; i < pb.Length; i++)
            {
                pb[i] = new PictureBox();
                pb[i].Image = Image.FromFile("car.bmp");
                pb[i].Top = i * pb[i].Height;
                pb[i].Parent = fm;
            }
            fm.ShowDialog();
        }
    }
}
