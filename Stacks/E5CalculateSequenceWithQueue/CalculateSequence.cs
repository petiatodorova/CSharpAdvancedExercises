using System;
using System.Linq;
using System.Collections.Generic;

namespace E5CalculateSequenceWithQueue
{
    class CalculateSequence
    {
        static void Main(string[] args)
        {

            long n = long.Parse(Console.ReadLine());
            Queue<long> sequence = new Queue<long>();
            sequence.Enqueue(n);
            long[] helpArr = new long[19];

            helpArr[0] = n;
            helpArr[1] = n;

            for (int j = 1; j <= 16; j++)
            {
                
                helpArr[j + 1] = helpArr[j] + 1;
                sequence.Enqueue(helpArr[j + 1]);
                sequence.Enqueue(helpArr[j] * 2 + 1);
                sequence.Enqueue(helpArr[j] + 2);
            }

            sequence.Enqueue(helpArr[17] + 1);

            Console.WriteLine($"{string.Join(' ', sequence)}");
        }
    }
}
