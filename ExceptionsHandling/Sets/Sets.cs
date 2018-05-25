using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets
{
    class Sets
    {
        static void Main(string[] args)
        {
            HashSet<int> test = new HashSet<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                int number = int.Parse(Console.ReadLine());
                test.Add(number);
            }

            if (test.Contains(3))
            {
                test.Remove(3);
            }

            Console.WriteLine($"{string.Join("  ", test)}");

        }
    }
}
