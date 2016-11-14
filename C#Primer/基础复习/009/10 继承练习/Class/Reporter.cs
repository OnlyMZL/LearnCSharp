using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_继承练习
{
    class Reporter : Person
    {
        private string _hobby;
        public string Hobby
        {
            get
            {
                return _hobby;
            }

            set
            {
                _hobby = value;
            }
        }
        public Reporter(string name, char gender, int age, string hobby) : base(name, gender, age)
        {
            this.Hobby = Hobby;
        }

        public void Intro()
        {
            Console.WriteLine(this.Name + this.Gender + this.Age + this.Hobby);
        }
    }
}
