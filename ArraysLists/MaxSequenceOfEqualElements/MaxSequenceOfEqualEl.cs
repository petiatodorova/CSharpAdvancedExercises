using System;
using System.Linq;
using System.Collections.Generic;

namespace MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualEl
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int start = 0;
            int length = 1;
            int beststart = 0;
            int bestlength = 1;

            for (int i = 1; i < numbers.Length; i++)
            {

                if (numbers[i] == numbers[i - 1])
                {
                    length++;
                }
                else
                {
                    start = i;
                    length = 1;
                }
                if (length > bestlength)
                {
                    bestlength = length;
                    beststart = i;
                }
            }

            for (int j = 0; j < bestlength; j++)
            {

                Console.Write($"{numbers[beststart]} ");
            }
        }
    }
}
