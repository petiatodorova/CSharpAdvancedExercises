using System;
using System.Collections.Generic;
using System.Text;

namespace OopExercises
{
    class Person : IPerson
    {
        public string Name { get; private set; }
        public string Email { get; private set; }

        public Person()
        {
        }

        public Person(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
