using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_方法的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //提示用户输入两个数字  计算这两个数字之间所有整数的和
            //1）用户只能输入数字
            //2)要求第一个数字必须比第二个数字小 否则就重新输入
            //3）计算两个数字之间的所有整数的和


            //要求用户输入两个数字 并将用户输入转换成数字
            double n1 = 0;
            double n2 = 0;
            //第一种方法  判断用户输入的数字大小   n1<n2
            //while (n1 >= n2)
            //{
            //    Console.WriteLine("请输入第一个数字");
            //    string num1 = Console.ReadLine();
            //    n1 = GetNum(num1);
            //    Console.WriteLine("请输入第二个数字");
            //    string num2 = Console.ReadLine();
            //    n2 = GetNum(num2);
            //    if (n1 >= n2)
            //    {
            //        Console.WriteLine("输入有误，请重新输入");
            //    }
            //}

            Console.WriteLine("请输入第一个数字");
            string num1 = Console.ReadLine();
            n1 = GetNum(num1);
            Console.WriteLine("请输入第二个数字");
            string num2 = Console.ReadLine();
            n2 = GetNum(num2);

            //第二种方法判断用户输入的数字大小  n1<n2
            Judge(ref n1,ref n2);
            int sum = GetSum(n1, n2);
            Console.WriteLine("{0}和{1}之间所有整数的和是{2}", n1, n2, sum);
            Console.ReadLine();
        }


        /// <summary>
        /// 判断数字大小，只允许n1>n2
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        public static void Judge(ref double n1,ref double n2)
        {
            while (true)
            {
                if (n1 < n2)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("输入有误，请重新输入第一个数字");
                    n1 = GetNum(Console.ReadLine());
                    Console.WriteLine("请输入第二个数字");
                    n2 = GetNum(Console.ReadLine());
                }
            }
        }

        /// <summary>
        /// 将用户输入的内容转换成数字
        /// </summary>
        /// <param name="str">用户输入的内容</param>
        /// <returns>数字</returns>
        public static double GetNum(string str)
        {
            while (true)
            {
                try
                {
                    double num = Convert.ToDouble(str);
                    return num;
                }
                catch
                {
                    Console.WriteLine("输入有误，请重新输入");
                    str = Console.ReadLine();
                }
            }
        }


        /// <summary>
        /// 求数字n1,n2之间所有整数的和
        /// </summary>
        /// <param name="n1">较小的数</param>
        /// <param name="n2">较大的数</param>
        /// <returns>和</returns>
        public static int GetSum(double n1, double n2)
        {
            int j = 0;   //double型转换int型会四舍五入
            if (n1 % 1 >= 0.5)
                j = Convert.ToInt32(n1);
            else
                j = Convert.ToInt32(n1) + 1;
            int sum = 0;
            for (int i = j; i < n2; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
