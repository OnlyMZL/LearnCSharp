﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p216
{
    public class ClassA
    {
        private int state = -1;
        public int State
        {
            get
            {
                return state;
            }
        }
        public class ClassB
        {
            public void SetPrivateState(ClassA target, int newState)
            {
                target.state = newState;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassA myObject = new ClassA();
            Console.WriteLine("myObject.State={0}",myObject.State);
            ClassA.ClassB myOtherObject = new ClassA.ClassB();
            myOtherObject.SetPrivateState(myObject,999);
            Console.WriteLine("myObject.State={0}",myObject.State);
            Console.Read();
        }
    }
}
