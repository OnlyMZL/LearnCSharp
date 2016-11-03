using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_switch_case练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //判断输入的月份有多少天
            try
            {
                Console.WriteLine("请输入年份");
                int year = Convert.ToInt32(Console.ReadLine());
                try
                {
                    Console.WriteLine("请输入月份");
                    int month = Convert.ToInt32(Console.ReadLine());
                    if (month >= 1 && month <= 12)
                    {
                        int day = 0;
                        switch (month)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 10:
                            case 7:
                            case 8:
                            case 12:
                                day = 31;
                                break;
                            case 4:
                            case 6:
                            case 9:
                            case 11:
                                day = 30;
                                break;
                            case 2:
                                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                                {
                                    day = 29;
                                }
                                else
                                {
                                    day = 28;
                                }
                                break;
                        }
                        Console.WriteLine("{0}年{1}月有{2}天", year, month, day);
                    }//if判断输入月份的括号
                    else
                    {
                        Console.WriteLine("输入的月份不符合要求，程序退出");
                    }
                }//月份try括号
                catch//月份的catch
                {
                    Console.WriteLine("输入的月份有误,程序退出");
                }
            }//年份try括号
            catch//年份的catch
            {
                Console.WriteLine("输入的年份有误,程序退出");
            }
            Console.Read();
        }
    }
}
