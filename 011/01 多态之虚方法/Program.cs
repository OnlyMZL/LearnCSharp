using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_多态之虚方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //真的鸭子嘎嘎叫  木头鸭子吱吱叫  橡皮鸭子唧唧叫RealDuck[] ducks = new RealDuck[4];
            RealDuck r1 = new RealDuck();
            RealDuck r2 = new RealDuck();
            MuDuck m2 = new MuDuck();
            XiangDuck x2 = new XiangDuck();
            RealDuck[] ducks = { r1, r2, m2, x2 };
            foreach (var item in ducks)
            {
                item.Bark();
            }
            Console.ReadKey();
        }
    }
}
