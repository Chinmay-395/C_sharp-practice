using System;
using System.Collections.Generic;
using System.Text;

namespace TheConsoleApp.Tutorial
{
    public struct Customer
    {
        private int _id;
        private string _name;
        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public string Name 
        { 
            //get => _name; 
            //set => _name = value; 
            get { return this._name; }
            set { this._name = value; }
        }
        //Struct constructor defined below
        public Customer(int Id, string Name)
        {
            this._id = Id;
            this._name = Name;
        }
        //Custom function in struct
        public void PrintDetails()
        {
            Console.WriteLine("Id = {0} && Name={1}",this._id,this._name);
        }
    }
    class Structs_Related
    {
    }
}
