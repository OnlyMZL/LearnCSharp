using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_File类
{
    class Program
    {
        static void Main(string[] args)
        {
            //在指定路径创建文件
            //File.Create(@"E:\C#\new.txt");

            //向文件中写入
            //string str = "1234567890";
            //byte[] buffer = Encoding.Default.GetBytes(str);
            //File.WriteAllBytes(@"E:\C#\new.txt", buffer);

            //从文件中读取数据
            //byte[] buffer = File.ReadAllBytes(@"E:\C#\new.txt");
            //string s = Encoding.Default.GetString(buffer);
            //Console.WriteLine(s);

            //向文件中追加写入内容
            File.AppendAllText(@"E:\C#\new.txt","12345678");

            Console.ReadKey();


        }
    }
}
