using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001汉诺塔
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lblAnswer.Text = null;
                string input = textBox1.Text;
                int inputNum = Convert.ToInt32(input);
                if (inputNum < 1 || inputNum > 64)
                {
                    MessageBox.Show("输入有误，请输入1--64整数！", "错误提示");
                    textBox1.Text = null;
                    textBox1.Focus();
                    return;
                }
                int j = MoveBlock(inputNum);
                lblAnswer.Text = "所需移动" + j + "次";
                i = 0;  //初始化计数器
            }
            catch (Exception)
            {
                MessageBox.Show("输入有误，请输入1--64整数！", "错误提示");
            }
        }

        int i = 0;  //计数器
        public int MoveBlock(int n)
        {
            if (n == 1)
            {
                i++;  //只需移动一次  a-->c
            }
            else
            {
                MoveBlock(n - 1);  //由a--》b
                i++;
                MoveBlock(n - 1);  //由b-->c
            }
            return i;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
