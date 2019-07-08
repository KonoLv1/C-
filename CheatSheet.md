# C#�`�[�g�V�[�g

## ���b�Z�[�W�{�b�N�X��\������

```
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

## �I�u�W�F�N�g�̐F��ύX����

```
button1.BackColor = Color.Blue;
button2.ForeColor = Color.Pink;
```

* **button1** �̔w�i�F��F�ɕύX����
* **button2** �̕����F���s���N�F�ɕύX����

## ���l�����͂��ꂽ���ǂ����̔�����s��

```
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

```
timer1.Start();
```

* �J�n�{�^���Ȃǂ���肻���Ƀ^�C�}�[���X�^�[�g�����閽�߂�ǉ�����
* **timer1** ���J�n����

## �^�C�}�[���~����

```
timer1.Stop();
```

* **timer1** ���~����