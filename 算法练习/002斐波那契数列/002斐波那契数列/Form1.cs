using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002斐波那契数列
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Focus();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string input = textBox1.Text;
                Tool.InputNum=Convert.ToInt32(input);  //参数传递
                if(Tool.InputNum>46)
                {
                    MessageBox.Show("输入有误，请输入〇-->46的正整数！");
                    return;
                }
                textBox1.Text = "";
                textBox1.Focus();
                Tool.F = this;  //窗体传递
                Tool.F.Hide();
                ShowForm frmShow = new ShowForm();
                frmShow.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("输入有误，请输入〇-->46的正整数！");
                textBox1.Text = null;
                textBox1.Focus();
            }
        }

    }
}
