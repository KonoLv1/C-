# C#チートシート

## メッセージボックスを表示する

```C#
String mes;
mes = textBox1.Text;
MessageBox.Show(mes,"メッセージ",MessageBoxButtons.OK);
```
* 文字型変数 **mes** に **textBox1**に入力された文字を表示する
* タイトルはメッセージでOKボタンのみ表示

## ラベルにテキストボックスの文字を表示する

```C#
label1.Text = textBox1.Text;
```

* **label1** に **texBox1** に入力された文字を表示する

## ラベルに変数を表示する

```C#
label1.Text = x.ToString(); 
```

* **label1** に **x** の中身を表示する

## オブジェクトの色を変更する

```C#
button1.BackColor = Color.Blue;
button2.ForeColor = Color.Pink;
```

* **button1** の背景色を青色に変更する
* **button2** の文字色をピンク色に変更する

## 数値が入力されたかどうかの判定を行う

```C#
int left;
if(int.TryParse(textBox1.Text,out left)== true)
{
   left = int.Parse(textBox1.Text);
}
else
{
   // 数値以外が入力された場合の処理を記述
}
```

* **left** に **textBox1** に入力された文字が代入可能かどうかの判定を行う
* **left** に **textBox1** に入力された数値を **int型** で代入する

## タイマーを開始する

```C#
timer1.Start();
```

* 開始ボタンなどを作りそこにタイマーをスタートさせる命令を追加する
* **timer1** を開始する

## タイマーを停止する

```C#
timer1.Stop();
```

* **timer1** を停止する

# 画像を右に動かすサンプルプログラム

```C#
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moveCar.cs
{
    public partial class Form1 : Form
    {
        int flg = 0;    //走行状態判定用のフラグ
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (flg == 0)
            {
                timer1.Start(); 
                flg = 1;
                btn_start.Text = "止まる"; //ボタンのメッセージを変更
            }
            else
            {
                timer1.Stop();
                flg = 0;
                btn_start.Text = "走る"; //ボタンのメッセージを変更
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbx_car.Left = pbx_car.Left + 1;    //画像を右へ移動
        }
    }
}

// btn_start ... ボタン
// pbx_car   ... 画像
// timer1    ... タイマー
```

## 入力された２つの数字の間の特定の値を表示するサンプルプログラム

```C#
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 合計計算3
{
    public partial class Form1 : Form
    {
        int left, right;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Input_check();
        }

        void Input_check()
        {
            if (int.TryParse(textBox1.Text, out left) == true)
            {
                left = int.Parse(textBox1.Text);
                if (int.TryParse(textBox2.Text, out right) == true)
                {
                    right = int.Parse(textBox2.Text);
                    Calculation();
                }
                else
                {
                    MessageBox.Show("エラーです", "メッセージ", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("エラーです", "メッセージ", MessageBoxButtons.OK);
            }
        }

        void Calculation()
        {
            int i,sum,sum2,sum3,sum4;
            sum = sum2 = sum3 = sum4 = 0;
            i = left;
            while (i <= right)
            {
                sum = sum + i;
                if (i % 2 == 0)
                {
                    sum2 = sum2 + i;
                }
                else
                {
                    sum3 = sum3 + i;
                }
                if (i % 3 == 0)
                {
                    sum4 = sum4 + i;
                }
                i++;
            }
            label2.Text = "総計は、" + sum.ToString() + "です。" ;
            label3.Text = "偶数計は、" + sum2.ToString() + "です。";
            label4.Text = "奇数計は、" + sum3.ToString() + "です。";
            label5.Text = "3の倍数計は、" + sum4.ToString() + "です。";
        }
    }
}
```

## ルーレットサンプルプログラム

```C#
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
```



