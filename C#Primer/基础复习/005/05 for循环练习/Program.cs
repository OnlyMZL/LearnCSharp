using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_for循环练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //0-100以内所有偶数的和

            //int sum = 0;
            //for (int i = 0; i <= 100; i += 2)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();


            //找出100-999之间的水仙花数
            //水仙花数： 三位数
            //百位数的立方+十位数的立方+个位数的立方==这个数
            //百位数： 153/100
            //十位数： 153%100/10
            //个位数： 153%10

            

            for (int i = 100; i<999; i++)
            {
                int bai = i / 100;
                int shi = i % 100 / 10;
                int ge = i % 10;
                if (bai * bai * bai + shi * shi * shi + ge * ge * ge == i)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();



        }
    }
}
