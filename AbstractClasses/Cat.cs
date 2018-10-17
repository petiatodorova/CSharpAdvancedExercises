using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    public class Cat : Animal
    {
        public Cat() 
            : base()
        {

        }

        public Cat(int age, string name, string color) 
            : base(age, name, color)
        {

        }

        public override string SayHello() => $"Cat say Miau";
    }
}
