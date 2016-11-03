using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_逻辑运算符练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //让用户输入老苏的语文和数学成绩,输出以下判断是否正确,正确输出true ,错误输出false
            //1)老苏的语文和数学成绩都大于90
            //2）语文和数学有一门是大于90分的
            Console.WriteLine("请输入语文成绩：");
            string strChinese = Console.ReadLine();
            int chinese = Convert.ToInt32(strChinese);
            Console.WriteLine("请输入数学成绩：");
            string strMath = Console.ReadLine();
            int math = Convert.ToInt32(strMath);

            Console.WriteLine("1  \n" + (chinese > 90 && math > 90).ToString());
            Console.WriteLine("2  \n" + (chinese > 90 || math > 90).ToString());
            Console.ReadKey();

        }
    }
}
