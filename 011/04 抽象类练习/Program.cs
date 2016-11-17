using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_抽象类练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Square(3,2);
            double area= shape.GetArea();
            double length = shape.GetLength();
            Console.WriteLine("这个图形的面积是{0}，周长是{1}",area,length);
            Console.ReadKey();
        }
    }

    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetLength();
    }

    public class Circle:Shape
    {
        private double _r;

        public  double R
        {
            get
            {
                return _r;
            }

            set
            {
                _r = value;
            }
        }

        public Circle(double r)
        {
            this.R = r;   
        }
        public override double GetArea()
        {
            return Math.PI*R*R;
        }
        public override double GetLength()
        {
            return Math.PI * 2 * R;
        }
    }

    public class Square:Shape
    {
        private double _length;

        public double Length
        {
            get
            {
                return _length;
            }

            set
            {
                _length = value;
            }
        }
        private double _height;
        public double Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
            }
        }
        public Square(double length,double height)
        {
            this.Length = length;
            this.Height = height;
        }

        public override double GetArea()
        {
            return Length*Height;
        }
        public override double GetLength()
        {
            return 2*(Length+Height);
        }
    }
}
