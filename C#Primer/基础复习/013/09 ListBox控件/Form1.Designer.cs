namespace _09_ListBox控件
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lstb = new System.Windows.Forms.ListBox();
            this.picb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picb)).BeginInit();
            this.SuspendLayout();
            // 
            // lstb
            // 
            this.lstb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lstb.FormattingEnabled = true;
            this.lstb.ItemHeight = 12;
            this.lstb.Location = new System.Drawing.Point(32, 29);
            this.lstb.Name = "lstb";
            this.lstb.Size = new System.Drawing.Size(147, 520);
            this.lstb.TabIndex = 0;
            this.lstb.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstb_MouseDoubleClick);
            // 
            // picb
            // 
            this.picb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picb.Location = new System.Drawing.Point(200, 29);
            this.picb.Name = "picb";
            this.picb.Size = new System.Drawing.Size(695, 520);
            this.picb.TabIndex = 1;
            this.picb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 576);
            this.Controls.Add(this.picb);
            this.Controls.Add(this.lstb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstb;
        private System.Windows.Forms.PictureBox picb;
    }
}

