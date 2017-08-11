using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006八硬币
{
    public class Coin
    {
        private double _weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private string _type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public Coin(double weight, string type)
        {
            Weight = weight;
            Type = type;
        }
    }
}
