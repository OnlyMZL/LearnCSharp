using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer
{
    class MyClass
    {
        //(3)
        public readonly string Name;
        private int intVal;

        public int Val
        {
            get
            {
                return intVal;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    intVal = value;
                }
                else
                {
                    throw (new ArgumentOutOfRangeException("Val", value, "Val must be assigned a value between 0 and 10."));
                }
            }
        }

        public override string ToString()
        {
            return "Name:"+Name+"\nVal:"+Val;
        }


        private MyClass(string newName)
        {
            Name = newName;
            intVal = 0;
        }
        private MyClass() : this("Default Name")
        { }



        //(4)
        static void Main(string[] args)
        {
            Console.WriteLine("Creating object myObj...");
            MyClass myObj = new MyClass("My Object");
            Console.WriteLine("myObj created.");
            for (int i = -1; i <= 0; i++)
            {
                try
                {
                    Console.WriteLine("\nAttempting to assign {0} to myObj.Val...",i);
                    myObj.Val = i;
                    Console.WriteLine("Value {0} assigned to myObj.Val.",myObj.Val);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Exception {0} thrown.",e.GetType().FullName);
                    Console.WriteLine("Message:\n\"{0}\"",e.Message);
                }
            }
            Console.WriteLine("\nOutputting myObj.ToString()...");
            Console.WriteLine(myObj.ToString());
            Console.WriteLine("myObj.ToString() Output.");
            Console.Read();

        }
    }
}
