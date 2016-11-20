using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Winforms基础
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolStatic._mainForm = this;
        }

        private void btnUnlike_MouseEnter(object sender, EventArgs e)
        {
            Random r = new Random();
            int x = this.ClientSize.Width - btnUnlike.Width;
            int y = this.ClientSize.Height - btnUnlike.Height;
            btnUnlike.Location = new Point(r.Next(0, x), r.Next(0, y));
        }

        private void btnUnlike_Click(object sender, EventArgs e)
        {
            MessageBox.Show("还是被你个屌丝点到了", "Warnning");
            ToolStatic._mainForm.Close();
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            MessageBox.Show("哈哈，我也喜欢你", "Warnning");
            ToolStatic._mainForm.Close();
        }
    }
}
