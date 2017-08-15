using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _007_1_改写为winform程序
{
    public partial class Form1 : Form
    {
        //机器人走路问题：
        //1、上下左右四种移动方式，并且不能往回走。
        //2、计算机器人移动x步的可行路径总数。
        static int moveNum = 0;  //移动步数
        static int count = 0;  //计数器
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtResult.Text = "注意：请输入1-15以内的正整数！";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                moveNum = Convert.ToInt32(txtMoveNum.Text);
                txtResult.Text = "您输入的机器人移动步数为" + moveNum.ToString();
                if (moveNum < 1 || moveNum > 15)
                {
                    MessageBox.Show("输入有误！请输入1-15以内的正整数！");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("输入有误！");
                return;
            }
            
            int[,] space = new int[101, 101];  //声明一个二维数组，存放移动状态。使用默认值0表示可走状态。
            txtResult.AppendText("\r\n创建网格成功，开始模拟移动。。。");
            txtResult.AppendText("\r\n模拟移动中。。。");
            txtResult.AppendText("\r\n生成计数器。。。");
            RobotMove(space, moveNum, 50, 50);  //机器人移动的初始位置为网格中心
            txtResult.AppendText("\r\n可行方案为" + count.ToString() + "种。");
            txtResult.AppendText("\r\n计数器归零。");
        }

        /// <summary>
        /// 机器人移动方案统计方法
        /// </summary>
        /// <param name="space">数组网格</param>
        /// <param name="moveNum">定义移动步数</param>
        /// <param name="i">网格中心x坐标</param>
        /// <param name="j">网格中心y坐标</param>
        public static void RobotMove(int[,] space, int moveNum, int i, int j)
        {
            if (moveNum >= 0)
            {
                space[i, j] = 1;

                //up
                if (space[i, j - 1] == 0)
                {
                    RobotMove(space, moveNum - 1, i, j - 1);
                }
                //down
                if (space[i, j + 1] == 0)
                {
                    RobotMove(space, moveNum - 1, i, j + 1);
                }
                //right
                if (space[i + 1, j] == 0)
                {
                    RobotMove(space, moveNum - 1, i + 1, j);
                }
                //left
                if (space[i - 1, j] == 0)
                {
                    RobotMove(space, moveNum - 1, i - 1, j);
                }

                //将上一步的状态复0
                space[i, j] = 0;
                //判断是否走完x步
                if (moveNum == 0)
                {
                    count++;
                }
            }
        }

        private void txtMoveNum_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = null;
        }
    }
}
