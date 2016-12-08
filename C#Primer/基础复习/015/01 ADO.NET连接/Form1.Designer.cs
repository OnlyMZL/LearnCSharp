namespace _01_ADO.NET连接
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
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnId = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(56, 44);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(100, 21);
            this.txtInsert.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(69, 85);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "插入数据";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(198, 43);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 21);
            this.txtId.TabIndex = 2;
            // 
            // btnId
            // 
            this.btnId.Location = new System.Drawing.Point(183, 84);
            this.btnId.Name = "btnId";
            this.btnId.Size = new System.Drawing.Size(130, 23);
            this.btnId.TabIndex = 3;
            this.btnId.Text = "通过编号查询部门";
            this.btnId.UseVisualStyleBackColor = true;
            this.btnId.Click += new System.EventHandler(this.btnId_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 401);
            this.Controls.Add(this.btnId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtInsert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnId;
    }
}

