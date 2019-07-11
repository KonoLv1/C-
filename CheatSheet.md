# C#�`�[�g�V�[�g

## ���b�Z�[�W�{�b�N�X��\������

```C#
String mes;
mes = textBox1.Text;
MessageBox.Show(mes,"���b�Z�[�W",MessageBoxButtons.OK);
```
* �����^�ϐ� **mes** �� **textBox1**�ɓ��͂��ꂽ������\������
* �^�C�g���̓��b�Z�[�W��OK�{�^���̂ݕ\��

## ���x���Ƀe�L�X�g�{�b�N�X�̕�����\������

```C#
label1.Text = textBox1.Text;
```

* **label1** �� **texBox1** �ɓ��͂��ꂽ������\������

## ���x���ɕϐ���\������

```C#
label1.Text = x.ToString(); 
```

* **label1** �� **x** �̒��g��\������

## �I�u�W�F�N�g�̐F��ύX����

```C#
button1.BackColor = Color.Blue;
button2.ForeColor = Color.Pink;
```

* **button1** �̔w�i�F��F�ɕύX����
* **button2** �̕����F���s���N�F�ɕύX����

## ���l�����͂��ꂽ���ǂ����̔�����s��

```C#
int left;
if(int.TryParse(textBox1.Text,out left)== true)
{
   left = int.Parse(textBox1.Text);
}
else
{
   // ���l�ȊO�����͂��ꂽ�ꍇ�̏������L�q
}
```

* **left** �� **textBox1** �ɓ��͂��ꂽ����������\���ǂ����̔�����s��
* **left** �� **textBox1** �ɓ��͂��ꂽ���l�� **int�^** �ő������

## �^�C�}�[���J�n����

```C#
timer1.Start();
```

* �J�n�{�^���Ȃǂ���肻���Ƀ^�C�}�[���X�^�[�g�����閽�߂�ǉ�����
* **timer1** ���J�n����

## �^�C�}�[���~����

```C#
timer1.Stop();
```

* **timer1** ���~����

# �摜���E�ɓ������T���v���v���O����

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
        int flg = 0;    //���s��Ԕ���p�̃t���O
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
                btn_start.Text = "�~�܂�"; //�{�^���̃��b�Z�[�W��ύX
            }
            else
            {
                timer1.Stop();
                flg = 0;
                btn_start.Text = "����"; //�{�^���̃��b�Z�[�W��ύX
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbx_car.Left = pbx_car.Left + 1;    //�摜���E�ֈړ�
        }
    }
}

// btn_start ... �{�^��
// pbx_car   ... �摜
// timer1    ... �^�C�}�[
```

## ���͂��ꂽ�Q�̐����̊Ԃ̓���̒l��\������T���v���v���O����

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

namespace ���v�v�Z3
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
                    MessageBox.Show("�G���[�ł�", "���b�Z�[�W", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("�G���[�ł�", "���b�Z�[�W", MessageBoxButtons.OK);
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
            label2.Text = "���v�́A" + sum.ToString() + "�ł��B" ;
            label3.Text = "�����v�́A" + sum2.ToString() + "�ł��B";
            label4.Text = "��v�́A" + sum3.ToString() + "�ł��B";
            label5.Text = "3�̔{���v�́A" + sum4.ToString() + "�ł��B";
        }
    }
}
```

## ���[���b�g�T���v���v���O����

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

namespace ���[���b�g
{
    public partial class Form1 : Form
    {
        int no1,no2,no3; //���[���b�g�̐���
        int count_max = 9; // ���[���b�g�̍ő�l
        int no1_mode, no2_mode, no3_mode; //���[���b�g����m�F

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
                    label4.Text = "���߂łƂ�";
                }
                else
                {
                    label4.Text = "�c�O";
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



