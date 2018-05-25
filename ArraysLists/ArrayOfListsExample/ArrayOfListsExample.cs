using System;
using System.Collections.Generic;

namespace ArrayOfListsExample
{
    class ArrayOfListsExample
    {
        static void Main(string[] args)
        {
            List<int>[] a = new List<int>[3];
            for (int i = 0; i < 3; i++)
            {
                a[i] = new List<int>();
            }

            a[0].Add(3);
            a[0].Add(6);
            a[0].Add(37);
            a[0].Add(42);
            a[1].Add(6);
            a[1].Add(36);
            a[1].Add(35);
            a[1].Add(65);
            a[2].Add(43);
            a[2].Add(56);
            a[2].Add(3101);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{string.Join(" ", a[i])}");
            }
        }
    }
}
