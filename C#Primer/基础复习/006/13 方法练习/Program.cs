using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //提示用户输入整数,如果不是整数  提示用户重新输入

            Console.WriteLine("请输入一个整数");
            string input = Console.ReadLine();
            int number=GetIntNumber(input);
            Console.WriteLine("您输入的数字是{0}",number);
            Console.ReadKey();
        }

        /// <summary>
        /// 把用户的输入转换成整数
        /// </summary>
        /// <param name="s">获得用户输入的参数</param>
        /// <returns>转换成的整数</returns>
        public static int GetIntNumber(string s)
        {
            while (true)
            {
                try
                {
                    int intnumber = Convert.ToInt32(s);
                    return intnumber;
                }
                catch
                {
                    Console.WriteLine("输入有误，请重新输入");
                    s = Console.ReadLine();
                }
            }
        }
    }
}
