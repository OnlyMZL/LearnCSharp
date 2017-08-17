using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自定义委托
{
    delegate double Calc(double x, double y);
    class Program
    {
        static void Main(string[] args)
        {
            Calc calcMul = new Calc(Mul);
            Calc calcDiv = new Calc(Div);

            double a = 100;
            double b = 200;
            double c = 0;

            c = calcMul.Invoke(a, b);  //第一种调用方式
            Console.WriteLine("{0}×{1}={2}", a, b, c);

            c = calcDiv(a, b);  //第二种调用方式
            Console.WriteLine("{0}÷{1}={2}", a, b, c);

            Console.ReadKey();
        }

        static double Mul(double a, double b)
        {
            return a * b;
        }

        static double Div(double a, double b)
        {
            return a / b;
        }
    }
}
