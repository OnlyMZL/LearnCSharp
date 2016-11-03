using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //让用户输入姓名 语文 数学 英语  三门课的成绩
            //然后给用户显示: XX,你的总成绩为XX分,平均成绩为XX分。
            Console.WriteLine("请输入您的姓名：");
            string name = Console.ReadLine();
            Console.WriteLine("请输入您的语文成绩：");
            string strChinese = Console.ReadLine();
            Console.WriteLine("请输入您的数学成绩：");
            string strMath = Console.ReadLine();
            Console.WriteLine("请输入您的英语成绩：");
            string strEnglish = Console.ReadLine();

            int intChinese = Convert.ToInt32(strChinese);
            int intMath = Convert.ToInt32(strMath);
            int intEnglish = Convert.ToInt32(strEnglish);

            int totalScores = intChinese + intMath + intEnglish;
            double averageScores = totalScores * 1.0 / 3;
            Console.WriteLine("{0}，你的总成绩是{1}，平均成绩是{2:0.00}.",name,totalScores,averageScores);
            Console.ReadKey();
        }
    }
}
