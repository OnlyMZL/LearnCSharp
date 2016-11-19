using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_简单工厂设计模式
{
    class Dell:NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是戴尔笔记本");
        }

    }
}
