using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat();
            Cat cat1 = new Cat();
            Dog dog = new Dog();
            Console.WriteLine($"Animal cat --> {cat.SayHello()}");  
            Console.WriteLine($"Cat cat --> {cat1.SayHello()}");  
            Console.WriteLine($"Cat cat --> {dog.SayHello()}");  

        }
    }
}
