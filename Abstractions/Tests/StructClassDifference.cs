using System;

namespace Tests
{
    class StructClassDifference
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = Calculate(a);
            Console.WriteLine($"a is --> {a}");
            Console.WriteLine($"b is --> {b}");

            Cat cat = new Cat(8);
            Console.WriteLine($"Cat age --> {cat.Age}");
            cat.Age = Calculate(cat.Age);
            Console.WriteLine($"Cat new age --> {cat.Age}");
        }

        static int Calculate(int number)
        {
            number = number * 3;
            return number;
        }

        public class Cat {
            public Cat(int age)
            {
                this.Age = age;
            }
            public int Age { get; set; }
        }
    }
}
