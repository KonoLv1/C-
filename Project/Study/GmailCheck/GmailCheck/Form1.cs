using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GmailCheck
{
    public partial class GmailCheck : Form
    {
        public GmailCheck()
        {
            InitializeComponent();
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        // 現在のメールの数を「count」に記憶させる
        private int count = -1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //  NuGetで追加したOpenPop.NETのインスタンスを生成する
            OpenPop.Pop3.Pop3Client client = new OpenPop.Pop3.Pop3Client();

            //  Gmailに接続する
            client.Connect("pop.gmail.com", 995, true);
            
            //  IDとパスワードのチェック
            client.Authenticate(txtAddress.Text, txtPassword.Text);

            //
            int messageCount = client.GetMessageCount();

            //　
            if (count == -1)
            {
                count = messageCount;
            }

            //  
            for (int i = messageCount; i > count; i--)
            {
                textNewMail.Text += client.GetMessage(i).Headers.Subject + Environment.NewLine;

                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipTitle = "メールが届いたじぇ";
                notifyIcon1.BalloonTipText = client.GetMessage(i).Headers.Subject;
                notifyIcon1.ShowBalloonTip(3000);
            }
            count = messageCount;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
