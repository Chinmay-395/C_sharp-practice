using System;
using TheConsoleApp.DataStructure;


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
                                  "OPtion-3: Coding Problems \n" +
                                  "Option-4: Sub-Console-App \n" +
                                  "Option-5: Quit \n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Case-1");
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
                        BaseClass callThisClass = new BaseClass();
                        callThisClass.BaseMethod();
                        break;
                    case 2:
                        Console.WriteLine("Case-2");
                        break;
                    case 3:
                        Console.WriteLine("Case-3");
                        break;
                    case 4:
                        Console.WriteLine("Case-2");
                        break;
                    case 5:
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
