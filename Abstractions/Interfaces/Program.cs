using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfCars = new List<Car>();
            Opel opel = new Opel(1986, "SomeOpel");
            Mercedes mercedes = new Mercedes(2018, "SomeMercedes");
            
            listOfCars.Add(opel);
            listOfCars.Add(mercedes);
            
            foreach (var car in listOfCars)
            {
                Console.WriteLine($"{car.SayBrum()}");
            }
        }
    }
}
