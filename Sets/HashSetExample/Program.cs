using System;
using System.Collections.Generic;
using System.Linq;

namespace HashSetExample
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> test = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            Console.WriteLine($"{string.Join(' ', test.OrderByDescending(x => x))}");
  


        }
    }
}
