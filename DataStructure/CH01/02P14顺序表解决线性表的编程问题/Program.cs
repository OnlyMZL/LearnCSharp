using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02P14顺序表解决线性表的编程问题
{
    class Program
    {
        static void Main(string[] args)
        {
            SeqList<int> l = new SeqList<int>(5);
            l.InsertNode(1, 1);
            l.InsertNode(4, 2);
            l.InsertNode(3, 3);
            l.InsertNode(2, 4);
            l.InsertNode(1, 5);
            Console.WriteLine(l.SearchNodeBySeat(3));
            l.SearchNodeByValue(1);
            
            

            Console.ReadLine();


        }
    }
}
