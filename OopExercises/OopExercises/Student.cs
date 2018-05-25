using System;
using System.Collections.Generic;
using System.Text;

namespace OopExercises
{
    public class Student : Person, IPerson
    {
        public List<string> Classes { get; set; }

        public Student()
        {
        }

        public Student(string name, string email, List<string> classes) : base(name, email)
        {
            Classes = classes;
        }

        public new string Talking()
        {
            return "Student " + Name + " is talking";
        }

        public new string Sleeping()
        {
            return "Student is sleeping";
        }
    }
}
