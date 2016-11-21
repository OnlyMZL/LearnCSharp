namespace _10_剪刀石头布
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblJudge = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCpu = new System.Windows.Forms.Label();
            this.btnStone = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnBu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "玩家出：";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(128, 48);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(11, 12);
            this.lblPlayer.TabIndex = 1;
            this.lblPlayer.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "裁判";
            // 
            // lblJudge
            // 
            this.lblJudge.AutoSize = true;
            this.lblJudge.Location = new System.Drawing.Point(217, 108);
            this.lblJudge.Name = "lblJudge";
            this.lblJudge.Size = new System.Drawing.Size(11, 12);
            this.lblJudge.TabIndex = 3;
            this.lblJudge.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "电脑出：";
            // 
            // lblCpu
            // 
            this.lblCpu.AutoSize = true;
            this.lblCpu.Location = new System.Drawing.Point(333, 48);
            this.lblCpu.Name = "lblCpu";
            this.lblCpu.Size = new System.Drawing.Size(11, 12);
            this.lblCpu.TabIndex = 5;
            this.lblCpu.Text = " ";
            // 
            // btnStone
            // 
            this.btnStone.Location = new System.Drawing.Point(58, 163);
            this.btnStone.Name = "btnStone";
            this.btnStone.Size = new System.Drawing.Size(75, 23);
            this.btnStone.TabIndex = 6;
            this.btnStone.Text = "石头";
            this.btnStone.UseVisualStyleBackColor = true;
            this.btnStone.Click += new System.EventHandler(this.btnStone_Click);
            // 
            // btnCut
            // 
            this.btnCut.Location = new System.Drawing.Point(163, 163);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(75, 23);
            this.btnCut.TabIndex = 7;
            this.btnCut.Text = "剪刀";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnBu
            // 
            this.btnBu.Location = new System.Drawing.Point(268, 163);
            this.btnBu.Name = "btnBu";
            this.btnBu.Size = new System.Drawing.Size(75, 23);
            this.btnBu.TabIndex = 8;
            this.btnBu.Text = "布";
            this.btnBu.UseVisualStyleBackColor = true;
            this.btnBu.Click += new System.EventHandler(this.btnBu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 237);
            this.Controls.Add(this.btnBu);
            this.Controls.Add(this.btnCut);
            this.Controls.Add(this.btnStone);
            this.Controls.Add(this.lblCpu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblJudge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblJudge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCpu;
        private System.Windows.Forms.Button btnStone;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnBu;
    }
}

