# C#チートシート

## メッセージボックスを表示する

```
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

## オブジェクトの色を変更する

```
button1.BackColor = Color.Blue;
button2.ForeColor = Color.Pink;
```

* **button1** の背景色を青色に変更する
* **button2** の文字色をピンク色に変更する

## 数値が入力されたかどうかの判定を行う

```
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

```
timer1.Start();
```

* 開始ボタンなどを作りそこにタイマーをスタートさせる命令を追加する
* **timer1** を開始する

## タイマーを停止する

```
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
