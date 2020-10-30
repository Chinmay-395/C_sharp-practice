using System;
using System.Collections.Generic;
using System.Text;

namespace TheConsoleApp.Tutorial
{
    abstract class Abstract_className_Customer
    {
        public abstract void Print();
        public void AnotherMethod()
        {
            Console.WriteLine("This is a method which is inside abstract class but not a abstract method");
        }
    }
    
    class Abstract_class_related : Abstract_className_Customer
    {
        public override void Print()
        {
            Console.WriteLine("Print Method in Abstract class");
        }
        //public o
    }
}
