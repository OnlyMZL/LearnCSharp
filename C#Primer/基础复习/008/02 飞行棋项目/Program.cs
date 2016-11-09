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
        //声明一个静态数组来存储玩家A跟玩家B的名字
        static string[] PlayerNames = new string[2];


        static void Main(string[] args)
        {
            GameShow();  //画游戏头

            #region 获取用户输入的玩家A的姓名
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("请输入玩家A的姓名");
            PlayerNames[0] = Console.ReadLine();
            while (PlayerNames[0]=="")
            {
                Console.WriteLine("玩家姓名不能为空，请重新输入");
                PlayerNames[0] = Console.ReadLine();
            }
            #endregion

            #region 获取用户输入的玩家B的姓名
            Console.WriteLine("请输入玩家B的姓名");
            PlayerNames[1] = Console.ReadLine();
            while (PlayerNames[1] == ""||PlayerNames[1]==PlayerNames[0])
            {
                if (PlayerNames[1] == "")
                {
                    Console.WriteLine("玩家姓名不能为空，请重新输入");
                    PlayerNames[1] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("玩家B姓名不能与玩家A相同，请重新输入");
                    PlayerNames[1] = Console.ReadLine();
                }
            }
            #endregion

            Console.Clear(); //获得玩家姓名后清屏
            GameShow();  //游戏头
            InitailMap();
            DrawMap();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("玩家A姓名为{0}，玩家B姓名为{1}，按任意键开始游戏",PlayerNames[0],PlayerNames[1]);
            PlayGame()


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


        /// <summary>
        /// 创建地图
        /// </summary>
        public static void DrawMap()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("游戏提示：□安全   ◎幸运轮盘   ☆地雷   ▲暂停   卐时空隧道");
            Console.WriteLine();
            #region  画第一横行
            //第一横行
            for (int i = 0; i < 30; i++)
            {
                DrawMapString(i);
            }
            Console.WriteLine(); //第一横行画完之后换行
            #endregion

            #region  画第一竖行
            for (int i = 30; i <= 34 && i >= 30; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    Console.Write("  ");  //画空格，两个空格占的位置等于一个全角符号
                }
                DrawMapString(i);
                Console.WriteLine();
            }
            #endregion

            #region  画第二横行
            for (int i = 64; i <= 64 && i >= 35; i--)
            {
                DrawMapString(i);
            }
            Console.WriteLine();

            #endregion

            #region 画第二竖行
            for (int i = 69; i <= 69 && i >= 65; i--)
            {
                DrawMapString(i);
                Console.WriteLine();  //画完一个符号后  立即换行
            }
            #endregion

            #region 画第三横行
            for (int i = 70; i <= 99 && i >= 70; i++)
            {
                DrawMapString(i);
            }
            Console.WriteLine();
            #endregion

        }


        /// <summary>
        /// 创建地图时的一个方法，用来在地图上画相应的符号。
        /// </summary>
        /// <param name="i">Maps数组的索引值</param>
        public static void DrawMapString(int i)
        {
            //如果玩家A跟玩家B的坐标相同，并且都在地图上，画一个尖括号
            if (PlayerPos[0] == PlayerPos[1] && PlayerPos[1] == i)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("<>");
            }

            //当玩家A和玩家B的坐标不同时，分别画Ａ　Ｂ
            else if (PlayerPos[0] == i)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Ａ");
            }
            else if (PlayerPos[1] == i)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("Ｂ");
            }
            else
            {
                switch (Maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write("□");
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("◎");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("☆");
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("▲");
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("卐");
                        break;
                }
            }
        }

        /// <summary>
        /// 玩游戏
        /// </summary>
        /// <param name="i">玩家姓名的索引值</param>
        public static void PlayGame(int i)
        {
            Console.WriteLine("玩家{0}开始玩游戏，按任意键掷骰子",PlayerNames[i]);



        }




    }
}
