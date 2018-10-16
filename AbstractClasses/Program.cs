using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(32, "Mimi", "white");
            Console.WriteLine($"{cat.SayHello()}");  
            Console.WriteLine($"{cat.Age}");  
            Console.WriteLine($"{cat.Color}");  
            Console.WriteLine($"{cat.Name}");  
        }
    }
}
