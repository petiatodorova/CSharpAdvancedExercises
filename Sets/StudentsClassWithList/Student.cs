using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsClassWithList
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<double> Marks { get; set; }
        public Dictionary<string, double> Strengths { get; set; }
        public string this[string index]
        {
            get { return index; }
            set { index = value; }
        }

        public Student()
        {
        }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Marks = new List<double>();
            Strengths = new Dictionary<string, double>();
        }
    }
}
