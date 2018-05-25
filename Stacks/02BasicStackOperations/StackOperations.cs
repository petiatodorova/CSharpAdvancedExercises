using System;
using System.Linq;
using System.Collections.Generic;

namespace _02BasicStackOperations
{
    class StackOperations
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = commands[0];
            int s = commands[1];
            int x = commands[2];

            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> numbersStack = new Stack<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbersStack.Push(numbers[i]);
            }

            int countPops = Math.Min(n, s);
            for (int j = 0; j < countPops; j++)
            {
                numbersStack.Pop();
            }

            if (numbersStack.Count == 0)
            {
                Console.WriteLine($"0");
            }
            else
            {
                if (numbersStack.Contains(x))
                {
                    Console.WriteLine($"true");
                }
                else
                {
                    Console.WriteLine($"{numbersStack.Min()}");
                }
            }

        }
    }
}
