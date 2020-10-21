using System;
using System.Threading;

namespace TheConsoleApp.DataStructure
{
    public class LinkedListProgram
    {
        //For creating a new node
        public class LinkedListNode
        {
            public int data;
            public LinkedListNode next;
            //constructor for initalizing the node with required data
            public LinkedListNode(int x)
            {
                data = x;
                next = null;
            }
        }
        //Creating a Linked-List 
        public class LinkedList
        {   
            //initalizing the Linked-List with the start pointer
            int count;  //this will count how many nodes are in the Linked-List
            LinkedListNode head; //at the very initial stage the when the linked-list 
                                 //is empty it will only have a "head" pointer pointing to null
            public LinkedList() //Constructor for creating the linked-list
            {
                count = 0;
                head = null;
            }
            public void AddNodeToFront(int data)
            {
                LinkedListNode node = new LinkedListNode(data); //this will create a new node
                //More so, it would create a reference to the Linked-List defined earlier.
                node.next = head;
                head = node;
                count++;
            }
            public void PrintList()
            {
                LinkedListNode runner = head; // this will create a temporary copy of head-node
                                               //so as to iterate through the entire Linked-list
                while(runner != null)
                {
                    Console.WriteLine(runner.data);
                    runner = runner.next;
                }
            }
        }

    }
    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("The baseClass constructor ran \n");
            Console.WriteLine("The Add node and delete node functionality needs to be added");
            Console.WriteLine("Also change the way how naming conventions are in this program" +
                "make those functionality as choice based");
        }
        public void BaseMethod()
        {
            LinkedListProgram.LinkedList linkedList = new LinkedListProgram.LinkedList();
            linkedList.AddNodeToFront(15);
            linkedList.AddNodeToFront(5);
            linkedList.AddNodeToFront(7);
            linkedList.AddNodeToFront(1);
            linkedList.AddNodeToFront(5);
            linkedList.AddNodeToFront(10);
            linkedList.AddNodeToFront(15);
            linkedList.AddNodeToFront(4);
            linkedList.PrintList();
        }
    }
    
}
