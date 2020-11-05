using System;
using System.Collections.Generic;
using System.Text;

namespace TheConsoleApp.Tutorial
{
    /* 1)constructors do not have return type
             * 2)if we need to create initilization of the
             * object we use constructors
             * 3)even if you don't define a constructor the c# compiler
             *  creates one but doesn't do anything.
             *      if initilized with numbers then it sets them with Zero
             *      if initilized with boolean then it sets them to false
             *      For reference-type (ie arrays) sets them to null
             *      For character sets them to empty character.
             * 4)C# supports constructor overloading
             *    4.1)Why do we need constructor overloading?
             *    Ans: If we want to have different ways of initializing 
             *         an object using different number of parameters, then 
             *         we must do constructor overloading as we do method 
             *         overloading when we want different definitions of a 
             *         method based on different parameters.
             *         
             *  NOTE: once we override the constructor the C# compiler doesn't
             *          create default constructor
            */
    class Varying_Constructor_technique
    {
        public int Id;
        public string Name;
        public List<Order> Orders;
        //whenever using List initilize it as an empty List
        public Varying_Constructor_technique()
        {
            Orders = new List<Order>();
        }

        public Varying_Constructor_technique(int id)
            : this()
        {
            this.Id = id;
        }

        public Varying_Constructor_technique(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }
    public class Order
    {
    }
}
 