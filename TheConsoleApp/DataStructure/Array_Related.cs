using System;
using System.Collections.Generic;
using System.Text;

namespace TheConsoleApp.DataStructure
{
    class Array_Related
    {
        public int[] grades = { 30, 430, 23, 10 };

        public void someFunc()
        {   // if we want to search through an array
            // The below function returns index value
            Console.WriteLine(Array.IndexOf(grades, 23));
            // Sorting an array
            Array.Sort(grades);

        }
       
        

    }
}
