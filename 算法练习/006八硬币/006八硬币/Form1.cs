using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006八硬币
{
    public partial class Form1 : Form
    {
        int flag = 0;   //判断硬币是否被创建成功
        Coin[] coinTemp;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// btn “生成硬币” 的click事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCal_Click(object sender, EventArgs e)
        {
            try
            {
                //获取用户输入，并转换为double类型
                double weightPT = Convert.ToDouble(txtPT.Text);
                double weightEB = Convert.ToDouble(txtEB.Text);
                if (weightPT == weightEB)
                {
                    MessageBox.Show("输入错啦！没有二笔硬币！");
                    txtResult.Text = "你是二笔！";
                    return;
                }

                //根据用户输入，声明两种类型的硬币
                Coin coinsPT = new Coin(weightPT, "普通硬币");
                Coin coinsEB = new Coin(weightEB, "二笔硬币");

                //创建数组并存储硬币
                Coin[] coins = new Coin[8];
                for (int i = 0; i < 8; i++)
                {
                    coins[i] = coinsPT;
                }
                Random ran = new Random();
                int EBNum = ran.Next(0, 8);
                coins[EBNum] = coinsEB;
                coinTemp = coins;
                txtResult.Text = "创建硬币成功！";
                flag = 1;
            }
            catch
            {
                MessageBox.Show("输入有误！请重新输入！", "错误提示：");
                txtPT.Text = "";
                txtEB.Text = "";
                txtResult.Text = "";
            }

        }
        
        /// <summary>
        /// btn “作弊” 的click事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                MessageBox.Show("请先生成硬币！");
            }
            else
            {
                for (int i = 0; i < 8; i++)
                {
                    if (coinTemp[i].Type == "二笔硬币")
                    {
                        txtResult.AppendText("\r\n二笔硬币在第" + (i + 1).ToString() + "位！");
                        if (i != 0)
                        {
                            if (coinTemp[i].Weight < coinTemp[i - 1].Weight)
                            {
                                txtResult.AppendText("  它比普通硬币轻！");
                            }
                            else
                            {
                                txtResult.AppendText("  它比普通硬币重！");
                            }
                        }
                        else if (i == 0)
                        {
                            if (coinTemp[i].Weight < coinTemp[i + 1].Weight)
                            {
                                txtResult.AppendText("  它比普通硬币轻！");
                            }
                            else
                            {
                                txtResult.AppendText("  它比普通硬币重！");
                            }
                        }
                        break;
                    }
                }
            }
        }
        
        /// <summary>
        /// btn “找出二笔硬币” 的click事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                MessageBox.Show("请先生成硬币！");
                return;
            }
            FindEBCoin(coinTemp);
            //else
            //{
            //    for (int i = 0; i < 8; i++)
            //    {
            //        if (coinTemp[i].Type == "二笔硬币")
            //        {
            //            txtResult.AppendText("\r\n二逼硬币在第" + (i + 1).ToString() + "位！");
            //            break;
            //        }
            //    }
            //}
        }




        /// <summary>
        /// 找出二笔硬币的方法
        /// </summary>
        /// <param name="coins">存储硬币的数组</param>
        public void FindEBCoin(Coin[] coins)
        {
            //3==3
            txtResult.AppendText("\r\n将硬币分成3,3,2组进行重量比较...");
            if (coins[0].Weight + coins[1].Weight + coins[2].Weight == coins[3].Weight + coins[4].Weight + coins[5].Weight)
            {
                txtResult.AppendText("\r\n3，3组硬币重量相同...");
                if (coins[0].Weight == coins[6].Weight)
                {
                    txtResult.AppendText("\r\n比较第1个和第7个硬币重量，重量相同...");
                    if (coins[0].Weight > coins[7].Weight)
                        txtResult.AppendText("\r\n" + coins[7].Type + "被放在第8位！比普通硬币轻！");
                    else
                        txtResult.AppendText("\r\n" + coins[7].Type + "被放在第8位！比普通硬币重！");
                }
                else
                {
                    txtResult.AppendText("\r\n比较第1个和第7个硬币重量，重量不同...");
                    if (coins[0].Weight > coins[6].Weight)
                        txtResult.AppendText("\r\n" + coins[6].Type + "被放在第7位！比普通硬币轻！");
                    else
                        txtResult.AppendText("\r\n" + coins[6].Type + "被放在第7位！比普通硬币重！");
                }
            }

            //3>3
            else if (coins[0].Weight + coins[1].Weight + coins[2].Weight != coins[3].Weight + coins[4].Weight + coins[5].Weight)
            {
                txtResult.AppendText("\r\n3，3组硬币重量不同...算法还没写，可点击“作弊”找出二逼硬币！");
            }


        }

    }
}
