using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_使用借口代替委托
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductFactory pizzaFactory = new PizzaFactory();
            IProductFactory toycarFactory = new ToyCarFactory();
            Box box1 = new Box();
            Box box2 = new Box();

            WrapFactory wrapFactory = new WrapFactory();

            box1 = wrapFactory.WrapProduct(pizzaFactory);
            box2 = wrapFactory.WrapProduct(toycarFactory);

            Console.WriteLine(box1.Product.Name);
            Console.WriteLine(box2.Product.Name);
            Console.ReadKey();
        }
    }

    interface IProductFactory
    {
        Product Make();
    }

    class Product
    {
        public string Name { get; set; }
    }

    class Box
    {
        public Product Product { get; set; }
    }

    class WrapFactory
    {
        public Box WrapProduct(IProductFactory productFactory)
        {
            Box box = new Box();
            box.Product = productFactory.Make();
            return box;
        }
    }

    
    class PizzaFactory : IProductFactory
    {
        public Product Make()
        {
            Product product =new Product();
            product.Name = "Pizza";
            return product;
        }
    }

    class ToyCarFactory : IProductFactory
    {
        public Product Make()
        {
            Product product=new Product();
            product.Name = "ToyCar";
            return product;
        }
    }
}
