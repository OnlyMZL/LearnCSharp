using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_四个练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1)比较3个数字的大小,不考虑相等
            //Console.WriteLine("请输入第一个数字");
            //double num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //double num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第三个数字");
            //double num3 = Convert.ToInt32(Console.ReadLine());
            //if (num1 > num2 && num1 > num3)
            //{
            //    Console.WriteLine("三个数中最大的是：" + num1);
            //}
            //else if (num2 > num1 && num2 > num3)
            //{
            //    Console.WriteLine("三个数中最大的是：" + num2);
            //}
            //else
            //{
            //    Console.WriteLine("三个数中最大的是：" + num3);
            //}
            //Console.ReadKey();


            ////2）密码比较
            //Console.WriteLine("请输入密码：");
            //string pwd = Console.ReadLine();
            //if (pwd == "888888")
            //{
            //    Console.WriteLine("登陆成功");
            //}
            //else
            //{
            //    Console.WriteLine("密码错误！");

            //}
            //Console.ReadLine();


            ////3）用户名和密码输入  错误提示
            //Console.WriteLine("请输入用户名");
            //string user = Console.ReadLine();
            //Console.WriteLine("请输入密码");
            //string pwd = Console.ReadLine();
            //if (user == "admin" && pwd == "888888")
            //{
            //    Console.WriteLine("登陆成功！");
            //}
            //else if (user == "admin")
            //{
            //    Console.WriteLine("密码错误");
            //}
            //else if (pwd == "888888")
            //{
            //    Console.WriteLine("用户名错误");
            //}
            //else
            //{
            //    Console.WriteLine("用户名和密码错误");
            //}
            //Console.ReadLine();


            //4)提示用户输入年龄，如果大于等于18，则告知用户可以查看，
            //如果小于10岁，则告知不可以查看
            //如果大于等于10岁并且小于18岁，则提示用户是否继续查看（yes，no），
            //如果输入的是yes则提示用户请查看，否则提示“退出，你放弃查看”。
            Console.WriteLine("请输入您的年龄，以查看");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("您可以查看");
            }
            if (age < 18 && age >= 10)
            {
                Console.WriteLine("输入yes以继续查看，输入no则退出");
                string str = Console.ReadLine();
                if (str == "yes")
                {
                    Console.WriteLine("您可以查看");
                }
                if (str == "no")
                {
                    Console.WriteLine("退出，您放弃查看");
                }
            }
            if (age < 10)
            {
                Console.WriteLine("不允许查看");
            }
            Console.ReadLine();
        }
    }
}
