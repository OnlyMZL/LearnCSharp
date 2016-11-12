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
        //声明一个bool标记玩家玩游戏的顺序
        static bool[] flag = new bool[2];

        static void Main(string[] args)
        {
            GameShow();  //画游戏头

            #region 获取用户输入的玩家A的姓名
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("请输入玩家A的姓名");
            PlayerNames[0] = Console.ReadLine();
            while (PlayerNames[0] == "")
            {
                Console.WriteLine("玩家姓名不能为空，请重新输入");
                PlayerNames[0] = Console.ReadLine();
            }
            #endregion

            #region 获取用户输入的玩家B的姓名
            Console.WriteLine("请输入玩家B的姓名");
            PlayerNames[1] = Console.ReadLine();
            while (PlayerNames[1] == "" || PlayerNames[1] == PlayerNames[0])
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
            Console.WriteLine("玩家A姓名为{0}，玩家B姓名为{1}，按任意键开始游戏", PlayerNames[0], PlayerNames[1]);
            Console.ReadKey(true);
            Console.Clear();
            DrawMap();
            #region 玩家轮流玩游戏
            while (PlayerPos[0] < 99 && PlayerPos[1] < 99)
            {
                if (flag[0] == false)
                {
                    PlayGame(0);
                    Console.Clear();
                    DrawMap();
                }
                else
                {
                    flag[0] = false;
                }
                if (flag[1] == false)
                {
                    PlayGame(1);
                    Console.Clear();
                    DrawMap();
                }
                else
                {
                    flag[1] = false;
                }
            }
            #endregion
            Won();
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
            for (int i = 65; i <= 69 && i >= 65; i++)
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
            Console.ForegroundColor = ConsoleColor.White;
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
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Ａ");
            }
            else if (PlayerPos[1] == i)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
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
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
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
            Console.WriteLine("{0}开始玩游戏，按任意键掷骰子", PlayerNames[i]);
            Console.ReadKey(true);
            Random rNum = new Random();
            int r = rNum.Next(1, 7);
            Console.WriteLine("{0}掷出了{1}", PlayerNames[i], r);
            Console.ReadKey(true);
            PlayerPos[i] += r;
            PosChange(i);
            //判断当前玩家是否赢得了比赛
            if (PlayerPos[i] == 99)
            {
                Console.Clear();
                DrawMap();
                return;
            }
            switch (Maps[PlayerPos[i]])
            {
                case 0:
                    Console.WriteLine("{0}行动完了，踩到了方块，安全。", PlayerNames[i]);
                    Console.ReadKey(true);
                    break;
                case 1:
                    Console.WriteLine("{0}行动完了，踩到了幸运轮盘，请选择：\n 1--与对手交换位置  2--轰炸对手（对手退六格）", PlayerNames[i]);
                    string s = Console.ReadLine();
                    int temp;
                    while (!(s == "1") && !(s == "2"))
                    {
                        Console.WriteLine("输入有误，请重新输入：1/2");
                        s = Console.ReadLine();
                    }
                    if (s == "1")
                    {
                        temp = PlayerPos[i];
                        PlayerPos[i] = PlayerPos[1 - i];
                        PlayerPos[1 - i] = temp;
                        Console.WriteLine("玩家位置交换完毕");
                        Console.ReadKey(true);
                    }
                    else
                    {
                        PlayerPos[1 - i] -= 6;
                        Console.WriteLine("轰炸完成");
                        Console.ReadKey(true);
                    }
                    break;
                case 2:
                    Console.WriteLine("{0}行动完了，踩到了地雷，退6格", PlayerNames[i]);
                    PlayerPos[i] -= 6;
                    Console.ReadKey(true);
                    break;
                case 3:
                    Console.WriteLine("{0}行动完了，踩到了暂停，暂停一轮游戏", PlayerNames[i]);
                    Console.ReadKey(true);
                    flag[i] = !flag[i];
                    break;
                case 4:
                    Console.WriteLine("{0}行动完了，踩到了时空隧道，前进10格", PlayerNames[i]);
                    PlayerPos[i] += 10;
                    Console.ReadKey(true);
                    break;
            }//switch
            //玩家位置超出地图的处理
            PosChange(i);

        }//方法


        /// <summary>
        /// 玩家位置改变时，判断位置是否超出地图界限
        /// </summary>
        /// <param name="i">玩家索引</param>
        public static void PosChange(int i)
        {
            if (PlayerPos[i] < 0)
            {
                PlayerPos[i] = 0;
            }
            else if (PlayerPos[i] > 99)
            {
                PlayerPos[i] = 99;
            }
            if (PlayerPos[1 - i] < 0)
            {
                PlayerPos[1 - i] = 0;
            }
            else if (PlayerPos[1 - i] > 99)
            {
                PlayerPos[1 - i] = 99;
            }
        }


        /// <summary>
        /// 判读哪位玩家赢得了比赛
        /// </summary>
        public static void Won()
        {
            if (PlayerPos[0] == 99)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("玩家A无耻地赢了玩家B！！");
            }
            if (PlayerPos[1] == 99)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("玩家B无耻地赢了玩家A！！");
            }
        }


    }
}
