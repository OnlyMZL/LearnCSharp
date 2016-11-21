using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_剪刀石头布
{
    public partial class Form1 : Form
    {
        string cpuStr = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStone_Click(object sender, EventArgs e)
        {
            string str = "石头";
            PlayGame(str);
        }


        /// <summary>
        /// 玩家选择出什么，电脑自动出拳，裁判判断哪方获胜
        /// </summary>
        /// <param name="str">玩家出</param>
        private void PlayGame(string str)
        {
            //创建玩家和电脑实例
            Player player = new Player();
            Computer cpu = new Computer();
            //玩家和电脑出拳
            int playerNum = player.PlayerFist(str);
            int cpuNum = cpu.CpuFist();
            //根据玩家和电脑出拳把结果显示出来
            this.lblPlayer.Text = str;
            switch (cpu.cpuNum)
            {
                case 1:cpuStr = "石头";break;
                case 2:cpuStr = "剪刀";break;
                case 3:cpuStr = "布";break;
            }
            this.lblCpu.Text = cpuStr;
            //判断结果
            Result rst = Judger.Judge(playerNum, cpu.cpuNum);
            lblJudge.Text = rst.ToString();
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            string str = "剪刀";
            PlayGame(str);
        }

        private void btnBu_Click(object sender, EventArgs e)
        {
            string str = "布";
            PlayGame(str);
        }
    }
}
