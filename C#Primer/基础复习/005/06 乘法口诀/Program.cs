using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_乘法口诀
{
    class Program
    {
        static void Main(string[] args)
        {


            #region 下三角乘法口诀表

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0}X{1}={2}\t", j, i, i * j);
            //    }
            //    Console.Write("\n");
            //}
            //Console.ReadKey();
            #endregion


            //Console.WriteLine("请输入一个整数");
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i <= num; i++)
            //{
            //    int j = num - i;
            //    Console.WriteLine("{0}+{1}={2}", i, j, num);
            //}
            //Console.ReadLine();


            int sum = 0;
            bool b = true;
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Console.WriteLine("请输入第{0}个人的年龄",i+1);
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (age > 0 && age < +100)
                    {
                        sum += age;
                    }
                    else
                    {
                        Console.WriteLine("输入的年龄有误，程序将退出！！");
                        b = false;
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("输入有误，程序将退出！！");
                    b = false;
                    break;
                }
            }
            if (b)
            {
                Console.WriteLine("这五个人的平均年龄是{0}岁", sum / 5);
            }
            Console.ReadLine();
        }
    }
}
