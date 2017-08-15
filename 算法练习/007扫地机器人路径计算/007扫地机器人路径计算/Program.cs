using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007扫地机器人路径计算
{
    class Program
    {
        static int count = 0;
        static int moveNum = 12;
        static void Main(string[] args)
        {

            int[,] space = new int[100, 100];


            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    space[i, j] = 0;
                }
            }

            Move(space,moveNum, 50, 50);

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
                space[i, j] = 0;
                if (moveNum==0)
                {
                    count++;
                }
            }
            
        }
    }
}
