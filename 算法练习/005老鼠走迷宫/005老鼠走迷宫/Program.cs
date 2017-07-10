using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005老鼠走迷宫
{
    class Program
    {
        static int startI = 1, startJ = 1; //声明入口
        static int endI = 8, endJ = 7;  //声明出口
        static void Main(string[] args)
        {
            //声明二维数组，2代表障碍，0代表可通行，1代表已通过
            int[,] maze = new int[,]{{2,2,2,2,2,2,2,2,2},
                                    {2,0,0,0,0,0,0,0,2},
                                    {2,0,2,2,0,2,2,0,2},
                                    {2,0,2,0,0,2,0,0,2},
                                    {2,0,2,0,2,0,2,0,2},
                                    {2,0,0,0,0,0,2,0,2},
                                    {2,2,0,2,2,0,2,2,2},
                                    {2,0,0,0,0,0,0,0,2},
                                    {2,2,2,2,2,2,2,2,2}};
            endI = maze.GetLength(0) - 2;
            endJ = maze.GetLength(0) - 2;

            Console.WriteLine("打印迷宫：");
            PrintMaze(maze);

            Console.WriteLine("走出迷宫的路径：");
            VisitMaza(maze, startI, startJ);

            Console.ReadKey();
        }

        /// <summary>
        /// 打印迷宫
        /// </summary>
        /// <param name="maze"></param>
        public static void PrintMaze(int[,] maze)
        {
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(0); j++)
                {
                    if (maze[i, j] == 2)
                    {
                        Console.Write("■");
                    }
                    else if (maze[i, j] == 0)
                    {
                        Console.Write("☆");
                    }
                    else
                    {
                        Console.Write("★");
                    }
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 寻可行路径，并打印出来
        /// </summary>
        /// <param name="maze"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void VisitMaza(int[,] maze, int i, int j)
        {
            maze[i, j] = 1;
            if (i == endI && j == endJ)
            {
                Console.WriteLine("所有可行路径:");
                PrintMaze(maze);
            }
            if (maze[i, j - 1] == 0)
            {
                VisitMaza(maze, i, j - 1);
            }
            if (maze[i, j + 1] == 0)
            {
                VisitMaza(maze, i, j + 1);
            }
            if (maze[i + 1, j] == 0)
            {
                VisitMaza(maze, i + 1, j);
            }
            if (maze[i - 1, j] == 0)
            {
                VisitMaza(maze, i - 1, j);
            }
            
            maze[i, j] = 0;
        }
    }
}
