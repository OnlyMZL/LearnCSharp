using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _16_集合的两个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个集合，里面添加一些数字，求平均值与和,最大值，最小值
            //ArrayList list = new ArrayList();
            //list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            //int sum = 0;
            //int max = (int)list[0];
            //for (int i = 0; i < (int)list.Count; i++)
            //{
            //    sum += (int)list[i];
            //    if (max < (int)list[i])
            //    {
            //        max = (int)list[i];
            //    }
            //}
            //Console.WriteLine(sum);
            //Console.WriteLine(sum/list.Count);
            //Console.WriteLine(max);
            //Console.ReadKey();


            //写一个长度为10的集合，要求在里面随机地存放10个数字（0-9），
            //但是要求所有的数字不重复
            ArrayList list = new ArrayList();
            Random rNum = new Random();
            int r = 0;
            for (int i = 0; i < 10; i++)
            {
                r = rNum.Next(0, 10);
                if (!list.Contains(r))
                {
                    list.Add(r);
                }
                else
                {
                    i--;
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
}
