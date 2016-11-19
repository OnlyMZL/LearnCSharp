using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_虚方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //小狗汪汪叫 小猫喵喵叫
            Dog dog = new Dog();
            Cat cat = new Cat();
            Animal[] animals = { dog, cat };
            foreach (var item in animals)
            {
                item.Call();
            }
            Console.ReadKey();
        }
    }
}
