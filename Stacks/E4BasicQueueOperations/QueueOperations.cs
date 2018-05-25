using System;
using System.Linq;
using System.Collections.Generic;

namespace E4BasicQueueOperations
{
    class QueueOperations
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

            Queue<int> numbersQueue = new Queue<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbersQueue.Enqueue(numbers[i]);
            }

            int countDequeues = Math.Min(n, s);
            for (int j = 0; j < countDequeues; j++)
            {
                numbersQueue.Dequeue();
            }

            if (numbersQueue.Count == 0)
            {
                Console.WriteLine($"0");
            }
            else
            {
                if (numbersQueue.Contains(x))
                {
                    Console.WriteLine($"true");
                }
                else
                {
                    Console.WriteLine($"{numbersQueue.Min()}");
                }
            }
        }
    }
}
