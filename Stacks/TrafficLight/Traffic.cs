using System;
using System.Collections.Generic;
using System.Linq;

namespace TrafficLight
{
    class Traffic
    {
        static void Main(string[] args)
        {

            int carsCount = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string currentCar = "";

            string input = Console.ReadLine();
            int count = 0;

            while (true)
            {
                if (input == "end")
                {
                    break;
                }

                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    int currentCount = Math.Min(carsCount, cars.Count);
                    count = count + currentCount;
                    for (int i = 0; i < currentCount; i++)
                    {
                        currentCar = cars.Dequeue();
                        Console.WriteLine($"{currentCar} passed!"); ;
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
