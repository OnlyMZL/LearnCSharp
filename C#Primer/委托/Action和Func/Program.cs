using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action和Func
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Action report = new Action(calc.Report); 
            report.Invoke();  //第一种调用方法
            report();  //第二种调用方法

            Func<double, double, double> funcAdd = new Func<double, double, double>(calc.Add);
            Func<double, double, double> funcSub = new Func<double, double, double>(calc.Sub);

            double a = 100;
            double b = 200;
            double c = 0;
            c=funcAdd(a, b);  //第一种调用方式
            c = funcAdd.Invoke(a, b);  //第二种调用方式
            Console.WriteLine("{0}+{1}={2}",a,b,c);
            c = funcSub(a, b);
            Console.WriteLine("{0}-{1}={2}", a, b, c);

            Console.ReadKey();
        }
    }

    class Calculator
    {
        public void Report()
        {
            Console.WriteLine("I have 3 methods.");
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Sub(double a, double b)
        {
            return a - b;
        }
    }
}
