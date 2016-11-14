using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_里氏转换练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //声明一个Person（父类）数组来存储各种类的实例
            Class.Person[] persons = new Class.Person[10];
            Random rNum = new Random(); //声明随机数以用来创建各种类
            int r = 0;
            for (int i = 0; i < persons.Length; i++)
            {
                r=rNum.Next(1, 4);
                switch (r)
                {
                    case 1:persons[i] = new Class.Meilv();
                        break;
                    case 2:persons[i] = new Class.Student();
                        break;
                    case 3:persons[i] = new Class.Person();
                        break;
                }
            }

            //判断实例的类别以调用相应的方法
            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i] is Class.Meilv)
                {
                    ((Class.Meilv)persons[i]).MeilvSayHi();
                }
                else if (persons[i] is Class.Student)
                {
                    ((Class.Student)persons[i]).StudentSayHi();
                }
                else
                {
                    ((Class.Person)persons[i]).PersonSayHi();
                }
            }//for

            Console.ReadKey();
        }
    }
}
