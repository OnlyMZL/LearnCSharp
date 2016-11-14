using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_继承练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //记者：我是记者  我的爱好是新闻  我的年龄是25岁 我是一个男记者
            //司机：我叫奔驰  我的年龄是30 我的驾龄是5年  我是男的
            //学生：我叫111  我的年龄是18 我是男生  我还有3年毕业
            Reporter reporter = new Reporter("张三", '男', 25, "新闻");
            reporter.Intro();

            Driver driver = new Driver("奔驰", '男', 30, 5);
            driver.Intro();

            Student student = new Student("111", '男', 18, 3);
            student.Intro();

            Console.ReadKey();
        }
    }
}
