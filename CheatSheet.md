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