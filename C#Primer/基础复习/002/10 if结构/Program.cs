using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_if结构
{
    class Program
    {
        static void Main(string[] args)
        {
            ////编程实现：如果跪键盘的时间大于60分钟，那么媳妇奖励晚饭不用做了
            //Console.WriteLine("请输入你跪键盘的时间：");
            //int mins = Convert.ToInt32(Console.ReadLine());
            //if (mins > 60)
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}
            //Console.ReadKey();


            //Console.WriteLine("请输入您的语文成绩：");
            //int Chinese=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入您的音乐成绩：");
            //int Music=Convert.ToInt32(Console.ReadLine());
            //if ((Chinese > 90 && Music > 80) || (Chinese == 100 && Music > 70))
            //{
            //    Console.WriteLine("太棒了，奖励你100块钱！");
            //}
            //else
            //{
            //    Console.WriteLine("继续努力！");
            //}
            //Console.ReadLine();


            //让用户输入用户名和密码，如果用户名为admin，密码为mypass，则提示登陆成功
            Console.WriteLine("请输入用户名：");
            string user = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string pwd = Console.ReadLine();
            if(user.Equals("admin")&&pwd.Equals("mypass"))
            {
                Console.WriteLine("登陆成功");
            }
            Console.ReadLine();
        }
    }
}
