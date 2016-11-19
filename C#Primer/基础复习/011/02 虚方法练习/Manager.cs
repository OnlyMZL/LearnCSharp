using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_虚方法练习
{
    class Manager:Stark
    {
        public override void DaKa()
        {
            Console.WriteLine("经理十一点打卡");
        }
    }
}
