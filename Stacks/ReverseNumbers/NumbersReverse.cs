using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseNumbers
{
    class NumbersReverse
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Stack<int> stackNumbers = new Stack<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                stackNumbers.Push(numbers[i]);
            }

            while (stackNumbers.Count > 0)
            {
                Console.Write($"{stackNumbers.Pop()} ");
            }
        }
    }
}
