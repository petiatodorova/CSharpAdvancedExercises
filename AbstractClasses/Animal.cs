using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    public abstract class Animal
    {
        public Animal()
        {

        }

        public Animal(int age, string name, string color)
        {
            this.Age = age;
            this.Name = name;
            this.Color = color;
        }

        public int Age { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public abstract string SayHello();
    }
}
