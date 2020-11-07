using System;
using System.Collections.Generic;
using System.Text;

namespace TheConsoleApp.Tutorial
{

    class Student
    {
        private int _id;
        private string _Name;
        private int _passMark = 35;
        private string _city;
        private string _email;

        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student ID cannot be negative");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("The name cant be empty");
                }
                this._Name = value;
            }
            get
            {
                return this._Name;
            }
        }
        public int PassMark
        {
            get
            {
                return this._passMark;
            }
        }

        public string City { get; set; }
        public string Email { get; set; }

        //THe constructor implementations
        //public Student(int Id_field)
        //{//, string Name_field, string City_field, string Email_field
        //    this.Id = Id_field;
        //}
    }

    class GettersAndSetter
    {
    }
}
