using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfCars = new List<ICar>();
            Opel opel = new Opel(1986, "SomeOpel");
            Mercedes mercedes = new Mercedes(2018, "SomeMercedes");
            FromAbstractCar abstractCar = new FromAbstractCar(1921, "Ferrari");
            listOfCars.Add(opel);
            listOfCars.Add(mercedes);
            

            foreach (var car in listOfCars)
            {
                Console.WriteLine($"{car.SayBrum()}");
            }

            Console.WriteLine($"{abstractCar.Model}");


        }
    }
}
