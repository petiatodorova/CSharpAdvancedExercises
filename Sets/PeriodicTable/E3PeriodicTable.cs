using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class E3PeriodicTable
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            SortedSet<string> result = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] row = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int j = 0; j < row.Length; j++)
                {
                    result.Add(row[j]);
                }
            }

            Console.WriteLine($"{string.Join(' ', result)}");
        }
    }
}
