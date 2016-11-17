using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_简单工厂设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入笔记本品牌");
            string brand = Console.ReadLine();
            NoteBook nb = GetNoteBook(brand);
            nb.SayHello();
            Console.ReadKey();
        }
        public static NoteBook GetNoteBook(string brand)
        {
            NoteBook nb = null;
            switch (brand)
            {
                case "Acer": nb = new Acer(); break;
                case "Dell": nb = new Dell(); break;
            }
            return nb;
        }
    }
}
