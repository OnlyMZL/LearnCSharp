using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007扫地机器人路径计算
{
    class Program
    {
        //机器人走路问题：
        //1、上下左右四种移动方式，并且不能往回走。
        //2、计算机器人移动x步的可行路径总数。


        static int count = 0;  //计数器
        static int moveNum = 2;  //移动步数
        static void Main(string[] args)
        {

            int[,] space = new int[101, 101];  //声明一个二维数组，存放移动状态。使用默认值0表示可走状态。

            Move(space,moveNum, 50, 50);  //机器人移动的初始位置为网格中心

            Console.WriteLine(count);
            Console.ReadLine();
        }

        public static void Move(int[,] space, int moveNum,int i, int j)
        {
            if (moveNum >= 0)
            {
                space[i, j] = 1;

                //up
                if (space[i, j - 1] == 0)
                {
                    Move(space, moveNum-1,i, j - 1);
                }
                //down
                if (space[i, j + 1] == 0)
                {
                    Move(space, moveNum - 1, i, j + 1);
                }
                //right
                if (space[i + 1, j] == 0)
                {
                    Move(space, moveNum - 1, i + 1, j);
                }
                //left
                if (space[i - 1, j] == 0)
                {
                    Move(space, moveNum - 1, i - 1, j);
                }

                //将上一步的状态复0
                space[i, j] = 0;
                //判断是否走完x步
                if (moveNum==0)
                {
                    count++;
                }
            }
            
        }
    }
}
