using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace TheConsoleApp.Tutorial
{
    class CollectionsClass
    {
        #region ArrayList Code
        public void FuncForArrayList()
        {
            ArrayList aList = new ArrayList();
            aList.Add("Bob");
            aList.Add(40);
            Console.WriteLine("CountL {0}", aList.Count);
            Console.WriteLine("Capacity: {0}", aList.Capacity);
            ArrayList aList2 = new ArrayList();
            // converting an array into ArrayList
            aList2.AddRange(new object[] { "Mike", "Sally", "Egg" });
            aList.AddRange(aList2);
            aList2.Sort();
            aList2.Reverse();
            aList2.Insert(1, "Turkey");

            ArrayList range = aList2.GetRange(0, 2);
            Console.WriteLine("This is for `range` from 0-2 inside aList2 ");
            foreach(object element in range)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("The aList");
            foreach(object o in aList)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("The aList2 with object as data-type");
            foreach(object attribute in aList2)
            {
                Console.WriteLine(attribute);
            }
            aList2.RemoveAt(0);
            Console.WriteLine("Removed the element at 0th position in aList2");
            Console.WriteLine("The aList2 with var as data-type");
            foreach (var attribute in aList2)
            {
                Console.WriteLine(attribute);
            }
            aList2.RemoveRange(0, 2);
            Console.WriteLine("Removed the element from range_0-2 position in aList2");
            foreach (var attribute in aList2)
            {
                Console.WriteLine(attribute);
            }
            Console.WriteLine("Turkey is in the aList1 arrayList " +
                " "+aList.IndexOf(40));
            aList2.AddRange(new object[] { "NewEgg", "Amazon", "PrimeABGB", "Flipkart" });
            
            Console.WriteLine("Amazon is in the aList2 arrayList " +
                " " + aList2.IndexOf("Amazon"));

            //Convert an ArrayList to regular array
            //make sure that all the values inside the arrayList have same dataType
            //Before converting it into array
            string[] myArray = (string[])aList2.ToArray(typeof(string));
        }
        public static void PrintIndexAndValues(IEnumerable myList)
        {
            int i = 0;
            foreach (Object obj in myList)
                Console.WriteLine("   [{0}]:    {1}", i++, obj);
            Console.WriteLine();
        }

        #endregion

        #region Dictionaries
        public void FuncForDictionary()
        {
            Dictionary<string, string> superheros = new Dictionary<string, string>();
            superheros.Add("Tony Stark", "Iron Man");
            superheros.Add("Peter Parker", "SpiderMan");
            superheros.Add("Dr.Steven Strange", "Sorcerer supereme");

            superheros.Remove("Tony Stark");
            Console.WriteLine( "Count: {0} ", superheros.ContainsKey("Peter Parker"));
            foreach(KeyValuePair<String,String> item in superheros)
            {
                Console.WriteLine("{0}:{1}",item.Key,item.Value);
            }
        }


        #endregion

        #region Queue Data-Structure Code
        
        public void FuncForQueue()
        {
            Queue VarQueue = new Queue();
            VarQueue.Enqueue(1);
            VarQueue.Enqueue(2);
            VarQueue.Enqueue(3);
            VarQueue.Enqueue(4);
            VarQueue.Enqueue(5);

            foreach(object o in VarQueue)
            {
                Console.WriteLine($"Queue: {o}",o);
            }

            Console.WriteLine("is 1 in QUeue: {0}",VarQueue.Contains(1));
            Console.WriteLine("Remove an item {0}",VarQueue.Dequeue());
            Console.WriteLine("Peeking an item {0}",VarQueue.Peek());
            //converting from Queue to Array
            object[] numArray = VarQueue.ToArray();
        }


        #endregion

        #region Stack Data-Structure code

        public void FuncForStacks()
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine("Peeking {0}",stack.Peek());
            Console.WriteLine("Poping {0}", stack.Pop());
            Console.WriteLine("Contains {0}",stack.Contains(4));

        }
        

        #endregion
    }
}
