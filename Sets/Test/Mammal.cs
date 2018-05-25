using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Mammal
    {
        public int Age { get; set; }

        public Mammal(int age)
        {
            Age = age;
        }

        public void Sleep()
        {
            Console.WriteLine($"I'm sleeping! Be silent!");
        }
    }
}
