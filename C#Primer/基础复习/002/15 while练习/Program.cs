using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_while练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习1
            ////输入班级人数,然后依次输入学员成绩，计算班级学员的平均成绩和总成绩

            ////接收班级人数   学员成绩   平均成绩  总成绩
            ////循环体：输入学员成绩
            ////循环条件：班级人数

            //Console.WriteLine("请输入班级人数");
            //int i = Convert.ToInt32(Console.ReadLine());
            //int j = 1;
            //double score = 0;
            //while (j <= i)
            //{
            //    Console.WriteLine("请输入第{0}个学员的成绩",j);
            //    score = Convert.ToDouble(Console.ReadLine());
            //    j++;
            //    score += score;
            //}
            //Console.WriteLine("班级一共{0}人， 总成绩为{1}，平均成绩为{2}",i,score,score/i);
            //Console.ReadKey();

            #endregion

            #region 练习2
            //老师问学生,这道题你会做了吗?如果学生答"会了(y)",
            //则可以放学.如果学生不会做(n),则老师再讲一遍,再问学生是否会做了......
            //直到学生会为止,才可以放学.
            //直到学生会或老师给他讲了10遍还不会,都要放学

            //需要声明的变量： 学生回答（yes/no）  i 
            //循环体：会做了吗
            //循环条件：yes   讲了10遍

            //string answer = "no";
            //int i = 0;
            //while (i<10)
            //{
            //    Console.WriteLine("会做了吗？ yes/no");
            //    answer = Console.ReadLine();
            //    i++;
            //    if (answer == "yes")
            //        break;
            //}
            //Console.WriteLine("放学");
            //Console.Read();

            #endregion

            #region

            //2006年培养学员80000人，每年增长25%，
            //请问按此增长速度，到哪一年培训学员人数将达到20万人？

            //声明变量   学员数量  年 
            //循环体： 学院数量*（1.25）^年
            //循环条件： 学院数量>20万

            double year = 0;
            double num = 80000;
            while (num<200000)
            {
                year++;
                num = num * Math.Pow(1.25,year);
            }
            Console.WriteLine(year);
            Console.ReadLine();
            #endregion


        }
    }
}
