using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_继承练习
{
    class Student : Person
    {
        private int graduatetime;

        public int Graduatetime
        {
            get
            {
                return graduatetime;
            }

            set
            {
                graduatetime = value;
            }
        }
        public Student(string name, char gender, int age, int graduatetime) : base(name, gender, age)
        {
            this.Graduatetime = graduatetime;
        }

        public void Intro()
        {
            Console.WriteLine(this.Name + this.Gender + this.Age + this.Graduatetime);
        }
    }
}
