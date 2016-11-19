using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_超市收银系统
{
    class Goods
    {
        public string ID
        {
            get;
            set;
        }
        public double Price
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public Goods(string name,double price,string id)
        {
            this.Name = name;
            this.Price = price;
            this.ID = id;
        }
    }
}
