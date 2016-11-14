using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_里氏转换练习.Class
{
    class Student:Person
    {
        public void StudentSayHi()
        {
            Console.WriteLine("我是学生");
        }
    }
}
