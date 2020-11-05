using System;
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
                    #region Data-Structure code practice
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
                    #endregion
                    #region Algorithms practice
                    case 2:
                        Console.WriteLine("Algorithms");
                        break;
                    #endregion
                    case 3:
                        //  --------------------- Tutorial --------------------- //
                        Console.WriteLine("Tutorial \n" +
                            "Opt-1: Multiple-Inheritance \n" +
                            "Opt-2: Structure in C# \n");
                        int choice = Int16.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            #region Multiple inheritence tutrial
                            case 1:
                                var tryingMultipleInheritance = new MultipleInheritancExample();
                                tryingMultipleInheritance.AMethod();
                                tryingMultipleInheritance.BMethod();
                                break;
                            #endregion

                            #region Structs tutorial
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
                            #endregion

                            #region Abstract Classes
                            case 3:
                                //One way of initializing abstract class
                                Abstract_class_related P = new Abstract_class_related();
                                P.Print();
                                P.AnotherMethod();
                                //Another way of initialzing abstract class
                                Abstract_className_Customer P_new = new Abstract_class_related();
                                P_new.Print();
                                /* The above code works because,
                                 * A parent class reference variable can point to a
                                 * derived class object.
                                 */
                                break;
                            #endregion

                            #region Class Constructors
                            case 4:
                                Varying_Constructor_technique cust_var = new Varying_Constructor_technique();
                                Console.WriteLine(cust_var.Id);
                                Console.WriteLine(cust_var.Name);
                                var customer_ = new Varying_Constructor_technique(1, "Johnson");
                                Console.WriteLine(customer_.Id);
                                Console.WriteLine(customer_.Name);
                                break;
                            #endregion

                            #region Collections Library
                            case 5:
                                CollectionsClass c_class = new CollectionsClass();
                                c_class.someFunc();
                                break;

                            #endregion
                        }

                        break;
                    #region Case 4 is about Coding Problem solving
                    case 4:
                        Console.WriteLine("Case-2");
                        break;
                    #endregion

                    #region Case 5 is about Custom-Console-App
                    case 5:
                        needIGoOn = false;
                        Console.WriteLine("You Quit your Main Project");
                        break;
                    #endregion
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
