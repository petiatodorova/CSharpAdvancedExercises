using System;
using System.Linq;
using System.Collections.Generic;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int length = numbers.Count;

            List<int> helper = new List<int>();

            // Counting length times we find current Min element and it's index, 
            // add it to helper and remove it from numbers.
            for (int i = 0; i < length; i++)
            {
                int currentMin = numbers.Min();
                helper.Add(currentMin);
                int indexOfMin = numbers.IndexOf(currentMin);
                numbers.RemoveAt(indexOfMin);
            }

            //Finally we print helper, which is already sorted
            Console.WriteLine($"{string.Join(" ", helper)}");
        }
    }
}
