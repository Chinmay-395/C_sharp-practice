using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TheConsoleApp.Tutorial
{
    class CollectionsClass
    {
        #region ArrayList Code
        public void someFunc()
        {
            ArrayList aList = new ArrayList();
            aList.Add("Bob");
            aList.Add(40);
            Console.WriteLine("CountL {0}", aList.Count);
            Console.WriteLine("Capacity: {0}", aList.Capacity);
            ArrayList aList2 = new ArrayList();
            aList2.AddRange(new object[] { "Mike", "Sally", "Egg" });
            aList.AddRange(aList2);
            aList2.Sort();
            aList2.Reverse();
            aList2.Insert(1, "Turkey");

            ArrayList range = aList2.GetRange(0, 2);

             foreach(object o in aList)
            {
                Console.WriteLine(o);
            }

        }
        
        
        #endregion
    }
}
