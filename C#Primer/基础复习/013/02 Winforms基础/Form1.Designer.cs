namespace _02_Winforms基础
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
            this.btnLike = new System.Windows.Forms.Button();
            this.btnUnlike = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLike
            // 
            this.btnLike.Location = new System.Drawing.Point(43, 33);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(75, 23);
            this.btnLike.TabIndex = 0;
            this.btnLike.Text = "喜欢";
            this.btnLike.UseVisualStyleBackColor = true;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // btnUnlike
            // 
            this.btnUnlike.Location = new System.Drawing.Point(320, 138);
            this.btnUnlike.Name = "btnUnlike";
            this.btnUnlike.Size = new System.Drawing.Size(75, 23);
            this.btnUnlike.TabIndex = 1;
            this.btnUnlike.Text = "不喜欢";
            this.btnUnlike.UseVisualStyleBackColor = true;
            this.btnUnlike.Click += new System.EventHandler(this.btnUnlike_Click);
            this.btnUnlike.MouseEnter += new System.EventHandler(this.btnUnlike_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 469);
            this.Controls.Add(this.btnUnlike);
            this.Controls.Add(this.btnLike);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Button btnUnlike;
    }
}

