namespace GmailCheck
{
    partial class GmailCheck
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.InfoLabel1 = new System.Windows.Forms.Label();
            this.InfoLabel2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.butStart = new System.Windows.Forms.Button();
            this.textNewMail = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // InfoLabel1
            // 
            this.InfoLabel1.AutoSize = true;
            this.InfoLabel1.Location = new System.Drawing.Point(13, 13);
            this.InfoLabel1.Name = "InfoLabel1";
            this.InfoLabel1.Size = new System.Drawing.Size(85, 15);
            this.InfoLabel1.TabIndex = 0;
            this.InfoLabel1.Text = "メールアドレス";
            // 
            // InfoLabel2
            // 
            this.InfoLabel2.AutoSize = true;
            this.InfoLabel2.Location = new System.Drawing.Point(16, 43);
            this.InfoLabel2.Name = "InfoLabel2";
            this.InfoLabel2.Size = new System.Drawing.Size(64, 15);
            this.InfoLabel2.TabIndex = 1;
            this.InfoLabel2.Text = "パスワード";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(104, 10);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(260, 22);
            this.txtAddress.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(104, 38);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(260, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(19, 77);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(345, 23);
            this.butStart.TabIndex = 4;
            this.butStart.Text = "チェック開始";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // textNewMail
            // 
            this.textNewMail.Location = new System.Drawing.Point(19, 116);
            this.textNewMail.Multiline = true;
            this.textNewMail.Name = "textNewMail";
            this.textNewMail.Size = new System.Drawing.Size(451, 175);
            this.textNewMail.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // GmailCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 303);
            this.Controls.Add(this.textNewMail);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.InfoLabel2);
            this.Controls.Add(this.InfoLabel1);
            this.Name = "GmailCheck";
            this.Text = "GmailCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label InfoLabel1;
        private System.Windows.Forms.Label InfoLabel2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.TextBox textNewMail;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

