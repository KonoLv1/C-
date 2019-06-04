namespace Lesson4
{
    partial class Form1
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
            this.Sample2 = new System.Windows.Forms.Button();
            this.Sample5 = new System.Windows.Forms.Button();
            this.Sample6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sample2
            // 
            this.Sample2.Location = new System.Drawing.Point(45, 10);
            this.Sample2.Name = "Sample2";
            this.Sample2.Size = new System.Drawing.Size(200, 50);
            this.Sample2.TabIndex = 0;
            this.Sample2.Text = "Sample2";
            this.Sample2.UseVisualStyleBackColor = true;
            this.Sample2.Click += new System.EventHandler(this.Sample2_Click);
            // 
            // Sample5
            // 
            this.Sample5.Location = new System.Drawing.Point(45, 105);
            this.Sample5.Name = "Sample5";
            this.Sample5.Size = new System.Drawing.Size(200, 50);
            this.Sample5.TabIndex = 1;
            this.Sample5.Text = "Sample5";
            this.Sample5.UseVisualStyleBackColor = true;
            this.Sample5.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sample6
            // 
            this.Sample6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sample6.Location = new System.Drawing.Point(45, 200);
            this.Sample6.Name = "Sample6";
            this.Sample6.Size = new System.Drawing.Size(200, 50);
            this.Sample6.TabIndex = 2;
            this.Sample6.Text = "Sample6";
            this.Sample6.UseVisualStyleBackColor = false;
            this.Sample6.Click += new System.EventHandler(this.Sample6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.Sample6);
            this.Controls.Add(this.Sample5);
            this.Controls.Add(this.Sample2);
            this.Name = "Form1";
            this.Text = "Lesson4";
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.Button Sample2;
        private System.Windows.Forms.Button Sample5;
        private System.Windows.Forms.Button Sample6;
    }
}

