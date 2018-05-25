using System;
using System.Linq;
using System.Collections.Generic;

namespace MaxSequenceOfIncreasingElements
{
    class MaxSequenceOfIncreasingElements
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] helper = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                int length = 1;
                int j = i;
                while (j < helper.Length - 1)
                {
                    if (numbers[j] < numbers[j + 1])
                    {
                        length++;
                    }
                    else
                    {
                        break;
                    }
                    j++;
                }
                helper[i] = length;
            }

            int maxLength = -1;
            int index = 0;

            for (int m = 0; m < helper.Length; m++)
            {
                if (helper[m] > maxLength)
                {
                    maxLength = helper[m];
                    index = m;
                }
            }

            for (int ind = index; ind < maxLength + index; ind++)
            {
                Console.Write($"{numbers[ind]} ");
            }
        }
    }
}
