using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006八硬币
{
    public class Coin
    {
        private double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public Coin(double wei, string typ)
        {
            Weight = wei;
            Type = typ;
        }
    }
}
