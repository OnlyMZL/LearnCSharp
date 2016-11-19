using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_虚方法练习
{
    class Dog:Animal
    {
        public override void Call()
        {
            Console.WriteLine("小狗汪汪叫");
        }
    }
}
