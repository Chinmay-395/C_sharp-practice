﻿using System;
using TheConsoleApp.DataStructure;
using TheConsoleApp.Tutorial;

namespace TheConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            bool needIGoOn = true;
            while (needIGoOn)
            {
                Console.WriteLine("Option-1: Data Structure \n" +
                                  "Option-2: Algorithms \n" +
                                  "OPtion-3: Tutorial \n" +
                                  "Option-4: Coding Problems \n" +
                                  "Option-5: Sub-Console-App \n" +
                                  "Option-6: Quit \n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Data Structure");
                        //LinkedListProgram linkedListProgram = new LinkedListProgram();
                        //LinkedListProgram.LinkedList linkedList = new LinkedListProgram.LinkedList();
                        ////LinkedList linkedList = new LinkedList();
                        //linkedList.AddNodeToFront(5);
                        //linkedList.AddNodeToFront(7);
                        //linkedList.AddNodeToFront(1);
                        //linkedList.AddNodeToFront(5);
                        //linkedList.AddNodeToFront(10);
                        //linkedList.AddNodeToFront(15);
                        //linkedList.AddNodeToFront(4);
                        //linkedList.PrintList();
                        //Console.WriteLine("\n --------------- \n we are done");
                        Console.WriteLine("We now have \n" +
                            "1)LinkedList (Custom one without collections) \n" +
                            "2) Array  \n");
                        int x = Int16.Parse(Console.ReadLine());
                        switch (x)
                        {
                            case 1:
                                BaseClass callThisClass = new BaseClass();
                                callThisClass.BaseMethod();
                                break;
                            case 2:
                                var array_variable = new Array_Related();
                                array_variable.someFunc();
                                break;
                        }
                        
                        break;
                    case 2:
                        Console.WriteLine("Algorithms");

                        break;
                    case 3:
                        //  --------------------- Tutorial --------------------- //
                        Console.WriteLine("Tutorial \n" +
                            "Opt-1: Multiple-Inheritance \n" +
                            "Opt-2: Structure in C# \n");
                        int choice = Int16.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                var tryingMultipleInheritance = new MultipleInheritancExample();
                                tryingMultipleInheritance.AMethod();
                                tryingMultipleInheritance.BMethod();
                                break;
                            case 2:
                                /* in the below syntax we are using default constructor
                                 * and declaring the properties of the elements inside the
                                 * structure.
                                 */
                                Customer C1 = new Customer(101, "Mark");
                                C1.PrintDetails();
                                Customer C2 = new Customer();
                                C2.ID = 102;     //comment this, for below explaination 
                                C2.Name = "John";//comment this, for below explaination 
                                C2.PrintDetails();
                                /********** What if we dont declare the properties ********* 
                                 *     Ans ``` Id = 0 && Name= ```
                                 *          basically these are default values
                                 */
                                //Another syntax for structure intialization
                                //it is called object initializer syntax
                                Customer C3 = new Customer
                                {
                                    ID = 103,
                                    Name = "Rob"
                                };
                                C3.PrintDetails();
                                break;
                        }
                        
                        break;
                    case 4:
                        Console.WriteLine("Case-2");
                        break;
                    case 5:
                        needIGoOn = false;
                        Console.WriteLine("You Quit your Main Project");
                        break;
                    case 6:
                        needIGoOn = false;
                        Console.WriteLine("You Quit your Main Project");
                        break;
                    default:
                        Console.WriteLine("Defaulted");
                        break;
                }

            }
        }
    }
}
