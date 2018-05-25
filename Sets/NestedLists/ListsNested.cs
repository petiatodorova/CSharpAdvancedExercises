using System;
using System.Collections.Generic;

namespace NestedLists
{
    class ListsNested
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 33, 55, 123, 66, 77, 88, 98 };
            List<List<int>> test = new List<List<int>>(3);

            for (int i = 0; i < 3; i++)
            {
                test.Add(new List<int>());
            }

            for (int j = 0; j < numbers.Length; j++)
            {
                int currentNum = numbers[j];
                int remainder = numbers[j] % 3;
                test[remainder].Add(currentNum);
            }

            for (int z = 0; z < test.Count; z++)
            {
                Console.WriteLine($"{string.Join("  |  ", test[z])}");
            }
        }
    }
}
