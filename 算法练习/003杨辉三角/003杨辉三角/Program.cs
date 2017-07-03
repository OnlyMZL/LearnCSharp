using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003杨辉三角
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入杨辉三角长度：");
            int len = Convert.ToInt32(Console.ReadLine());
            int[,] array = Init(len);
            Display(array);
            Console.ReadLine();
        }

        /// <summary>
        /// 根据用户输入，初始化三角数据
        /// </summary>
        /// <param name="len"></param>
        /// <returns></returns>
        public static int[,] Init(int len)
        {
            // int[, ] array= new int[3,2] { { 00, 01 }, 
            //                               { 10, 11 }, 
            //                               { 20, 21 } };
            int[,] array = new int[len, len];
            for (int i = 0; i < len; i++)
            {
                if (i == 0)
                {
                    array[0, 0] = 1;
                }
                else if (i == 2)
                {
                    array[0, 0] = 1;
                    array[1, 0] = 1;
                    array[1, 1] = 1;
                }
                for (int j = 1; j <= i; j++)
                {
                    array[i, 0] = 1;
                    array[i, i] = 1;
                    array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
                }
            }
            return array;
        }

        /// <summary>
        /// 打印数组
        /// </summary>
        /// <param name="array"></param>
        public static void Display(int[,] array)
        {
            Console.WriteLine("杨辉三角");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(array[i, j] + "\t");
                    if (i == j)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }


    }
}
