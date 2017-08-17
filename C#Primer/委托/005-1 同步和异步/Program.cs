using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _005_1_同步和异步
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

            #region 同步调用
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("多播委托也是同步调用的");
            //action1 += action2;
            //action1 += action3;
            //action1.Invoke();   //执行顺序为1,2,3

            //Console.ForegroundColor = ConsoleColor.Cyan;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Main thread {0}", i);
            //    Thread.Sleep(300);
            //}
            #endregion

            #region 隐式异步调用
            ////多线程会造成资源冲突，可以为线程加锁来解决
            //action1.BeginInvoke(null, null);
            //action2.BeginInvoke(null, null);
            //action3.BeginInvoke(null, null);

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Main thread {0}", i);
            //    Thread.Sleep(300);
            //}
            #endregion

            #region 显式异步调用
            ////比较传统的声明多线程的方式
            //Thread thread1 = new Thread(new ThreadStart(stu1.DoHomework));
            //Thread thread2 = new Thread(new ThreadStart(stu2.DoHomework));
            //Thread thread3 = new Thread(new ThreadStart(stu3.DoHomework));
            //thread1.Start();
            //thread2.Start();
            //thread3.Start();

            //高级的方式
            Task task1 = new Task(new Action(stu1.DoHomework));
            Task task2 = new Task(new Action(stu2.DoHomework));
            Task task3 = new Task(new Action(stu3.DoHomework));
            task1.Start();
            task2.Start();
            task3.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main thread {0}", i);
                Thread.Sleep(1000);
            }
            #endregion
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
                Console.WriteLine("Student{0} doing homework {1} hour(s).", ID, i);
                Thread.Sleep(1000);
            }
        }
    }
}
