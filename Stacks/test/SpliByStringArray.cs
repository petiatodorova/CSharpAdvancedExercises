using System;
using System.Linq;
using System.Collections.Generic;

namespace test
{
    class SpliByStringArray
    {
        static void Main(string[] args)
        {
            string input = "quwdiud3Alklj4Aoafhoqh5AljvoJV";
            string[] splitting = { "3A", "4A", "5A" };
            string[] arr = input
                .Split(splitting, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Console.WriteLine($"{string.Join("  |  ", arr)}");
        }
    }
}
