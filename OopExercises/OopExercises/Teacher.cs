using System;
using System.Collections.Generic;
using System.Text;

namespace OopExercises
{
    public class Teacher : Person, IPerson
    {


        public string Title { get; set; }

        public Teacher()
        {
        }

        public Teacher(string name, string email, string title) : base(name, email)
        {
            Title = title;
        }

        public new string Talking()
        {
            return "Teacher  " + Name + " is talking";
        }

        public new string Sleeping()
        {
            return "Teacher is sleeping";
        }
    }
}
