using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _005_多播委托
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student() { ID = 1, PenColor = ConsoleColor.Green };
            Student stu2 = new Student() { ID = 2, PenColor = ConsoleColor.Red };
            Student stu3 = new Student() { ID = 3, PenColor = ConsoleColor.Yellow };

            Action action1 = new Action(stu1.DoHomework);
            Action action2 = new Action(stu2.DoHomework);
            Action action3 = new Action(stu3.DoHomework);

            //一般调用
            Console.WriteLine("一般调用");
            action1();
            action2.Invoke();
            action3.Invoke();

            //多播(multicast)委托
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("多播委托");
            action1 += action2;
            action1 += action3;
            action1.Invoke();   //执行顺序为1,2,3

            Console.ReadKey();
        }
    }

    class Student
    {
        public int ID { get; set; }
        public ConsoleColor PenColor { get; set; }

        public void DoHomework()
        {
            Console.ForegroundColor = PenColor;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Student{0} doing homework {1} hour(s).",ID,i);
                Thread.Sleep(300);
            }
        }
    }
}
