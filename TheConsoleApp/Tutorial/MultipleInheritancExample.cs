using System;
using System.Collections.Generic;
using System.Text;

namespace TheConsoleApp.Tutorial
{
    interface IA
    {
        void AMethod();
    }
    class A: IA
    {
        public void AMethod()
        {
            Console.WriteLine("This is an interface_method by A class");
        }
    }
    interface IB
    {
        void BMethod();
    }
    class B: IB
    {
        public void BMethod()
        {
            Console.WriteLine("This is an interface_method by B class");
        }
    }
    class MultipleInheritancExample: IA,IB
    {
        /* we dont need to rewrite the implmentation of 
            the methods for interface we can simply create
            an instance of both classes A & B,
            call the interface method and use objects to 
            run the method defined in indiviual class
        */
        A a = new A();
        B b = new B();
        public void AMethod()
        {
            a.AMethod();
        }
        public void BMethod()
        {
            b.BMethod();
        }
        
    }

}
