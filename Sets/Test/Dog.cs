using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Dog : Mammal
    {
        public string Breed { get; set; }

        public Dog(int age, string breed) : base(age)
        {
            Breed = breed;
        }

        public void WagTail()
        {
            Console.WriteLine($"Tails is wagging...");
        }
    }
}
