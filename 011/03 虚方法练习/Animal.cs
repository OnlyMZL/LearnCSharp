using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_虚方法练习
{
    class Animal
    {
        public virtual void Call()
        {
            Console.WriteLine("动物会叫");
        }
    }
}
