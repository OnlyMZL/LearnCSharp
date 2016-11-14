using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_继承练习
{
    class Driver : Person
    {
        private int _drivertime;
        public int Drivertime
        {
            get
            {
                return _drivertime;
            }

            set
            {
                _drivertime = value;
            }
        }

        public Driver(string name, char gender, int age, int drivertime) : base(name, gender, age)
        {
            this.Drivertime = drivertime;
        }

        public void Intro()
        {
            Console.WriteLine(this.Name + this.Gender + this.Age + this.Drivertime);
        }
    }
}
