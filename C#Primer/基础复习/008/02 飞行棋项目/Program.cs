using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_飞行棋项目
{
    class Program
    {
        //用静态字段模拟全局变量  存储地图
        public static int[] Maps = new int[100];
        //声明一个静态数组来存储玩家A跟玩家B的坐标
        static int[] PlayerPos = new int[2];



        static void Main(string[] args)
        {
            GameShow();
            InitailMap();
            DrawMap();
            Console.ReadKey();


        }

        /// <summary>
        /// 显示程序头
        /// </summary>
        public static void GameShow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*********************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*********************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*********************************");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("***********飞行棋 v1.0***********");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*********************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*********************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*********************************");

        }


        /// <summary>
        /// 初始化地图
        /// </summary>
        public static void InitailMap()
        {
            //....0....表示普通,显示给用户就是 □
            //....1...幸运轮盘,显示组用户就◎ 
            //....2...地雷,显示给用户就是 ☆
            //....3...暂停,显示给用户就是 ▲
            //....4...时空隧道,显示组用户就 卐
            int[] luckyTurn = { 6, 23, 40, 55, 69, 83 };//幸运轮盘◎
            for (int i = 0; i < luckyTurn.Length; i++)
            {
                Maps[luckyTurn[i]] = 1;
            }
            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };//地雷☆
            for (int i = 0; i < landMine.Length; i++)
            {
                Maps[landMine[i]] = 2;
            }
            int[] pause = { 9, 27, 60, 93 };//暂停▲
            for (int i = 0; i < pause.Length; i++)
            {
                Maps[pause[i]] = 3;
            }
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };//时空隧道卐
            for (int i = 0; i < timeTunnel.Length; i++)
            {
                Maps[timeTunnel[i]] = 4;
            }
        }


        public static void DrawMap()
        {
            //第一横行
            for (int i = 0; i < 30; i++)
            {
                //如果玩家A跟玩家B的坐标相同，并且都在地图上，画一个尖括号
                if (PlayerPos[0] == PlayerPos[1] && PlayerPos[1] == i)
                {
                    Console.Write("<>");
                }

                //当玩家A和玩家B的坐标不同时，分别画Ａ　Ｂ
                else if (PlayerPos[0] == i)
                {
                    Console.Write("Ａ");
                }
                else if (PlayerPos[1] == i)
                {
                    Console.Write("Ｂ");
                }
                else
                {
                    switch (Maps[i])
                    {
                        case 0:Console.Write("□");
                            break;
                        case 1:Console.Write("◎");
                            break;
                        case 2:Console.Write("☆");
                            break;
                        case 3:Console.Write("▲");
                            break;
                        case 4:Console.Write("卐");
                            break;
                    }
                }
            }
        }






    }
}
