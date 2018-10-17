using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            Dog dog = new Dog();
            InheritedAnimal animal = new InheritedAnimal(3);

            Console.WriteLine($"{animal.NumberOfEyes}");
            
            Console.WriteLine($"Cat --> {cat1.SayHello()}");  
            Console.WriteLine($"Dog --> {dog.SayHello()}");  

        }
    }
}
